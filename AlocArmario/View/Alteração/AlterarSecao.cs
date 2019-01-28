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

namespace AlocArmario.View.Alteração
{
    public partial class AlterarSecao : Form
    {
        private Secao secao;
        private SecaoController sc;
        private List<Secao> listaSecoes = new List<Secao>();

        public AlterarSecao(Secao secaoAlt)
        {
            InitializeComponent();

            secao = secaoAlt;
            sc = new SecaoController();

            listaSecoes = sc.Consultar();
            txbNum.Text = Convert.ToString(listaSecoes.Count + 1);

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Secao));
            TypeDescriptor.AddProvider(provedor, typeof(Secao));

            txbNum.Text = Convert.ToString(secao.Numero);
            txbNome.Text = secao.Nome;
            txbDescricao.Text = secao.Descricao;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            secao.Nome = txbNome.Text;
            secao.Descricao = txbDescricao.Text;

            string resultado = sc.Alterar(secao);
            if (resultado.Equals("ok"))
            {
                MessageBox.Show(("Seção " + txbNum.Text + " alterada com sucesso."), "Alterar Seção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Close();
            }
            else if (resultado.Equals("erro"))
            {
                MessageBox.Show("Não foi possível alterar a seção.", "Alterar Seção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(("Erro de validação: \n" + resultado), "Alterar Seção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
