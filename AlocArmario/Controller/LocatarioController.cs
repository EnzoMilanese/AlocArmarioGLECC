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
    }
}
