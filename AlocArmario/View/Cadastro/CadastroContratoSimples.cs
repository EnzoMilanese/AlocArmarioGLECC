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

namespace AlocArmario.View.Cadastro
{
    public partial class CadastroContratoSimples : Form
    {
        private Dictionary<string, decimal> fonteTipos = new Dictionary<string, decimal>() {
                                                          { "Semestral", Controller.VarGlobal.ValorSemestral },
                                                          { "Anual", Controller.VarGlobal.ValorAnual } };
        private DateTime diaAtual;
        private List<Locatario> listaLocatarios = new List<Locatario>();
        private Locatario ultimoLoc;
        private DateTime dataValidade;

        private ArmarioController ac;
        private LocatarioController lc;
        private ContratoController cc;

        private Armario armario = new Armario();
        private Contrato contrato = new Contrato();

        public CadastroContratoSimples()
        {
            InitializeComponent();
        }

        public CadastroContratoSimples(Armario armario)
        {
            InitializeComponent();

            this.armario = armario;

            ac = new ArmarioController();
            lc = new LocatarioController();
            cc = new ContratoController();

            diaAtual = DateTime.Now;

            lblDataArm.Text = armario.Numero;
            lblDataBloc.Text = armario.Bloco.Numero;
            lblDataSec.Text = Convert.ToString(armario.Bloco.Secao.Numero);

            cbxTipoContrato.DataSource = fonteTipos.ToList();
            cbxTipoContrato.DisplayMember = "Key";
            cbxTipoContrato.ValueMember = "Value";
            cbxTipoContrato.SelectedValue = VarGlobal.ValorAnual;

            CarregarComboLocs();
            CarregarLabelTipos();
        }

        private void CarregarLabelTipos()
        {
            lblDataValor.Text = ("R$" + cbxTipoContrato.SelectedValue.ToString()).Replace('.', ',');
        }

        private void CarregarComboLocs()
        {
            listaLocatarios = lc.ConsultarSemContrato();
            if (listaLocatarios.Count <= 0)
                btnCadastrar.Enabled = false;
            else
            {
                btnCadastrar.Enabled = true;
                ultimoLoc = listaLocatarios.LastOrDefault();
                listaLocatarios = listaLocatarios.OrderBy(l => l.Nome).ToList();
                cbxLocatario.DataSource = listaLocatarios;
                cbxLocatario.DisplayMember = "Nome";
                cbxLocatario.ValueMember = "IdLocatario";
                cbxLocatario.SelectedItem = ultimoLoc;
            }
        }

        private void CarregarValidade()
        {
            switch (cbxTipoContrato.SelectedValue)
            {
                case VarGlobal.ValorAnual:
                    dataValidade = new DateTime(diaAtual.Year, 12, 31);
                    lblDataValidade.Text = dataValidade.ToString("dd/MM/yyyy");
                    break;

                case VarGlobal.ValorSemestral:
                    if (diaAtual.Month <= 6)
                        dataValidade = new DateTime(diaAtual.Year, 6, 30);
                    else
                        dataValidade = new DateTime(diaAtual.Year, 12, 31);

                    lblDataValidade.Text = dataValidade.ToString("dd/MM/yyyy");
                    break;
            }
        }

        private void btnCadastLoc_Click(object sender, EventArgs e)
        {
            CadastroLocatario cl = new CadastroLocatario();
            cl.ShowDialog();
            CarregarComboLocs();
        }

        private void cbxTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarLabelTipos();
            CarregarValidade();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            contrato.Valor = (decimal)cbxTipoContrato.SelectedValue;
            contrato.TipoContrato = cbxTipoContrato.Text;
            contrato.Validade = dataValidade;
            contrato.DataInicio = diaAtual;
            contrato.IdLocatario = (int)cbxLocatario.SelectedValue;
            contrato.IdArmario = armario.IdArmario;

            string resultado = cc.Inserir(contrato);
            if (resultado.Equals("ok"))
            {
                ActiveForm.Close();
            }
            else if (resultado.Equals("erro"))
            {
                MessageBox.Show("Não foi possível cadastrar o contrato.", "Novo Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(("Erro de validação: \n" + resultado), "Novo Contrato", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
