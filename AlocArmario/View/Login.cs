using AlocArmario.View;
using AlocArmarioPrototipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocArmario
{
    public partial class Login : Form
    {
        private bool interfaceSimples { get; set; }

        public Login()
        {
            InitializeComponent();
            rdbSimples.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ACESSAR BANCO DE USUÁRIOS PARA AUTENTICAÇÃO
            if (txbPront.Text == "" || txbSenha.Text == "")
                MessageBox.Show("Preencha os campos de autenticação", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txbPront.Text == "admin" && txbSenha.Text == "admin")
            {
                if (interfaceSimples)
                {
                    ConsultaArmarioSimp index = new ConsultaArmarioSimp();
                    index.ShowDialog();
                    this.Close();
                }
                else
                {
                    ConsultaArmarioAvanc index = new ConsultaArmarioAvanc();
                    index.ShowDialog();
                    this.Close();
                }
            }
            else
                MessageBox.Show("O prontuário e/ou senha estão errados.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
