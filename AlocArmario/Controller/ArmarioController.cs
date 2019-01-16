using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class ArmarioController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        public List<Armario> Consultar()
        {
            var lista = db.Armario.ToList();
            return lista;
        }

        public string Inserir(Armario armario)
        {
            var erros = Validacao.ValidaDados(armario);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Armario.Add(armario);
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

        internal List<Armario> ConsultarSemContrato()
        {
            throw new NotImplementedException();
        }
    }
}