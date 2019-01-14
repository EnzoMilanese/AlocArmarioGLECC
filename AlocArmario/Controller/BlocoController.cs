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
            Char c = (Char) (65 + n);
            return c.ToString();
        }

        private int QuantBlocos (Bloco bloco)
        {
            var listaBlocos = this.Consultar();
            int quant = 0;
            foreach (var b in listaBlocos)
            {
                if (b.IdSecao == bloco.IdSecao)
                    quant++;
            }
            return quant;
        }

        public List<Bloco> Consultar()
        {
            var lista = db.Bloco.ToList();
            return lista;
        }

        public string Inserir(Bloco bloco)
        {
            int quantBlocos = QuantBlocos(bloco);
            bloco.Nome = bloco.IdSecao.ToString() + Numerar(quantBlocos);

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
                        //Armario armario = new Armario(num, bloco);
                        //ac.Inserir(armario);
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
