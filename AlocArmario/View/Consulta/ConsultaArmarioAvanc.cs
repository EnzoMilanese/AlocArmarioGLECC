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
                dgvContratos.Rows[linha].Cells["ID"].Value = c.IdContrato;
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
            var locatarios = lc.Consultar();

            int linha = 0;
            foreach (var l in locatarios)
            {
                dgvLocatarios.Rows.Add();
                dgvLocatarios.Rows[linha].Cells["ID"].Value = l.IdLocatario;
                dgvLocatarios.Rows[linha].Cells["Nome"].Value = l.Nome;
                dgvLocatarios.Rows[linha].Cells["Prontuário"].Value = l.Prontuario;
                dgvLocatarios.Rows[linha].Cells["Email"].Value = l.Email;
                dgvLocatarios.Rows[linha].Cells["Telefone"].Value = l.Telefone;
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
                dgvArmarios.Rows[linha].Cells["ID"].Value = a.IdArmario;
                dgvArmarios.Rows[linha].Cells["Bloco"].Value = a.IdBloco;
                dgvArmarios.Rows[linha].Cells["Número"].Value = a.Numero;
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
                dgvBlocos.Rows[linha].Cells["ID"].Value = b.IdBloco;
                dgvBlocos.Rows[linha].Cells["Nome"].Value = b.Nome;
                dgvBlocos.Rows[linha].Cells["Seção"].Value = b.IdSecao;
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

        private void dgvContratos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultaArmarioAvanc_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastSecao_Click(object sender, EventArgs e)
        {
            CadastroSecao cs = new CadastroSecao();
            cs.ShowDialog();
        }
    }
}
