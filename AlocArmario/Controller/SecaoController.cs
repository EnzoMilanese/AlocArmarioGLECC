using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class SecaoController
        {
        private ModeloDadosContainer db = new ModeloDadosContainer();

        public List<Secao> Consultar()
        {
            var lista = db.Secao.ToList();
            return lista;
        }
    }
}
