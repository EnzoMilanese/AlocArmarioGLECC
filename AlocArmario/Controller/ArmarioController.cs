using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
            List<Armario> lista = (from a in db.Armario
                                   select a).ToList();
            return lista;
        }

        public List<Armario> ConsultarSemContrato()
        {
            List<Armario> lista = new List<Armario>();
            List<Armario> listaBase = (from a in db.Armario
                                   where a.TemContrato == false
                                   select a).ToList();

            foreach (Armario a in listaBase)
                if (!a.Danificado)
                    lista.Add(a);

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

        public string Alterar(Armario armario)
        {
            var erros = Validacao.ValidaDados(armario);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    var entry = db.Entry(armario);

                    if (entry.State == EntityState.Detached)
                    {
                        var set = db.Set<Armario>();
                        Armario attachedEntity = set.Local.SingleOrDefault(e => e.IdArmario == armario.IdArmario);

                        if (attachedEntity != null)
                        {
                            var attachedEntry = db.Entry(attachedEntity);
                            attachedEntry.CurrentValues.SetValues(armario);
                        }
                        else
                        {
                            entry.State = EntityState.Modified;
                        }
                    }
                    db.SaveChanges();
                    db.Entry(armario).Reload();
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

        public string Deletar(Bloco bloco)
        {
            string resultado = "";

            List<Armario> lista = ListarArmarios(bloco);
            foreach (Armario a in lista)
            {
                try
                {
                    db.Entry(a).State = EntityState.Deleted;
                    db.SaveChanges();
                    resultado = "ok";
                }
                catch (Exception)
                {
                    resultado = "erroBanco";
                    break;
                }
            }
            return resultado;
        }

        public List<Armario> ListarArmarios (Bloco bloco)
        {
            List<Armario> lista = (from a in db.Armario
                                   where a.IdBloco == bloco.IdBloco
                                   select a).ToList();
            return lista;
        }

        public string Danificado(Armario armario)
        {
            string resultado = "";
            if (armario.TemContrato)
            {
                resultado = "erro";
                return resultado;
            }

            armario.Danificado = true;
            try
            {
                Alterar(armario);
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }

        public string Danificado(List<Armario> armarios)
        {
            string resultado = "";
            foreach (Armario a in armarios)
            {
                a.Danificado = true;
                try
                {
                    Alterar(a);
                    resultado = "ok";
                }
                catch (Exception)
                {
                    resultado = "erroBanco";
                    break;
                }
            }
            return resultado;
        }

        public string Utilizavel(Armario armario)
        {
            string resultado = "";

            armario.Danificado = false;
            try
            {
                Alterar(armario);
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }

        public string Utilizavel(List<Armario> armarios)
        {
            string resultado = "";
            foreach (Armario a in armarios)
            {
                a.Danificado = false;
                try
                {
                    Alterar(a);
                    resultado = "ok";
                }
                catch (Exception)
                {
                    resultado = "erroBanco";
                    break;
                }
            }
            return resultado;
        }
    }
}