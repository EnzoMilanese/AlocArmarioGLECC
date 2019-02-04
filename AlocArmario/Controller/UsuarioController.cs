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
        
        public List<Usuario> Consultar()
        {
            var lista = db.Usuario.ToList();
            return lista;
        }

        internal string Inserir(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
