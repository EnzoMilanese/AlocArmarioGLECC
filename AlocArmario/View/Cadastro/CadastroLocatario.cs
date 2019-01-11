using AlocArmario.Controller;
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

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Locatario));
            TypeDescriptor.AddProvider(provedor, typeof(Locatario));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            locatario.Nome = txbNome.Text;
            locatario.Prontuario = txbPront.Text;
            locatario.Email = txbEmail.Text;
            locatario.Telefone = mktTel.Text;

            string resultado = lc.Inserir(locatario);
            if (resultado.Equals("ok"))
            {
                MessageBox.Show(("Locatário " + txbNome.Text + " cadastrado com sucesso."), "Novo Locatário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Close();
            }
            else if (resultado.Equals("erro"))
            {
                MessageBox.Show("Não foi possível cadastrar o locatário.", "Novo Locatário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(("Erro de validação: \n" + resultado), "Novo Locatário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
