using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
                    var entry = db.Entry(locatario);

                    if (entry.State == EntityState.Detached)
                    {
                        var set = db.Set<Locatario>();
                        Locatario attachedEntity = set.Local.SingleOrDefault(e => e.IdLocatario == locatario.IdLocatario);

                        if (attachedEntity != null)
                        {
                            var attachedEntry = db.Entry(attachedEntity);
                            attachedEntry.CurrentValues.SetValues(locatario);
                        }
                        else
                        {
                            entry.State = EntityState.Modified;
                        }
                    }
                    db.SaveChanges();
                    db.Entry(locatario).Reload();
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

        public string Deletar(Locatario locatario)
        {
            string resultado = "";
            try
            {
                db.Locatario.Attach(locatario);
                db.Locatario.Remove(locatario);
                db.SaveChanges();
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }

        public string AtualizarEntrada(object entrada)
        {
            string resultado = "";
            try
            {
                db.Entry(entrada).Reload();
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erro";
            }
            return resultado;
        }
    }
}
