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
    public partial class CadastroContrato : Form
    {
        public CadastroContrato()
        {
            InitializeComponent();
            
            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Contrato));
            TypeDescriptor.AddProvider(provedor, typeof(Contrato));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
