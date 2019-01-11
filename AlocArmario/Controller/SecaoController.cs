using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class SecaoController
        {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        public List<Secao> Consultar()
        {
            var lista = db.Secao.ToList();
            return lista;
        }

        public string Inserir(Secao secao)
        {
            var erros = Validacao.ValidaDados(secao);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Secao.Add(secao);
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
