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
    public partial class CadastroBloco : Form
    {
        public CadastroBloco()
        {
            InitializeComponent();
            
            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Bloco));
            TypeDescriptor.AddProvider(provedor, typeof(Bloco));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
