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

namespace AlocArmario.View.Cadastro
{
    public partial class CadastroBloco : Form
    {
        BlocoController bc;
        SecaoController sc;
        Bloco bloco;
        List<Secao> listaSecoes;

        public CadastroBloco()
        {
            InitializeComponent();

            bc = new BlocoController();
            sc = new SecaoController();
            bloco = new Bloco();

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Bloco));
            TypeDescriptor.AddProvider(provedor, typeof(Bloco));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            foreach (var s in listaSecoes)
                if (s.Nome.Equals(cbxSecao.SelectedItem.ToString()))
                {
                    bloco.IdSecao = s.IdSecao;
                    bloco.Secao = s;
                }

            string resultado = bc.Inserir(bloco);
            if (resultado.Equals("ok"))
            {
                MessageBox.Show(("Bloco cadastrado com sucesso."), "Novo Bloco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActiveForm.Close();
            }
            else if (resultado.Equals("erro"))
            {
                MessageBox.Show("Não foi possível cadastrar o bloco.", "Novo Bloco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(("Erro de validação: \n" + resultado), "Novo Bloco", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CadastroBloco_Load(object sender, EventArgs e)
        {
            listaSecoes = sc.Consultar();
            foreach (var s in listaSecoes)            
                cbxSecao.Items.Add(s.Nome);

            if (cbxSecao.Items.Count > 0)
                cbxSecao.SelectedIndex = 0;
        }

        private void cbxSecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var s in listaSecoes)
                if (s.Nome == cbxSecao.SelectedItem.ToString())
                    lblDataDescricao.Text = s.Descricao;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
