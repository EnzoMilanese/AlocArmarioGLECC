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
            List<Armario> lista = (from a in db.Armario
                                   select a).ToList();
            return lista;
        }

        public List<Armario> ConsultarSemContrato()
        {
            List<Armario> lista = (from a in db.Armario
                                   where a.TemContrato == false
                                   select a).ToList();
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
                    Armario armarioDb = (from a in db.Armario
                                         where a.IdArmario == armario.IdArmario
                                         select a).SingleOrDefault();
                    armarioDb = armario;
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
                this.Alterar(armario);
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
                    this.Alterar(a);
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