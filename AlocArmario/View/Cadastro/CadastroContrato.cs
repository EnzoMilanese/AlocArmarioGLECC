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
    public partial class CadastroContrato : Form
    {
        private ContratoController cc;
        private ArmarioController ac;
        private LocatarioController lc;
        private Contrato contrato;
        List<Armario> listaArmarios = new List<Armario>();
        List<Locatario> listaLocatarios = new List<Locatario>();
        List<Bloco> listaBlocos = new List<Bloco>();
        List<Secao> listaSecoes = new List<Secao>();

        public CadastroContrato()
        {
            InitializeComponent();

            cc = new ContratoController();
            ac = new ArmarioController();
            lc = new LocatarioController();
            contrato = new Contrato();

            CarregarLocatarios();
            CarregarArmarios();
            CarregarTiposContrato();

            var provedor = new AssociatedMetadataTypeTypeDescriptionProvider(typeof(Contrato));
            TypeDescriptor.AddProvider(provedor, typeof(Contrato));
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            contrato.Valor = lblDataValor.Text;
            contrato.TipoContrato = cbxTipoContrato.Text;
            DateTime data;
            if (DateTime.TryParse(lblDataValidade.Text, out data))
                contrato.Validade = DateTime.Parse(lblDataValidade.Text);

            foreach (var l in listaLocatarios)
                if (l.Nome.Equals(cbxLocatario.Text))
                    contrato.IdLocatario = l.IdLocatario;

            foreach (var a in listaArmarios)
                if (a.Numero.Equals(cbxArmario.Text))
                    contrato.IdArmario = a.IdArmario;

            if (contrato.IdArmario == 0 && contrato.IdLocatario == 0)
            {
                MessageBox.Show(("O locatário e o armário indicados não existem"), "Novo Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (contrato.IdArmario == 0)
            {
                MessageBox.Show(("O armário indicado não existe"), "Novo Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (contrato.IdLocatario == 0)
            {
                MessageBox.Show(("O locatário indicado não existe"), "Novo Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string resultado = cc.Inserir(contrato);
            if (resultado.Equals("ok"))
            {
                MessageBox.Show(("Contrato cadastrado com sucesso."), "Novo Contrato", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void CarregarTiposContrato()
        {
            cbxTipoContrato.SelectedIndex = cbxTipoContrato.FindStringExact("Anual");
            //INCOMPLETO
            lblDataValor.Text = "R$" + VarGlobal.ValorAnual;
            DateTime agora = DateTime.Now;
            lblDataValidade.Text = agora.ToString();
        }

        private void CarregarLocatarios()
        {
            listaLocatarios = lc.ConsultarSemContrato();
            foreach (var l in listaLocatarios)
                cbxLocatario.Items.Add(l.Nome);
        }

        private void CarregarArmarios()
        {
            listaArmarios = ac.ConsultarSemContrato();
            foreach (var a in listaArmarios)
            {
                if (listaBlocos.Count == 0)
                    listaBlocos.Add(a.Bloco);
                else if (!listaBlocos.Contains(a.Bloco))
                    listaBlocos.Add(a.Bloco);
            }
            foreach (var b in listaBlocos)
            {
                if (listaSecoes.Count == 0)
                    listaSecoes.Add(b.Secao);
                else if (!listaSecoes.Contains(b.Secao))
                    listaSecoes.Add(b.Secao);
            }

            foreach (var s in listaSecoes)
                cbxSecao.Items.Add(s.Nome);
            foreach (var b in listaBlocos)
                cbxBloco.Items.Add(b.Numero);
            foreach (var a in listaArmarios)
                cbxArmario.Items.Add(a.Numero);
        }

        private void CadastroBloco_Load(object sender, EventArgs e)
        {
            CarregarArmarios();
            CarregarLocatarios();
        }

        private void cbxSecao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbxBloco.Items.Clear();
            cbxArmario.Items.Clear();
            cbxBloco.Text = "";
            cbxArmario.Text = "";
            foreach (var b in listaBlocos)
                if (b.Secao.Nome.Equals(cbxSecao.SelectedItem.ToString()))
                    cbxBloco.Items.Add(b.Numero);
            foreach (var a in listaArmarios)
                if (a.Bloco.Secao.Nome == cbxSecao.SelectedItem.ToString())
                    cbxArmario.Items.Add(a.Numero);
        }

        private void cbxBloco_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var b in listaBlocos)
                if (b.Numero == cbxBloco.SelectedItem.ToString())
                    cbxSecao.Text = b.Secao.Nome;

            cbxArmario.Items.Clear();
            cbxArmario.Text = "";
            foreach (var a in listaArmarios)
                if (a.Bloco.Numero == cbxBloco.SelectedItem.ToString())
                    cbxArmario.Items.Add(a.Numero);
        }

        private void cbxArmario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var a in listaArmarios)
                if (a.Numero == cbxArmario.SelectedItem.ToString())
                {
                    cbxSecao.Text = a.Bloco.Secao.Nome;
                    cbxBloco.Text = a.Bloco.Numero;
                }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxTipoContrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxTipoContrato.Text)
            {
                case "Anual":
                    lblDataValor.Text = "R$" + VarGlobal.ValorAnual;
                    break;
                case "Semestral":
                    lblDataValor.Text = "R$" + VarGlobal.ValorSemestral;
                    break;
            }
        }
    }
}
