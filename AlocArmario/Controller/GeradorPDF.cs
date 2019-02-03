using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.IO;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Office.Interop.Word;
using AlocArmario.Model;

namespace AlocArmario.Controller
{
    class GeradorPDF
    {
        private string DIR;
        public const String SRC = @"..\..\source\Contrato_de_Alocacao.docx";


        public GeradorPDF()
        {
            DIR = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Contratos de Alocação\\");
            FileInfo file = new FileInfo(DIR);
            file.Directory.Create();
        }

        public bool GerarPDF(Contrato contrato)
        {
            try
            {
                string dest = String.Concat(DIR, (contrato.Locatario.Nome.Replace(" ", "_")) + contrato.DataInicio.ToString("_dd_MM_yyyy"));
                string destDOCX = String.Concat(dest, ".docx");
                string destPDF = String.Concat(dest, ".pdf");

                byte[] docByteArray = File.ReadAllBytes(SRC);
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(docByteArray, 0, docByteArray.Length);

                    using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(ms, true))
                    {
                        string docText = null;
                        using (StreamReader sr = new StreamReader(wordDoc.MainDocumentPart.GetStream()))
                            docText = sr.ReadToEnd();

                        docText = docText.Replace("[NOMELOCATARIO]", contrato.Locatario.Nome);
                        docText = docText.Replace("[PRONTUARIOLOCATARIO]", contrato.Locatario.Prontuario);
                        docText = docText.Replace("[TELLOCATARIO]", contrato.Locatario.Telefone);
                        docText = docText.Replace("[EMAILLOCATARIO]", contrato.Locatario.Email);
                        docText = docText.Replace("[NUMEROARMARIO]", contrato.Armario.Numero);
                        docText = docText.Replace("[BLOCOARMARIO]", contrato.Armario.Bloco.Numero);
                        docText = docText.Replace("[SECAOARMARIO]", contrato.Armario.Bloco.Secao.Nome);
                        if (contrato.TipoContrato == "Semestral")
                            docText = docText.Replace("[TIPOCONTRATO]", "semestre");
                        else
                            docText = docText.Replace("[TIPOCONTRATO]", "ano");
                        docText = docText.Replace("[CONTRATOINICIO]", contrato.DataInicio.ToString("dd/MM/yyyy"));

                        using (StreamWriter sw = new StreamWriter(wordDoc.MainDocumentPart.GetStream(FileMode.Create)))
                            sw.Write(docText);
                    }

                    ms.Seek(0L, SeekOrigin.Begin);

                    using (FileStream outputStream = File.Create(destDOCX))
                    {
                        ms.CopyTo(outputStream);
                        destDOCX = Path.GetFullPath(destDOCX);
                        destPDF = Path.GetFullPath(Path.ChangeExtension(destDOCX, "pdf"));
                    }
                        
                    Microsoft.Office.Interop.Word.Document wordDocument = null;
                    Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                    wordDocument = appWord.Documents.Open(destDOCX);
                    wordDocument.ExportAsFixedFormat(destPDF, WdExportFormat.wdExportFormatPDF);
                    wordDocument.Close();
                    appWord.Quit();

                    File.Delete(destDOCX);

                    return true;
                }
            }
            catch (Exception e)
            {
                string detalhe = e.Message;
                return false;
            }
        }
    }
}