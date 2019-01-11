using AlocArmario.Model;
using AlocArmario.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocArmario.Controller
{
    class LoginController
    {
        ModeloDadosContainer db = new ModeloDadosContainer();

        public int abrirLogin()
        {
            Login login = new Login();
            login.ShowDialog();

            bool interfaceSimp = login.interfaceSimples;

            if (login.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (interfaceSimp)
                {
                    login.Dispose();
                    return 1;
                }
                    
                else
                {
                    login.Dispose();
                    return 2;
                }                    
            }
            else
            {
                login.Dispose();
                return 0;
            }
        }

        public string ValidarLogin (Usuario usuario)
        {
            var erros = Validacao.ValidaDados(usuario);
            string resultado = "";


            if (erros.Count() == 0)
            {
                try
                {
                    var usuarioList = db.Usuario.SqlQuery("SELECT * FROM Usuario WHERE Prontuario = '"+ usuario.Prontuario + "' AND Senha = '" + usuario.Senha +"';").ToList();

                    if (usuarioList.Count() == 1)
                    {
                        resultado = "ok";
                        usuarioList.Clear();
                    }
                    else
                    {
                        resultado = "erro";
                        usuarioList.Clear();
                    }
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
