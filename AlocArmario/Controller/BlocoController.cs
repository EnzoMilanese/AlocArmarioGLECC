using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class BlocoController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();
        ArmarioController ac;

        private String Numerar(int n)
        {
            Char c = (Char) (94 + n);
            return c.ToString();
        }

        public List<Bloco> Consultar()
        {
            var lista = db.Bloco.ToList();
            return lista;
        }

        public string Inserir(Bloco bloco)
        {
            int quantBlocos = (from IdSecao in db.Bloco where IdSecao.IdSecao == bloco.Secao.IdSecao select IdSecao).Count();
            bloco.Nome = bloco.Secao.IdSecao.ToString() + Numerar(quantBlocos+1);

            var erros = Validacao.ValidaDados(bloco);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Bloco.Add(bloco);
                    db.SaveChanges();
                    ac = new ArmarioController();
                    for (int i = 1; i <= 16; i++)
                    {
                        string num = bloco.Nome + (char)i;
                        Armario armario = new Armario(num, bloco);
                        ac.Inserir(armario);
                    }
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
