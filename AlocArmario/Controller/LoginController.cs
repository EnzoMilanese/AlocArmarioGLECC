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

        public 
    }
}
