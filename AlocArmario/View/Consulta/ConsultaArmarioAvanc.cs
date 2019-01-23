﻿using AlocArmario.Controller;
using AlocArmario.Model;
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
        private List<Contrato> baseContratos = new List<Contrato>();
        private List<Locatario> baseLocatarios = new List<Locatario>();
        private List<Armario> baseArmarios = new List<Armario>();
        private List<Bloco> baseBlocos = new List<Bloco>();
        private List<Secao> baseSecoes = new List<Secao>();
        private List<Contrato> listaContratos = new List<Contrato>();
        private List<Locatario> listaLocatarios = new List<Locatario>();
        private List<Armario> listaArmarios = new List<Armario>();
        private List<Bloco> listaBlocos = new List<Bloco>();
        private List<Secao> listaSecoes = new List<Secao>();
        private List<Contrato> listaContratosFiltrada = new List<Contrato>();
        private List<Locatario> listaLocatariosFiltrada = new List<Locatario>();
        private List<Armario> listaArmariosFiltrada = new List<Armario>();
        private List<Bloco> listaBlocosFiltrada = new List<Bloco>();
        private List<Secao> listaSecoesFiltrada = new List<Secao>();
        private Contrato contratoAtivo = new Contrato();
        private Locatario locatarioAtivo = new Locatario();
        private Armario armarioAtivo = new Armario();
        private Bloco blocoAtivo = new Bloco();
        private Secao secaoAtiva = new Secao();


        public ConsultaArmarioAvanc()
        {
            InitializeComponent();

            contratoAtivo = new Contrato();
            locatarioAtivo = new Locatario();
            armarioAtivo = new Armario();
            blocoAtivo = new Bloco();
            secaoAtiva = new Secao();

            cc = new ContratoController();
            lc = new LocatarioController();
            ac = new ArmarioController();
            bc = new BlocoController();
            sc = new SecaoController();

            listaContratos = cc.Consultar();
            listaLocatarios = lc.Consultar();
            listaArmarios = ac.Consultar();
            listaBlocos = bc.Consultar();
            listaSecoes = sc.Consultar();

            baseContratos = cc.Consultar();
            baseLocatarios = lc.Consultar();
            baseArmarios = ac.Consultar();
            baseBlocos = bc.Consultar();
            baseSecoes = sc.Consultar();

        }

        private void ConsultaArmarioAvanc_Activated(object sender, EventArgs e)
        {
            baseContratos = cc.Consultar();
            baseLocatarios = lc.Consultar();
            baseArmarios = ac.Consultar();
            baseBlocos = bc.Consultar();
            baseSecoes = sc.Consultar();

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

        private void ConsultarContratos()
        {
            dgvContratos.Rows.Clear();
            int linha = 0;
            foreach (var c in listaContratos)
            {
                dgvContratos.Rows.Add();
                dgvContratos.Rows[linha].Cells[0].Value = c.IdContrato;
                dgvContratos.Rows[linha].Cells[1].Value = c.Validade;
                dgvContratos.Rows[linha].Cells[2].Value = c.Valor;
                dgvContratos.Rows[linha].Cells[3].Value = c.TipoContrato;
                dgvContratos.Rows[linha].Cells[4].Value = c.Armario.Numero;
                dgvContratos.Rows[linha].Cells[5].Value = c.Locatario.Nome;
                linha++;
            }
        }

        private void ConsultarLocatarios()
        {
            dgvLocatarios.Rows.Clear();
            int linha = 0;
            foreach (var l in listaLocatarios)
            {
                dgvLocatarios.Rows.Add();
                dgvLocatarios.Rows[linha].Cells[0].Value = l.IdLocatario;
                dgvLocatarios.Rows[linha].Cells[1].Value = l.Nome;
                dgvLocatarios.Rows[linha].Cells[2].Value = l.Prontuario;
                dgvLocatarios.Rows[linha].Cells[3].Value = l.Email;
                dgvLocatarios.Rows[linha].Cells[4].Value = l.Telefone;
                dgvLocatarios.Rows[linha].Cells[5].Value = l.TemContrato;
                linha++;
            }
        }

        private void ConsultarArmarios()
        {
            dgvArmarios.Rows.Clear();
            int linha = 0;
            foreach (var a in listaArmarios)
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
            int linha = 0;
            foreach (var b in listaBlocos)
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
            int linha = 0;
            foreach (var s in listaSecoes)
            {
                dgvSecoes.Rows.Add();
                dgvSecoes.Rows[linha].Cells[0].Value = s.IdSecao;
                dgvSecoes.Rows[linha].Cells[1].Value = s.Nome;
                dgvSecoes.Rows[linha].Cells[2].Value = s.Descricao;
                linha++;
            }
        }

        private void CarregarScrollBars(DataGridView dgv, VScrollBar vsb)
        {
            DataGridViewColumn coluna = dgv.Columns[dgv.ColumnCount - 1];

            vsb.Value = vsb.Minimum;

            if (dgv.Width == 565)
            {
                if (dgv.RowCount <= 16)
                {
                    vsb.Visible = false;
                    dgv.Width = 580;
                    coluna.Width += 15;
                }
                else if (dgv.RowCount > 16)
                {
                    vsb.Maximum = dgv.RowCount - 6;
                    return;
                }
            }

            if (dgv.Width == 580)
            {
                if (dgv.RowCount > 16)
                {
                    vsb.Visible = true;
                    dgv.Width = 565;
                    coluna.Width += -15;
                }
                else if (dgv.RowCount <= 16)
                {
                    vsb.Maximum = dgv.RowCount - 6;
                    return;
                }
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

        private void tbcConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tbcConsulta.SelectedIndex)
            {
                case 0:
                    vsbDgvContr.Focus();
                    break;
                case 1:
                    vsbDgvLoc.Focus();
                    break;
                case 2:
                    vsbDgvArm.Focus();
                    break;
                case 3:
                    vsbDgvBloc.Focus();
                    break;
                case 4:
                    vsbDgvSec.Focus();
                    break;
            }
        }

        private void tbpSecoes_MouseMove(object sender, MouseEventArgs e)
        {
            vsbDgvSec.Focus();
        }

        private void tbpBlocos_MouseMove(object sender, MouseEventArgs e)
        {
            vsbDgvBloc.Focus();
        }

        private void tbpArmarios_MouseMove(object sender, MouseEventArgs e)
        {
            vsbDgvArm.Focus();
        }

        private void tbpLocatarios_MouseMove(object sender, MouseEventArgs e)
        {
            vsbDgvLoc.Focus();
        }

        private void tbpContratos_MouseMove(object sender, MouseEventArgs e)
        {
            vsbDgvContr.Focus();
        }

        private void CarregarContLabels()
        {
            locatarioAtivo = contratoAtivo.Locatario;
            armarioAtivo = contratoAtivo.Armario;

            lblContIdCont.Text = Convert.ToString(contratoAtivo.IdContrato);
            lblContValidadeCont.Text = Convert.ToString(contratoAtivo.Validade);
            lblContTipoCont.Text = contratoAtivo.TipoContrato;
            lblContValorCont.Text = contratoAtivo.Valor;

            lblContIdLoc.Text = Convert.ToString(locatarioAtivo.IdLocatario);
            lblContNomeLoc.Text = locatarioAtivo.Nome;
            lblContProntLoc.Text = locatarioAtivo.Prontuario;
            lblContEmailLoc.Text = locatarioAtivo.Email;
            lblContTelLoc.Text = locatarioAtivo.Telefone;

            lblContIdArm.Text = Convert.ToString(armarioAtivo.IdArmario);
            lblContNumArm.Text = armarioAtivo.Numero;
            lblContBlocArm.Text = armarioAtivo.Bloco.Numero;
            lblContSecArm.Text = armarioAtivo.Bloco.Secao.Nome;
        }

        private void CarregarLocLabels()
        {
            foreach (var c in listaContratos)
                if (c.IdContrato == locatarioAtivo.ContratoAtivo)
                    contratoAtivo = c;

            lblLocIdLoc.Text = Convert.ToString(locatarioAtivo.IdLocatario);
            lblLocNomeLoc.Text = locatarioAtivo.Nome;
            lblLocProntLoc.Text = locatarioAtivo.Prontuario;
            lblLocEmailLoc.Text = locatarioAtivo.Email;
            lblLocTelLoc.Text = locatarioAtivo.Telefone;

            if (locatarioAtivo.TemContrato == true)
            {
                lblLocIdCont.Text = Convert.ToString(contratoAtivo.IdContrato);
                lblLocValidadeCont.Text = Convert.ToString(contratoAtivo.Validade);
                lblLocTipoCont.Text = contratoAtivo.TipoContrato;
                lblLocValorCont.Text = contratoAtivo.Valor;
            }
            else
            {
                lblLocIdCont.Text = "...";
                lblLocValidadeCont.Text = "...";
                lblLocTipoCont.Text = "...";
                lblLocValorCont.Text = "...";
            }
        }

        private void CarregarArmLabels()
        {
            foreach (var c in listaContratos)
                if (c.IdContrato == armarioAtivo.ContratoAtivo)
                    contratoAtivo = c;

            lblArmIdArm.Text = Convert.ToString(armarioAtivo.IdArmario);
            lblArmNumArm.Text = armarioAtivo.Numero;
            lblArmBlocArm.Text = armarioAtivo.Bloco.Numero;
            lblArmSecArm.Text = armarioAtivo.Bloco.Secao.Nome;

            if (armarioAtivo.TemContrato == true)
            {
                lblArmIdCont.Text = Convert.ToString(contratoAtivo.IdContrato);
                lblArmValidadeCont.Text = Convert.ToString(contratoAtivo.Validade);
                lblArmTipoCont.Text = contratoAtivo.TipoContrato;
                lblArmValorCont.Text = contratoAtivo.Valor;
            }
            else
            {
                lblArmIdCont.Text = "...";
                lblArmValidadeCont.Text = "...";
                lblArmTipoCont.Text = "...";
                lblArmValorCont.Text = "...";
            }
        }

        private void CarregarBlocLabels()
        {
            int qntArm = 0;
            foreach (var a in listaArmarios)
                if (a.IdBloco == blocoAtivo.IdBloco && a.Danificado == false)
                    qntArm++;

            lblBlocIdBloc.Text = Convert.ToString(blocoAtivo.IdBloco);
            lblBlocNumBloc.Text = blocoAtivo.Numero;
            lblBlocSecBloc.Text = blocoAtivo.Secao.Nome;
            lblBlocQntArm.Text = Convert.ToString(qntArm);
        }

        private void CarregarSecLabels()
        {
            int qntBloc = 0;
            foreach (var b in listaBlocos)
                if (b.IdSecao == secaoAtiva.IdSecao)
                    qntBloc++;
            int qntArm = 0;
            foreach (var a in listaArmarios)
                if (a.Bloco.IdSecao == secaoAtiva.IdSecao && a.Danificado == false)
                    qntArm++;

            lblSecIdSec.Text = Convert.ToString(secaoAtiva.IdSecao);
            lblSecNomeSec.Text = secaoAtiva.Nome;
            lblSecDescSec.Text = secaoAtiva.Descricao;
            lblSecQntBloc.Text = Convert.ToString(qntBloc);
            lblSecQntArm.Text = Convert.ToString(qntArm);
        }

        private void dgvContratos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vsbDgvContr.Focus();

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            int idLinha = (int)dgvContratos[0, e.RowIndex].Value;
            foreach (var c in listaContratos)
                if (c.IdContrato.Equals(idLinha))
                {
                    contratoAtivo = c;
                    this.CarregarContLabels();
                }
        }

        private void dgvLocatarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vsbDgvLoc.Focus();

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            int idLinha = (int)dgvLocatarios[0, e.RowIndex].Value;
            foreach (var l in listaLocatarios)
                if (l.IdLocatario.Equals(idLinha))
                {
                    locatarioAtivo = l;
                    this.CarregarLocLabels();
                }
        }

        private void dgvArmarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vsbDgvArm.Focus();

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            int idLinha = (int)dgvArmarios[0, e.RowIndex].Value;
            foreach (var a in listaArmarios)
                if (a.IdArmario.Equals(idLinha))
                {
                    armarioAtivo = a;
                    this.CarregarArmLabels();
                }
        }

        private void dgvBlocos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vsbDgvBloc.Focus();

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            int idLinha = (int)dgvBlocos[0, e.RowIndex].Value;
            foreach (var b in listaBlocos)
                if (b.IdBloco.Equals(idLinha))
                {
                    blocoAtivo = b;
                    this.CarregarBlocLabels();
                }
        }

        private void dgvSecoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vsbDgvSec.Focus();

            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            int idLinha = (int)dgvSecoes[0, e.RowIndex].Value;
            foreach (var s in listaSecoes)
                if (s.IdSecao.Equals(idLinha))
                {
                    secaoAtiva = s;
                    this.CarregarSecLabels();
                }
        }

        private void txbPesquisar_TextChanged(object sender, EventArgs e)
        {
            this.resetarFiltro();

            listaContratosFiltrada.Clear();
            listaLocatariosFiltrada.Clear();
            listaArmariosFiltrada.Clear();
            listaBlocosFiltrada.Clear();
            listaSecoesFiltrada.Clear();

            bool temTexto = false;
            switch (tbcConsulta.SelectedIndex)
            {
                case 0:
                    foreach (DataGridViewRow r in dgvContratos.Rows)
                    {
                        temTexto = false;
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value).ToString().ToUpper().Contains(txbPesquisar.Text.ToUpper()))
                            {
                                this.adicionarFiltro(0, r);
                                temTexto = true;
                                break;
                            }
                        }
                        if (temTexto == false)
                            continue;
                    }
                    this.carregarFiltro();
                    break;
                case 1:
                    foreach (DataGridViewRow r in dgvLocatarios.Rows)
                    {
                        temTexto = false;
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value).ToString().ToUpper().Contains(txbPesquisar.Text.ToUpper()))
                            {
                                this.adicionarFiltro(1, r);
                                temTexto = true;
                                break;
                            }
                        }
                        if (temTexto == false)
                            continue;
                    }
                    this.carregarFiltro();
                    break;
                case 2:
                    foreach (DataGridViewRow r in dgvArmarios.Rows)
                    {
                        temTexto = false;
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value).ToString().ToUpper().Contains(txbPesquisar.Text.ToUpper()))
                            {
                                this.adicionarFiltro(2, r);
                                temTexto = true;
                                break;
                            }
                        }
                        if (temTexto == false)
                            continue;
                    }
                    this.carregarFiltro();
                    break;
                case 3:
                    foreach (DataGridViewRow r in dgvBlocos.Rows)
                    {
                        temTexto = false;
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value).ToString().ToUpper().Contains(txbPesquisar.Text.ToUpper()))
                            {
                                this.adicionarFiltro(3, r);
                                temTexto = true;
                                break;
                            }
                        }
                        if (temTexto == false)
                            continue;
                    }
                    this.carregarFiltro();
                    break;
                case 4:
                    foreach (DataGridViewRow r in dgvSecoes.Rows)
                    {
                        temTexto = false;
                        foreach (DataGridViewCell c in r.Cells)
                        {
                            if ((c.Value).ToString().ToUpper().Contains(txbPesquisar.Text.ToUpper()))
                            {
                                this.adicionarFiltro(4, r);
                                temTexto = true;
                                break;
                            }
                        }
                        if (temTexto == false)
                            continue;
                    }
                    this.carregarFiltro();
                    break;
            }
        }

        private void carregarFiltro()
        {
            listaContratos = listaContratosFiltrada;
            listaLocatarios = listaLocatariosFiltrada;
            listaArmarios = listaArmariosFiltrada;
            listaBlocos = listaBlocosFiltrada;
            listaSecoes = listaSecoesFiltrada;

            object a = new object();
            EventArgs b = new EventArgs();
            this.ConsultaArmarioAvanc_Activated(a, b);
        }

        private void adicionarFiltro(int opcao, DataGridViewRow r)
        {
            switch (opcao)
            {
                case 0:
                    foreach (var c in baseContratos)
                        if (c.IdContrato.Equals(r.Cells[0].Value))
                            listaContratosFiltrada.Add(c);
                    break;
                case 1:
                    foreach (var l in baseLocatarios)
                        if (l.IdLocatario.Equals(r.Cells[0].Value))
                            listaLocatariosFiltrada.Add(l);
                    break;
                case 2:
                    foreach (var a in baseArmarios)
                        if (a.IdArmario.Equals(r.Cells[0].Value))
                            listaArmariosFiltrada.Add(a);
                    break;
                case 3:
                    foreach (var b in baseBlocos)
                        if (b.IdBloco.Equals(r.Cells[0].Value))
                            listaBlocosFiltrada.Add(b);
                    break;
                case 4:
                    foreach (var s in baseSecoes)
                        if (s.IdSecao.Equals(r.Cells[0].Value))
                            listaSecoesFiltrada.Add(s);
                    break;
            }
        }

        private void resetarFiltro()
        {
            listaContratos = baseContratos;
            listaLocatarios = baseLocatarios;
            listaArmarios = baseArmarios;
            listaBlocos = baseBlocos;
            listaSecoes = baseSecoes;

            object a = new object();
            EventArgs b = new EventArgs();
            this.ConsultaArmarioAvanc_Activated(a, b);
        }

        private void tbpContratos_Enter(object sender, EventArgs e)
        {
            this.CarregarScrollBars(dgvContratos, vsbDgvContr);
        }

        private void tbpLocatarios_Enter(object sender, EventArgs e)
        {
            this.CarregarScrollBars(dgvLocatarios, vsbDgvLoc);
        }

        private void tbpArmarios_Enter(object sender, EventArgs e)
        {
            this.CarregarScrollBars(dgvArmarios, vsbDgvArm);
        }

        private void tbpBlocos_Enter(object sender, EventArgs e)
        {
            this.CarregarScrollBars(dgvBlocos, vsbDgvBloc);
        }

        private void tbpSecoes_Enter(object sender, EventArgs e)
        {
            this.CarregarScrollBars(dgvSecoes, vsbDgvSec);
        }
    }
}
