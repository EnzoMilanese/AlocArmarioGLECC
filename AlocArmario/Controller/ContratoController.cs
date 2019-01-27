using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class ContratoController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();
        private ArmarioController ac = new ArmarioController();
        private LocatarioController lc = new LocatarioController();
        private List<Armario> armarios = new List<Armario>();
        private List<Locatario> locatarios = new List<Locatario>();
        private Armario armario = new Armario();
        private Locatario locatario = new Locatario();

        public List<Contrato> Consultar()
        {
            var lista = db.Contrato.ToList();
            return lista;
        }

        public string Inserir(Contrato contrato)
        {
            armarios = ac.ConsultarSemContrato();
            locatarios = lc.ConsultarSemContrato();

            foreach (var a in armarios)
                if (a.IdArmario == contrato.IdArmario)
                    armario = a;

            foreach (var l in locatarios)
                if (l.IdLocatario == contrato.IdLocatario)
                    locatario = l;

            armario.TemContrato = true;
            locatario.TemContrato = true;

            var erros = Validacao.ValidaDados(contrato);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Contrato.Add(contrato);
                    armario.ContratoAtivo = contrato.IdArmario;
                    resultado = ac.Alterar(armario);
                    if (resultado == "erro")
                        return resultado;
                    resultado = lc.Alterar(locatario);
                    locatario.ContratoAtivo = contrato.IdArmario;
                    if (resultado == "erro")
                        return resultado; 
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    resultado = "erro";
                }
            }
            else
            {
                foreach (var e in erros)
                    resultado = (resultado + "\n" + e);
            }
            return resultado;
        }

        public string Terminar(Contrato contrato)
        {
            Armario armarioContrato;
            Locatario locatarioContrato;

            armarioContrato = contrato.Armario;
            locatarioContrato = contrato.Locatario;

            string resultado = "";
            try
            {
                armarioContrato.ContratoAtivo = 0;
                armarioContrato.TemContrato = false;
                ac.Alterar(armarioContrato);
                db.SaveChanges();

                locatarioContrato.ContratoAtivo = 0;
                locatarioContrato.TemContrato = false;
                lc.Alterar(locatarioContrato);
                db.SaveChanges();

                contrato.Terminado = true;
                Alterar(contrato);
                db.SaveChanges();
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }

        private string Alterar(Contrato contrato)
        {
            var erros = Validacao.ValidaDados(contrato);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    Contrato contratoDb = (from c in db.Contrato
                                           where c.IdContrato == contrato.IdContrato
                                           select c).SingleOrDefault();
                    contratoDb = contrato;
                    db.SaveChanges();
                    resultado = "ok";
                }
                catch (Exception)
                {
                    resultado = "erro";
                }
            }
            else
            {
                foreach (var e in erros)
                    resultado = (resultado + "\n" + e);
            }
            return resultado;
        }
    }
}
