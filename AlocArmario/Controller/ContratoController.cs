using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class ContratoController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        public List<Contrato> Consultar()
        {
            var lista = db.Contrato.ToList();
            return lista;
        }

        internal string Inserir(Contrato contrato)
        {
            throw new NotImplementedException();
        }
    }
}
