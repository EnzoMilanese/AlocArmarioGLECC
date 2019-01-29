using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                    var entry = db.Entry(secao);

                    if (entry.State == EntityState.Detached)
                    {
                        var set = db.Set<Secao>();
                        Secao attachedEntity = set.Local.SingleOrDefault(e => e.IdSecao == secao.IdSecao);  // You need to have access to key

                        if (attachedEntity != null)
                        {
                            var attachedEntry = db.Entry(attachedEntity);
                            attachedEntry.CurrentValues.SetValues(secao);
                        }
                        else
                        {
                            entry.State = EntityState.Modified; // This should attach entity
                        }
                        db.SaveChanges();
                        resultado = "ok";
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
