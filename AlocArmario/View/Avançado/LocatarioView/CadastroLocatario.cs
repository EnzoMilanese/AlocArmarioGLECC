using AlocArmario.Controller;
using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocArmario.View.LocatarioView
{
    public partial class CadastroLocatario : Form
    {
        private LocatarioController lc;
        private Locatario locatario;

        public CadastroLocatario()
        {
            InitializeComponent();
            lc = new LocatarioController();
            locatario = new Locatario();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
