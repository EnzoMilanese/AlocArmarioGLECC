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
                    secao.IdSecao = db.Secao.Count() + 1;
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

        public List<Secao> ListarSecoes()
        {
            var lista = db.Secao.AsNoTracking().ToList();
            return lista;
        }

        public string Deletar(Secao secao)
        {
            string resultado;

            try
            {
                db.Secao.Remove(secao);
                db.SaveChanges();
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }
    }
}
