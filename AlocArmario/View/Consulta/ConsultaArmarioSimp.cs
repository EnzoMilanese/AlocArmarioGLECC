using AlocArmario.Controller;
using AlocArmario.Model;
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

namespace AlocArmario.View.ArmarioView
{
    public partial class ConsultaArmarioSimp : Form
    {
        private ContratoController cc;
        private LocatarioController lc;
        private ArmarioController ac;
        private BlocoController bc;
        private SecaoController sc;

        private Contrato contratoAtivo = new Contrato();
        private Locatario locatarioAtivo = new Locatario();
        private Armario armarioAtivo = new Armario();
        private Bloco blocoAtivo = new Bloco();
        private Secao secaoAtiva = new Secao();

        private List<Contrato> listaContratos = new List<Contrato>();
        private List<Locatario> listaLocatarios = new List<Locatario>();
        private List<Armario> listaArmarios = new List<Armario>();
        private List<Bloco> listaBlocos = new List<Bloco>();
        private List<Secao> listaSecoes = new List<Secao>();

        private List<Armario> listaArmsAtivos = new List<Armario>();
        private List<Button> listaBtnArmarios = new List<Button>(); 

        public ConsultaArmarioSimp()
        {
            InitializeComponent();

            cc = new ContratoController();
            lc = new LocatarioController();
            ac = new ArmarioController();
            bc = new BlocoController();
            sc = new SecaoController();

            contratoAtivo = new Contrato();
            locatarioAtivo = new Locatario();
            armarioAtivo = new Armario();
            blocoAtivo = new Bloco();
            secaoAtiva = new Secao();

            listaBtnArmarios = new List<Button>{ btnArm1, btnArm2, btnArm3, btnArm4,
                                                 btnArm5, btnArm6, btnArm7, btnArm8,
                                                 btnArm9, btnArm10, btnArm11, btnArm12,
                                                 btnArm13, btnArm14, btnArm15, btnArm16, };

            CarregarListas();

            cbxSecao.DataSource = listaSecoes;
            cbxSecao.DisplayMember = "Nome";
            cbxSecao.ValueMember = "IdSecao";
            
            CarregarSecao();
            CarregarCombos();

            cbxBloco.DisplayMember = "Numero";
            cbxBloco.ValueMember = "IdBloco";

            CarregarBloco();
        }

        private void CarregarListas()
        {
            listaContratos = cc.Consultar();
            listaLocatarios = lc.Consultar();
            listaArmarios = ac.Consultar();
            listaBlocos = bc.Consultar();
            listaSecoes = sc.Consultar();
        }

        private void CarregarSecao()
        {
            secaoAtiva = listaSecoes.Where(b => b.IdSecao == (int)cbxSecao.SelectedValue).SingleOrDefault();
        }

        private void CarregarCombos()
        {
            if (secaoAtiva.Bloco.Count <= 0)
            {
                cbxBloco.Enabled = false;
                paneSemArm.Visible = true;
                return;
            }

            paneSemArm.Visible = false;
            cbxBloco.Enabled = true;

            cbxBloco.DataSource = listaBlocos.Where(b => b.IdSecao == (int)cbxSecao.SelectedValue).ToList();
        }

        private void CarregarBloco()
        {
            blocoAtivo = listaBlocos.Where(b => b.IdBloco == (int)cbxBloco.SelectedValue).SingleOrDefault();

            CarregarArmarios();
        }

        private void CarregarArmarios()
        {
            listaArmsAtivos = listaArmarios.Where(a => a.IdBloco == blocoAtivo.IdBloco).ToList();
            CarregarBtnArmarios();
        }

        private void CarregarBtnArmarios()
        {
            for (int i = 0; i < 16; i++)
            {
                listaBtnArmarios[i].Text = listaArmsAtivos[i].Numero;
                if (listaArmsAtivos[i].Danificado)
                    listaBtnArmarios[i].ForeColor = Color.DarkRed;
                else if (listaArmsAtivos[i].TemContrato)
                    listaBtnArmarios[i].ForeColor = Color.DarkBlue;
                else
                    listaBtnArmarios[i].ForeColor = Color.DarkGreen;
            }
        }

        private void CarregarLabels(string numArm)
        {
            armarioAtivo = listaArmarios.Where(a => a.Numero == numArm).SingleOrDefault();

            lblArmIdent.Text = armarioAtivo.Numero;
            lblArmNum.Text = armarioAtivo.Numero;
            lblArmBloc.Text = armarioAtivo.Bloco.Numero;
            lblArmSec.Text = armarioAtivo.Bloco.Secao.Nome;

            if (armarioAtivo.Danificado)
            {
                lblStatus.Text = "Danificado";
                lblStatus.ForeColor = Color.DarkRed;

                lblLocNome.Text = "...";
                lblLocPront.Text = "...";
                lblLocTel.Text = "...";
                lblLocEmail.Text = "...";

                lblContArm.Text = "...";
                lblContLoc.Text = "...";
                lblContTipo.Text = "...";
                lblContValid.Text = "...";
                lblContValor.Text = "...";

                btnTerminar.Visible = false;
                btnAlugar.Visible = true;
                btnAlugar.Enabled = false;
                btnGerarCertfic.Visible = false;
                btnInutil.Visible = false;
                btnUtil.Visible = true;

                return;
            }

            if (armarioAtivo.TemContrato)
            {
                lblStatus.Text = "Alugado";
                lblStatus.ForeColor = Color.DarkBlue;

                contratoAtivo = listaContratos.Where(c => c.IdArmario == armarioAtivo.IdArmario).SingleOrDefault();
                locatarioAtivo = listaLocatarios.Where(l => l.ContratoAtivo == contratoAtivo.IdContrato).SingleOrDefault();

                lblLocNome.Text = locatarioAtivo.Nome;
                lblLocPront.Text = locatarioAtivo.Prontuario;
                lblLocTel.Text = locatarioAtivo.Telefone;
                lblLocEmail.Text = locatarioAtivo.Email;

                lblContArm.Text = armarioAtivo.Numero;
                lblContLoc.Text = locatarioAtivo.Nome;
                lblContTipo.Text = contratoAtivo.TipoContrato;
                lblContValid.Text = contratoAtivo.Validade.ToString("dd/MM/yyyy");
                lblContValor.Text = contratoAtivo.Valor;

                btnTerminar.Visible = true;
                btnAlugar.Visible = false;
                btnGerarCertfic.Visible = true;
                btnInutil.Visible = false;
                btnUtil.Visible = false;
            }
            else
            {
                lblStatus.Text = "Vago";
                lblStatus.ForeColor = Color.DarkGreen;

                lblLocNome.Text = "...";
                lblLocPront.Text = "...";
                lblLocTel.Text = "...";
                lblLocEmail.Text = "...";

                lblContArm.Text = "...";
                lblContLoc.Text = "...";
                lblContTipo.Text = "...";
                lblContValid.Text = "...";
                lblContValor.Text = "...";

                btnTerminar.Visible = false;
                btnAlugar.Visible = true;
                btnAlugar.Enabled = true;
                btnGerarCertfic.Visible = false;
                btnInutil.Visible = true;
                btnUtil.Visible = false;
            }
        }

        private void botãoArmario(object sender, EventArgs e)
        {
            Button botão = (Button)sender;
            CarregarLabels(botão.Text);
        }

        private void cbxSecao_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarSecao();
            CarregarCombos();
        }

        private void cbxBloco_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarBloco();
        }

        private void btnCadastLoc_Click(object sender, EventArgs e)
        {
            CadastroLocatario cl = new CadastroLocatario();
            cl.ShowDialog();
        }

        private void btnInutil_Click(object sender, EventArgs e)
        {
            ac.Danificado(armarioAtivo);
            CarregarListas();
            CarregarArmarios();
            CarregarLabels(armarioAtivo.Numero);
        }

        private void btnUtil_Click(object sender, EventArgs e)
        {
            ac.Utilizavel(armarioAtivo);
            CarregarListas();
            CarregarArmarios();
            CarregarLabels(armarioAtivo.Numero);
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {

        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGerarCertfic_Click(object sender, EventArgs e)
        {

        }
    }
}
