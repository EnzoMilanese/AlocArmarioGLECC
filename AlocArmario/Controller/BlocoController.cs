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
        ArmarioController ac = new ArmarioController();

        private String Numerar(int n)
        {
            Char c = (Char) (65 + n);
            return c.ToString();
        }

        private int QuantBlocos (Bloco bloco)
        {
            var listaBlocos = Consultar();
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
            bloco.Numero = bloco.Secao.Numero.ToString() + Numerar(quantBlocos);

            bloco.Secao = null;

            var erros = Validacao.ValidaDados(bloco);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Bloco.Add(bloco);
                    db.SaveChanges();
                    for (int i = 1; i <= 16; i++)
                    {
                        string num = bloco.Numero + (char)i;
                        Armario armario = new Armario();
                        armario.IdBloco = bloco.IdBloco;
                        armario.Numero = bloco.Numero + i;
                        armario.TemContrato = false;
                        armario.Danificado = false;
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

        public string Deletar(Bloco bloco)
        {
            string resultado;

            try
            {
                resultado = ac.Deletar(bloco);
                if (resultado == "erroBanco")
                    throw new Exception("Erro ao excluir uma entidade Armário");
                bloco.Armario = null;
                Alterar(bloco);
                db.Bloco.Attach(bloco);
                db.Bloco.Remove(bloco);
                db.SaveChanges();
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }

        public Secao Deletar(Secao secao)
        {
            List<Bloco> lista = ListarBlocos(secao);
            foreach (Bloco b in lista)
            {
                try
                {
                    Deletar(b);
                    secao.Bloco.Remove(b);
                }
                catch (Exception)
                {
                    throw new Exception("Erro ao deletar bloco " + b.Numero);
                }
            }
            return secao;
        }

        public List<Bloco> ListarBlocos(Secao secao)
        {
            List<Bloco> lista = (from b in db.Bloco
                                 where b.IdSecao == secao.IdSecao
                                 select b).ToList();
            return lista;
        }

        public string Alterar(Bloco bloco)
        {
            var erros = Validacao.ValidaDados(bloco);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    Bloco blocoDb = (from b in db.Bloco
                                     where b.IdBloco == bloco.IdBloco
                                     select b).SingleOrDefault();
                    blocoDb = bloco;
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
