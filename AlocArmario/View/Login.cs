using AlocArmario.View;
using AlocArmario.Model;
using AlocArmario.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlocArmario.View.ArmarioView;
using System.ComponentModel.DataAnnotations;

namespace AlocArmario
{
    public partial class Login : Form
    {
        public bool interfaceSimples { get; set; }
        private Usuario usuario;
        private LoginController lc;

        public Login()
        {
            InitializeComponent();
            rdbSimples.Checked = true;
            lc = new LoginController();
            usuario = new Usuario();

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Usuario));
            TypeDescriptor.AddProvider(provedor, typeof(Usuario));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            usuario.Prontuario = txbPront.Text;
            usuario.Senha = txbSenha.Text;

            string resultado = lc.ValidarLogin(usuario);

            if (resultado.Equals("ok"))
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (resultado.Equals("erro"))
            {
                MessageBox.Show("Erro \n\nProntuário e/ou senha incorretos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (resultado.Equals(""))
            {
                MessageBox.Show(("Erro desconhecido \n" + resultado), "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(("Erro de validação" + resultado), "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                   
        }

        private void rdbSimples_CheckedChanged(object sender, EventArgs e)
        {
            lblDescInterf.Text = "Interface simples para cadastro \n" +
                                 "de locatários e pesquisa intuitiva \n" +
                                 "de contratos.";
            interfaceSimples = true;
        }

        private void rdbAvancado_CheckedChanged(object sender, EventArgs e)
        {
            lblDescInterf.Text = "Interface completa com cadastro, \n" +
                                 "alteração, exclusão e pesquisa \n" +
                                 "de locatários e contratos.";
            interfaceSimples = false;
        }
    }
}
