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
        private BlocoController bc = new BlocoController();

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

        public string Alterar(Secao secao)
        {
            var erros = Validacao.ValidaDados(secao);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    Secao secaoDb = (from s in db.Secao
                                     where s.IdSecao == secao.IdSecao
                                     select s).SingleOrDefault();
                    secaoDb = secao;
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

        public string Deletar(Secao secao)
        {
            string resultado;

            try
            {
                secao = bc.Deletar(secao);
                db.Secao.Attach(secao);
                db.SaveChanges();
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
