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
            var lista = db.Armario.ToList();
            return lista;
        }

        internal void Inserir(Armario armario)
        {
            throw new NotImplementedException();
        }
    }
}