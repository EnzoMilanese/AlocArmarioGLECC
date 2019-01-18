using AlocArmario.Controller;
using AlocArmario.View.Cadastro;
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
        
        private void ConsultaArmarioAvanc_Activated(object sender, EventArgs e)
        {
            this.ConsultarContratos();
            this.ConsultarLocatarios();
            this.ConsultarArmarios();
            this.ConsultarBlocos();
            this.ConsultarSecoes();

            this.CarregarScrollBars(dgvContratos, vsbDgvContr);
            this.CarregarScrollBars(dgvLocatarios, vsbDgvLoc);
            this.CarregarScrollBars(dgvArmarios, vsbDgvArm);
            this.CarregarScrollBars(dgvBlocos, vsbDgvBloc);
            this.CarregarScrollBars(dgvSecoes, vsbDgvSec);
        }

        private void CarregarScrollBars(DataGridView dgv, VScrollBar vsb)
        {
            DataGridViewColumn coluna = dgv.Columns[dgv.ColumnCount - 1];

            if (dgv.RowCount <= 16 && dgv.Width == 565)
            {
                vsb.Visible = false;
                dgv.Width += 15;
                coluna.Width += 15;
            }
            else
            {
                vsb.Visible = true;
                dgv.Width += -15;
                coluna.Width += -15;
            }

            vsb.Maximum = dgv.RowCount - 6;
        }

        private void vsbDgvContr_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < dgvContratos.Rows.Count + 2)
                dgvContratos.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void vsbDgvLoc_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < dgvLocatarios.Rows.Count + 2)
                dgvLocatarios.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void vsbDgvArm_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < dgvArmarios.Rows.Count + 2)
                dgvArmarios.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void vsbDgvBloc_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < dgvBlocos.Rows.Count + 2)
                dgvBlocos.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void vsbDgvSec_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.NewValue > -1 && e.NewValue < dgvSecoes.Rows.Count + 2)
                dgvSecoes.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void ConsultarContratos()
        {
            dgvContratos.Rows.Clear();

            cc = new ContratoController();
            var contratos = cc.Consultar();

            int linha = 0;
            foreach (var c in contratos)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells[0].Value = c.IdContrato;
                dgvContratos.Rows[linha].Cells[1].Value = c.Validade;
                dgvContratos.Rows[linha].Cells[2].Value = c.Valor;
                dgvContratos.Rows[linha].Cells[3].Value = c.Armario.Numero;
                dgvContratos.Rows[linha].Cells[4].Value = c.Locatario.Nome;
                linha++;
            }
        }

        private void ConsultarLocatarios()
        {
            dgvLocatarios.Rows.Clear();

            lc = new LocatarioController();
            var locatarios = lc.Consultar();

            int linha = 0;
            foreach (var l in locatarios)
            {
                dgvLocatarios.Rows.Add();
                dgvLocatarios.Rows[linha].Cells[0].Value = l.IdLocatario;
                dgvLocatarios.Rows[linha].Cells[1].Value = l.Nome;
                dgvLocatarios.Rows[linha].Cells[2].Value = l.Prontuario;
                dgvLocatarios.Rows[linha].Cells[3].Value = l.Email;
                dgvLocatarios.Rows[linha].Cells[4].Value = l.Telefone;
                linha++;
            }
        }

        private void ConsultarArmarios()
        {
            dgvArmarios.Rows.Clear();

            ac = new ArmarioController();
            var armarios = ac.Consultar();

            int linha = 0;
            foreach (var a in armarios)
            {
                dgvArmarios.Rows.Add();
                dgvArmarios.Rows[linha].Cells[0].Value = a.IdArmario;
                dgvArmarios.Rows[linha].Cells[1].Value = a.Numero;
                dgvArmarios.Rows[linha].Cells[2].Value = a.Bloco.Numero;
                dgvArmarios.Rows[linha].Cells[3].Value = a.Bloco.Secao.Nome;
                dgvArmarios.Rows[linha].Cells[4].Value = a.TemContrato;
                linha++;
            }
        }

        private void ConsultarBlocos()
        {
            dgvBlocos.Rows.Clear();

            bc = new BlocoController();
            var blocos = bc.Consultar();

            int linha = 0;
            foreach (var b in blocos)
            {
                dgvBlocos.Rows.Add();
                dgvBlocos.Rows[linha].Cells[0].Value = b.IdBloco;
                dgvBlocos.Rows[linha].Cells[1].Value = b.Numero;
                dgvBlocos.Rows[linha].Cells[2].Value = b.Secao.Nome;
                linha++;
            }
        }

        private void ConsultarSecoes()
        {
            dgvSecoes.Rows.Clear();

            sc = new SecaoController();
            var secoes = sc.Consultar();

            int linha = 0;
            foreach (var s in secoes)
            {
                dgvSecoes.Rows.Add();
                dgvSecoes.Rows[linha].Cells[0].Value = s.IdSecao;
                dgvSecoes.Rows[linha].Cells[1].Value = s.Nome;
                dgvSecoes.Rows[linha].Cells[2].Value = s.Descricao;
                linha++;
            }
        }

        private void btnCadastContrato_Click(object sender, EventArgs e)
        {
            CadastroContrato cc = new CadastroContrato();
            cc.ShowDialog();
        }

        private void btnCadastLocatario_Click(object sender, EventArgs e)
        {
            CadastroLocatario cl = new CadastroLocatario();
            cl.ShowDialog();
        }

        private void btnCadastBloco_Click(object sender, EventArgs e)
        {
            CadastroBloco cb = new CadastroBloco();
            cb.ShowDialog();
        }

        private void btnCadastSecao_Click(object sender, EventArgs e)
        {
            CadastroSecao cs = new CadastroSecao();
            cs.ShowDialog();
        }
    }
}
