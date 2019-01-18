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
        private Armario armario;
        private Locatario locatario;

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
                    resultado = ac.Alterar(armario);
                    if (resultado == "erro")
                        return resultado;
                    resultado = lc.Alterar(locatario);
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
    }
}
