using AlocArmario.Model;
using AlocArmario.Controller;
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
        private Secao secao;
        private SecaoController sc;
        private List<Secao> listaSecoes = new List<Secao>();

        public CadastroSecao()
        {
            InitializeComponent();

            secao = new Secao();
            sc = new SecaoController();

            listaSecoes = sc.Consultar();
            txbId.Text = Convert.ToString(listaSecoes.Count + 1);

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Secao));
            TypeDescriptor.AddProvider(provedor, typeof(Secao));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int numSecao;
            if (!int.TryParse(txbId.Text, out numSecao))
            {
                MessageBox.Show(("O ID deve ser um número"), "Nova Seção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            secao.Numero = numSecao;
            secao.Nome = txbNome.Text;
            secao.Descricao = txbDescricao.Text;
            
            foreach (Secao s in listaSecoes)
                if(s.Numero == secao.Numero)
                {
                    MessageBox.Show(("Já existe uma seção com o número indicado."), "Nova Seção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            string resultado = sc.Inserir(secao);
            if (resultado.Equals("ok"))
            {
                MessageBox.Show(("Seção " + txbNome.Text + " cadastrada com sucesso."), "Nova Seção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Close();
            }
            else if (resultado.Equals("erro"))
            {
                MessageBox.Show("Não foi possível cadastrar a seção.", "Nova Seção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(("Erro de validação: \n" + resultado), "Nova Seção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
