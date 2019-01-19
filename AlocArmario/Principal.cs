using AlocArmario.View;
using AlocArmario.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlocArmario.View.ArmarioView;

namespace AlocArmario
{
    static class Principal
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginController lc = new LoginController();
            int estadoLogin = lc.abrirLogin();
            switch (estadoLogin)
            {
                case 1:
                    ConsultaArmarioSimp indexSimp = new ConsultaArmarioSimp();
                    Application.Run(indexSimp);
                    break;

                case 2:
                    ConsultaArmarioAvanc indexAvanc = new ConsultaArmarioAvanc();
                    Application.Run(indexAvanc);
                    break;

                case 0:
                    Application.Exit();
                    break;

                default:
                    Application.Exit();
                    break;
            }
        }
    }
}