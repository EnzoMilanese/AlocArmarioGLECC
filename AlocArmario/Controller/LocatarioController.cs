using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocArmario.Controller
{
    class LocatarioController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        public List<Locatario> Consultar()
        {
            List<Locatario> lista = (from l in db.Locatario
                                     select l).ToList();
            return lista;
        }

        public List<Locatario> ConsultarSemContrato()
        {
            List<Locatario> lista = (from l in db.Locatario
                                     where l.TemContrato == false
                                     select l).ToList();
            return lista;
        }

        public string Inserir(Locatario locatario)
        {
            var erros = Validacao.ValidaDados(locatario);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Locatario.Add(locatario);
                    db.SaveChanges();
                    resultado = "ok";
                }
                catch (Exception)
                {
                    resultado = "erro";
                }
            } else
            {
                foreach (var e in erros)
                    resultado = (resultado + "\n" + e);
            }
            return resultado;
        }
        
        public string Alterar(Locatario locatario)
        {
            var erros = Validacao.ValidaDados(locatario);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    Locatario locatarioDb = (from l in db.Locatario
                                             where l.IdLocatario == locatario.IdLocatario
                                             select l).SingleOrDefault();
                    locatarioDb = locatario;
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
