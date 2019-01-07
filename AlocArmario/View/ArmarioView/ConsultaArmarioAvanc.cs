using AlocArmario.Controller;
using AlocArmario.View.LocatarioView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlocArmario.View
{
    public partial class ConsultaArmarioAvanc : Form
    {
        private ContratoController cc;
        private LocatarioController lc;
        private ArmarioController ac;
        private BlocoController bc;
        private SecaoController sc;

        public ConsultaArmarioAvanc()
        {
            InitializeComponent();
        }

        private void btnCadastrarLoc_Click(object sender, EventArgs e)
        {
            CadastroLocatario cadastroLocatario = new CadastroLocatario();
            cadastroLocatario.ShowDialog(this);
        }

        private void ConsultaArmarioAvanc_Activated(object sender, EventArgs e)
        {
            this.ConsultarContratos();
            this.ConsultarLocatarios();
            this.ConsultarArmarios();
            this.ConsultarBlocos();
            this.ConsultarSecoes();
        }

        private void ConsultarContratos()
        {
            dgvContratos.Rows.Clear();

            cc = new ContratoController();
            var contratos = new cc.Consultar();

            int linha = 0;
            foreach (var c in contratos)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells["ID"].Value = c.Id;
                dgvContratos.Rows[linha].Cells["Validade"].Value = c.Validade;
                dgvContratos.Rows[linha].Cells["Valor"].Value = c.Valor;
                dgvContratos.Rows[linha].Cells["Armário"].Value = c.IdArmario;
                dgvContratos.Rows[linha].Cells["Locatário"].Value = c.IdLocatario;
                linha++;
            }
        }

        private void ConsultarLocatarios()
        {
            dgvLocatarios.Rows.Clear();

            lc = new LocatarioController();
            var locatarios = new lc.Consultar();

            int linha = 0;
            foreach (var l in locatarios)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells["ID"].Value = l.IdLocatario;
                dgvContratos.Rows[linha].Cells["Nome"].Value = l.Nome;
                dgvContratos.Rows[linha].Cells["Prontuário"].Value = l.Prontuario;
                dgvContratos.Rows[linha].Cells["Email"].Value = l.Email;
                dgvContratos.Rows[linha].Cells["Telefone"].Value = l.Telefone;
                linha++;
            }
        }

        private void ConsultarArmarios()
        {
            dgvArmarios.Rows.Clear();

            ac = new ArmarioController();
            var armarios = new ac.Consultar();

            int linha = 0;
            foreach (var a in armarios)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells["ID"].Value = a.IdArmario;
                dgvContratos.Rows[linha].Cells["Bloco"].Value = a.IdBloco;
                dgvContratos.Rows[linha].Cells["Número"].Value = a.Numero;
                linha++;
            }
        }

        private void ConsultarBlocos()
        {
            dgvBlocos.Rows.Clear();

            bc = new BlocoController();
            var blocos = new bc.Consultar();

            int linha = 0;
            foreach (var b in blocos)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells["ID"].Value = b.IdBloco;
                dgvContratos.Rows[linha].Cells["Nome"].Value = b.Nome;
                dgvContratos.Rows[linha].Cells["Seção"].Value = b.IdSecao;
                linha++;
            }
        }

        private void ConsultarSecoes()
        {
            dgvSecoes.Rows.Clear();

            sc = new SecaoController();
            var secoes = new sc.Consultar();

            int linha = 0;
            foreach (var s in secoes)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells["ID"].Value = s.IdSecao;
                dgvContratos.Rows[linha].Cells["Nome"].Value = s.Nome;
                linha++;
            }
        }
    }
}
