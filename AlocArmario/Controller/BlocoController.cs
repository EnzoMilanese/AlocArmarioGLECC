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

        public List<Bloco> Consultar()
        {
            var lista = db.Bloco.ToList();
            return lista;
        }
    }
}
