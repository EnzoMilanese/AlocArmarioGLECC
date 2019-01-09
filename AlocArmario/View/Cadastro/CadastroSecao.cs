using AlocArmario.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocArmario.View.Cadastro
{
    public partial class CadastroSecao : Form
    {
        public CadastroSecao()
        {
            InitializeComponent();

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Secao));
            TypeDescriptor.AddProvider(provedor, typeof(Secao));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
