using AlocArmario.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new Login());
        }
    }
}

/*
            using (Login login = new Login())
            {
                var result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Visible = true;
                }
            }
*/