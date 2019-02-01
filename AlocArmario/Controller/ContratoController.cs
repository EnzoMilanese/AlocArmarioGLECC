using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class ContratoController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();
        private ArmarioController ac = new ArmarioController();
        private LocatarioController lc = new LocatarioController();
        private List<Armario> armarios = new List<Armario>();
        private List<Locatario> locatarios = new List<Locatario>();
        private Armario armario = new Armario();
        private Locatario locatario = new Locatario();

        public List<Contrato> Consultar()
        {
            var lista = db.Contrato.ToList();
            return lista;
        }

        public string Inserir(Contrato contrato)
        {
            armarios = ac.ConsultarSemContrato();
            locatarios = lc.ConsultarSemContrato();

            foreach (var a in armarios)
                if (a.IdArmario == contrato.IdArmario)
                    armario = a;

            foreach (var l in locatarios)
                if (l.IdLocatario == contrato.IdLocatario)
                    locatario = l;

            armario.TemContrato = true;
            locatario.TemContrato = true;

            var erros = Validacao.ValidaDados(contrato);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    db.Contrato.Add(contrato);
                    resultado = ac.Alterar(armario);
                    if (resultado == "erro")
                        return resultado;
                    resultado = lc.Alterar(locatario);
                    if (resultado == "erro")
                        return resultado;
                    db.SaveChanges();
                    db.Entry(contrato).Reload();
                    lc.AtualizarEntrada(locatario);
                    ac.AtualizarEntrada(armario);
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

        public string Terminar(Contrato contrato)
        {
            Armario armarioContrato;
            Locatario locatarioContrato;
            Contrato contratoDb;

            armarios = ac.Consultar();
            locatarios = lc.Consultar();

            armarioContrato = armarios.Where(a => a.IdArmario == contrato.IdArmario).SingleOrDefault();
            locatarioContrato = locatarios.Where(l => l.IdLocatario == contrato.IdLocatario).SingleOrDefault();
            contratoDb = db.Contrato.Where(c => c.IdContrato == contrato.IdContrato).SingleOrDefault();

            string resultado = "";
            try
            {
                armarioContrato.TemContrato = false;
                ac.Alterar(armarioContrato);
                db.SaveChanges();

                locatarioContrato.TemContrato = false;
                lc.Alterar(locatarioContrato);
                db.SaveChanges();

                contrato.Terminado = true;
                Alterar(contratoDb);
                db.SaveChanges();
                resultado = "ok";
            }
            catch (Exception)
            {
                resultado = "erroBanco";
            }
            return resultado;
        }

        public string Alterar(Contrato contrato)
        {
            var erros = Validacao.ValidaDados(contrato);
            string resultado = "";

            if (erros.Count() == 0)
            {
                try
                {
                    var entry = db.Entry(contrato);

                    if (entry.State == EntityState.Detached)
                    {
                        var set = db.Set<Contrato>();
                        Contrato attachedEntity = set.Local.SingleOrDefault(e => e.IdContrato == contrato.IdContrato);

                        if (attachedEntity != null)
                        {
                            var attachedEntry = db.Entry(attachedEntity);
                            attachedEntry.CurrentValues.SetValues(contrato);
                        }
                        else
                        {
                            entry.State = EntityState.Modified;
                        }
                    }
                    db.SaveChanges();
                    db.Entry(contrato).Reload();
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
