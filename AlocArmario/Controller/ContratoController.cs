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
        private List<Armario> listaArmarios;
        private List<Locatario> listaLocatarios;

        public string Inserir(Contrato contrato)
        {
            listaArmarios = ac.ConsultarSemContrato();
            listaLocatarios = lc.ConsultarSemContrato();

            var erros = Validacao.ValidaDados(contrato);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Contrato.Add(contrato);
                    db.SaveChanges();
                    resultado = "ok";
                    foreach (var a in listaArmarios)
                        if (a.IdArmario == contrato.IdArmario)
                        {
                            a.TemContrato = true;
                            ac.Alterar(a);
                        }
                    foreach (var l in listaLocatarios)
                        if (l.IdLocatario == contrato.IdLocatario)
                        {
                            l.TemContrato = true;
                            lc.Alterar(l);
                        }
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

        public List<Contrato> Consultar()
        {
            var lista = db.Contrato.ToList();
            return lista;
        }
    }
}
