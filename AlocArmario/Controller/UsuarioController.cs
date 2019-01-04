using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlocArmario.Model;

namespace AlocArmario.Controller
{
    class UsuarioController
    {
        private ModeloDadosContainer db = new ModeloDadosContainer();
        
        public List<Usuario> consultar()
        {
            var lista = db.Usuario.ToList();
            return lista;
        }
    }
}
