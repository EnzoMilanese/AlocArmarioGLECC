namespace AlocArmario.View
{
    partial class ConsultaArmarioAvanc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaArmarioAvanc));
            this.tbcConsulta = new System.Windows.Forms.TabControl();
            this.tbpContratos = new System.Windows.Forms.TabPage();
            this.vsbDgvContr = new System.Windows.Forms.VScrollBar();
            this.btnCadastContrato = new System.Windows.Forms.Button();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.IdContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidadeContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArmarioContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocatarioContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpLocatarios = new System.Windows.Forms.TabPage();
            this.vsbDgvLoc = new System.Windows.Forms.VScrollBar();
            this.btnCadastLocatario = new System.Windows.Forms.Button();
            this.dgvLocatarios = new System.Windows.Forms.DataGridView();
            this.IdLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProntLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoLocatario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpArmarios = new System.Windows.Forms.TabPage();
            this.vsbDgvArm = new System.Windows.Forms.VScrollBar();
            this.dgvArmarios = new System.Windows.Forms.DataGridView();
            this.IdArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlocoArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Secao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArmarioTemContrato = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpBlocos = new System.Windows.Forms.TabPage();
            this.vsbDgvBloc = new System.Windows.Forms.VScrollBar();
            this.btnCadastBloco = new System.Windows.Forms.Button();
            this.dgvBlocos = new System.Windows.Forms.DataGridView();
            this.IdBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecaoBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpSecoes = new System.Windows.Forms.TabPage();
            this.vsbDgvSec = new System.Windows.Forms.VScrollBar();
            this.btnCadastSecao = new System.Windows.Forms.Button();
            this.dgvSecoes = new System.Windows.Forms.DataGridView();
            this.IdSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcConsulta.SuspendLayout();
            this.tbpContratos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).BeginInit();
            this.tbpLocatarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatarios)).BeginInit();
            this.tbpArmarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmarios)).BeginInit();
            this.tbpBlocos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).BeginInit();
            this.tbpSecoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecoes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcConsulta
            // 
            this.tbcConsulta.Controls.Add(this.tbpContratos);
            this.tbcConsulta.Controls.Add(this.tbpLocatarios);
            this.tbcConsulta.Controls.Add(this.tbpArmarios);
            this.tbcConsulta.Controls.Add(this.tbpBlocos);
            this.tbcConsulta.Controls.Add(this.tbpSecoes);
            this.tbcConsulta.Location = new System.Drawing.Point(12, 36);
            this.tbcConsulta.Name = "tbcConsulta";
            this.tbcConsulta.SelectedIndex = 0;
            this.tbcConsulta.Size = new System.Drawing.Size(860, 415);
            this.tbcConsulta.TabIndex = 1;
            this.tbcConsulta.SelectedIndexChanged += new System.EventHandler(this.tbcConsulta_SelectedIndexChanged);
            // 
            // tbpContratos
            // 
            this.tbpContratos.Controls.Add(this.vsbDgvContr);
            this.tbpContratos.Controls.Add(this.btnCadastContrato);
            this.tbpContratos.Controls.Add(this.dgvContratos);
            this.tbpContratos.Location = new System.Drawing.Point(4, 22);
            this.tbpContratos.Name = "tbpContratos";
            this.tbpContratos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContratos.Size = new System.Drawing.Size(852, 389);
            this.tbpContratos.TabIndex = 0;
            this.tbpContratos.Text = "Contratos";
            this.tbpContratos.UseVisualStyleBackColor = true;
            this.tbpContratos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpContratos_MouseMove);
            // 
            // vsbDgvContr
            // 
            this.vsbDgvContr.Location = new System.Drawing.Point(831, 6);
            this.vsbDgvContr.Name = "vsbDgvContr";
            this.vsbDgvContr.Size = new System.Drawing.Size(15, 377);
            this.vsbDgvContr.TabIndex = 5;
            this.vsbDgvContr.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDgvContr_Scroll);
            // 
            // btnCadastContrato
            // 
            this.btnCadastContrato.Location = new System.Drawing.Point(6, 6);
            this.btnCadastContrato.Name = "btnCadastContrato";
            this.btnCadastContrato.Size = new System.Drawing.Size(254, 38);
            this.btnCadastContrato.TabIndex = 4;
            this.btnCadastContrato.Text = "Novo Contrato";
            this.btnCadastContrato.UseVisualStyleBackColor = true;
            this.btnCadastContrato.Click += new System.EventHandler(this.btnCadastContrato_Click);
            // 
            // dgvContratos
            // 
            this.dgvContratos.AllowUserToAddRows = false;
            this.dgvContratos.AllowUserToDeleteRows = false;
            this.dgvContratos.AllowUserToOrderColumns = true;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdContrato,
            this.ValidadeContrato,
            this.ValorContrato,
            this.ContratoTipo,
            this.ArmarioContrato,
            this.LocatarioContrato});
            this.dgvContratos.Location = new System.Drawing.Point(266, 6);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvContratos.Size = new System.Drawing.Size(565, 377);
            this.dgvContratos.TabIndex = 3;
            // 
            // IdContrato
            // 
            this.IdContrato.HeaderText = "ID";
            this.IdContrato.Name = "IdContrato";
            this.IdContrato.Width = 37;
            // 
            // ValidadeContrato
            // 
            this.ValidadeContrato.HeaderText = "Validade";
            this.ValidadeContrato.Name = "ValidadeContrato";
            // 
            // ValorContrato
            // 
            this.ValorContrato.HeaderText = "Valor";
            this.ValorContrato.Name = "ValorContrato";
            this.ValorContrato.Width = 90;
            // 
            // ContratoTipo
            // 
            this.ContratoTipo.HeaderText = "Tipo";
            this.ContratoTipo.Name = "ContratoTipo";
            this.ContratoTipo.Width = 90;
            // 
            // ArmarioContrato
            // 
            this.ArmarioContrato.HeaderText = "Armário";
            this.ArmarioContrato.Name = "ArmarioContrato";
            this.ArmarioContrato.Width = 85;
            // 
            // LocatarioContrato
            // 
            this.LocatarioContrato.HeaderText = "Locatário";
            this.LocatarioContrato.Name = "LocatarioContrato";
            this.LocatarioContrato.Width = 120;
            // 
            // tbpLocatarios
            // 
            this.tbpLocatarios.Controls.Add(this.vsbDgvLoc);
            this.tbpLocatarios.Controls.Add(this.btnCadastLocatario);
            this.tbpLocatarios.Controls.Add(this.dgvLocatarios);
            this.tbpLocatarios.Location = new System.Drawing.Point(4, 22);
            this.tbpLocatarios.Name = "tbpLocatarios";
            this.tbpLocatarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLocatarios.Size = new System.Drawing.Size(852, 389);
            this.tbpLocatarios.TabIndex = 1;
            this.tbpLocatarios.Text = "Locatários";
            this.tbpLocatarios.UseVisualStyleBackColor = true;
            this.tbpLocatarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpLocatarios_MouseMove);
            // 
            // vsbDgvLoc
            // 
            this.vsbDgvLoc.Location = new System.Drawing.Point(831, 6);
            this.vsbDgvLoc.Name = "vsbDgvLoc";
            this.vsbDgvLoc.Size = new System.Drawing.Size(15, 377);
            this.vsbDgvLoc.TabIndex = 6;
            this.vsbDgvLoc.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDgvLoc_Scroll);
            // 
            // btnCadastLocatario
            // 
            this.btnCadastLocatario.Location = new System.Drawing.Point(6, 6);
            this.btnCadastLocatario.Name = "btnCadastLocatario";
            this.btnCadastLocatario.Size = new System.Drawing.Size(254, 38);
            this.btnCadastLocatario.TabIndex = 5;
            this.btnCadastLocatario.Text = "Novo Locatário";
            this.btnCadastLocatario.UseVisualStyleBackColor = true;
            this.btnCadastLocatario.Click += new System.EventHandler(this.btnCadastLocatario_Click);
            // 
            // dgvLocatarios
            // 
            this.dgvLocatarios.AllowUserToAddRows = false;
            this.dgvLocatarios.AllowUserToDeleteRows = false;
            this.dgvLocatarios.AllowUserToOrderColumns = true;
            this.dgvLocatarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocatarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLocatario,
            this.NomeLocatario,
            this.ProntLocatario,
            this.EmailLocatario,
            this.TelefoneLocatario,
            this.ContratoLocatario});
            this.dgvLocatarios.Location = new System.Drawing.Point(266, 6);
            this.dgvLocatarios.Name = "dgvLocatarios";
            this.dgvLocatarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvLocatarios.Size = new System.Drawing.Size(565, 377);
            this.dgvLocatarios.TabIndex = 3;
            // 
            // IdLocatario
            // 
            this.IdLocatario.HeaderText = "ID";
            this.IdLocatario.Name = "IdLocatario";
            this.IdLocatario.Width = 37;
            // 
            // NomeLocatario
            // 
            this.NomeLocatario.HeaderText = "Nome";
            this.NomeLocatario.Name = "NomeLocatario";
            this.NomeLocatario.Width = 120;
            // 
            // ProntLocatario
            // 
            this.ProntLocatario.HeaderText = "Prontuário";
            this.ProntLocatario.Name = "ProntLocatario";
            this.ProntLocatario.Width = 60;
            // 
            // EmailLocatario
            // 
            this.EmailLocatario.HeaderText = "Email";
            this.EmailLocatario.Name = "EmailLocatario";
            this.EmailLocatario.Width = 160;
            // 
            // TelefoneLocatario
            // 
            this.TelefoneLocatario.HeaderText = "Telefone";
            this.TelefoneLocatario.Name = "TelefoneLocatario";
            this.TelefoneLocatario.Width = 90;
            // 
            // ContratoLocatario
            // 
            this.ContratoLocatario.HeaderText = "Contrato";
            this.ContratoLocatario.Name = "ContratoLocatario";
            this.ContratoLocatario.Width = 55;
            // 
            // tbpArmarios
            // 
            this.tbpArmarios.Controls.Add(this.vsbDgvArm);
            this.tbpArmarios.Controls.Add(this.dgvArmarios);
            this.tbpArmarios.Location = new System.Drawing.Point(4, 22);
            this.tbpArmarios.Name = "tbpArmarios";
            this.tbpArmarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArmarios.Size = new System.Drawing.Size(852, 389);
            this.tbpArmarios.TabIndex = 2;
            this.tbpArmarios.Text = "Armarios";
            this.tbpArmarios.UseVisualStyleBackColor = true;
            this.tbpArmarios.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpArmarios_MouseMove);
            // 
            // vsbDgvArm
            // 
            this.vsbDgvArm.Location = new System.Drawing.Point(831, 6);
            this.vsbDgvArm.Name = "vsbDgvArm";
            this.vsbDgvArm.Size = new System.Drawing.Size(15, 377);
            this.vsbDgvArm.TabIndex = 4;
            this.vsbDgvArm.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDgvArm_Scroll);
            // 
            // dgvArmarios
            // 
            this.dgvArmarios.AllowUserToAddRows = false;
            this.dgvArmarios.AllowUserToDeleteRows = false;
            this.dgvArmarios.AllowUserToOrderColumns = true;
            this.dgvArmarios.AllowUserToResizeColumns = false;
            this.dgvArmarios.AllowUserToResizeRows = false;
            this.dgvArmarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArmario,
            this.NumeroArmario,
            this.BlocoArmario,
            this.Secao,
            this.ArmarioTemContrato});
            this.dgvArmarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArmarios.Location = new System.Drawing.Point(266, 6);
            this.dgvArmarios.Name = "dgvArmarios";
            this.dgvArmarios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvArmarios.Size = new System.Drawing.Size(565, 377);
            this.dgvArmarios.TabIndex = 3;
            // 
            // IdArmario
            // 
            this.IdArmario.FillWeight = 28.4264F;
            this.IdArmario.HeaderText = "ID";
            this.IdArmario.Name = "IdArmario";
            this.IdArmario.Width = 37;
            // 
            // NumeroArmario
            // 
            this.NumeroArmario.FillWeight = 123.8579F;
            this.NumeroArmario.HeaderText = "Número";
            this.NumeroArmario.Name = "NumeroArmario";
            // 
            // BlocoArmario
            // 
            this.BlocoArmario.FillWeight = 123.8579F;
            this.BlocoArmario.HeaderText = "Bloco";
            this.BlocoArmario.Name = "BlocoArmario";
            // 
            // Secao
            // 
            this.Secao.FillWeight = 123.8579F;
            this.Secao.HeaderText = "Seção";
            this.Secao.Name = "Secao";
            this.Secao.Width = 215;
            // 
            // ArmarioTemContrato
            // 
            this.ArmarioTemContrato.HeaderText = "Contato";
            this.ArmarioTemContrato.Name = "ArmarioTemContrato";
            this.ArmarioTemContrato.Width = 70;
            // 
            // tbpBlocos
            // 
            this.tbpBlocos.Controls.Add(this.vsbDgvBloc);
            this.tbpBlocos.Controls.Add(this.btnCadastBloco);
            this.tbpBlocos.Controls.Add(this.dgvBlocos);
            this.tbpBlocos.Location = new System.Drawing.Point(4, 22);
            this.tbpBlocos.Name = "tbpBlocos";
            this.tbpBlocos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBlocos.Size = new System.Drawing.Size(852, 389);
            this.tbpBlocos.TabIndex = 3;
            this.tbpBlocos.Text = "Blocos";
            this.tbpBlocos.UseVisualStyleBackColor = true;
            this.tbpBlocos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpBlocos_MouseMove);
            // 
            // vsbDgvBloc
            // 
            this.vsbDgvBloc.Location = new System.Drawing.Point(831, 6);
            this.vsbDgvBloc.Name = "vsbDgvBloc";
            this.vsbDgvBloc.Size = new System.Drawing.Size(15, 377);
            this.vsbDgvBloc.TabIndex = 6;
            this.vsbDgvBloc.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDgvBloc_Scroll);
            // 
            // btnCadastBloco
            // 
            this.btnCadastBloco.Location = new System.Drawing.Point(6, 6);
            this.btnCadastBloco.Name = "btnCadastBloco";
            this.btnCadastBloco.Size = new System.Drawing.Size(254, 38);
            this.btnCadastBloco.TabIndex = 5;
            this.btnCadastBloco.Text = "Novo Bloco";
            this.btnCadastBloco.UseVisualStyleBackColor = true;
            this.btnCadastBloco.Click += new System.EventHandler(this.btnCadastBloco_Click);
            // 
            // dgvBlocos
            // 
            this.dgvBlocos.AllowUserToAddRows = false;
            this.dgvBlocos.AllowUserToDeleteRows = false;
            this.dgvBlocos.AllowUserToOrderColumns = true;
            this.dgvBlocos.AllowUserToResizeColumns = false;
            this.dgvBlocos.AllowUserToResizeRows = false;
            this.dgvBlocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBloco,
            this.NumeroBloco,
            this.SecaoBloco});
            this.dgvBlocos.Location = new System.Drawing.Point(266, 6);
            this.dgvBlocos.Name = "dgvBlocos";
            this.dgvBlocos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvBlocos.Size = new System.Drawing.Size(565, 377);
            this.dgvBlocos.TabIndex = 3;
            // 
            // IdBloco
            // 
            this.IdBloco.FillWeight = 2.809951F;
            this.IdBloco.HeaderText = "ID";
            this.IdBloco.Name = "IdBloco";
            this.IdBloco.Width = 37;
            // 
            // NumeroBloco
            // 
            this.NumeroBloco.FillWeight = 12.41847F;
            this.NumeroBloco.HeaderText = "Numero";
            this.NumeroBloco.Name = "NumeroBloco";
            // 
            // SecaoBloco
            // 
            this.SecaoBloco.FillWeight = 284.7716F;
            this.SecaoBloco.HeaderText = "Seção";
            this.SecaoBloco.Name = "SecaoBloco";
            this.SecaoBloco.Width = 385;
            // 
            // tbpSecoes
            // 
            this.tbpSecoes.Controls.Add(this.vsbDgvSec);
            this.tbpSecoes.Controls.Add(this.btnCadastSecao);
            this.tbpSecoes.Controls.Add(this.dgvSecoes);
            this.tbpSecoes.Location = new System.Drawing.Point(4, 22);
            this.tbpSecoes.Name = "tbpSecoes";
            this.tbpSecoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSecoes.Size = new System.Drawing.Size(852, 389);
            this.tbpSecoes.TabIndex = 4;
            this.tbpSecoes.Text = "Seções";
            this.tbpSecoes.UseVisualStyleBackColor = true;
            this.tbpSecoes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbpSecoes_MouseMove);
            // 
            // vsbDgvSec
            // 
            this.vsbDgvSec.Location = new System.Drawing.Point(831, 6);
            this.vsbDgvSec.Name = "vsbDgvSec";
            this.vsbDgvSec.Size = new System.Drawing.Size(15, 377);
            this.vsbDgvSec.TabIndex = 6;
            this.vsbDgvSec.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbDgvSec_Scroll);
            // 
            // btnCadastSecao
            // 
            this.btnCadastSecao.Location = new System.Drawing.Point(6, 6);
            this.btnCadastSecao.Name = "btnCadastSecao";
            this.btnCadastSecao.Size = new System.Drawing.Size(254, 38);
            this.btnCadastSecao.TabIndex = 5;
            this.btnCadastSecao.Text = "Nova Seção";
            this.btnCadastSecao.UseVisualStyleBackColor = true;
            this.btnCadastSecao.Click += new System.EventHandler(this.btnCadastSecao_Click);
            // 
            // dgvSecoes
            // 
            this.dgvSecoes.AllowUserToAddRows = false;
            this.dgvSecoes.AllowUserToDeleteRows = false;
            this.dgvSecoes.AllowUserToResizeColumns = false;
            this.dgvSecoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSecao,
            this.NomeSecao,
            this.DescricaoSecao});
            this.dgvSecoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSecoes.Location = new System.Drawing.Point(266, 6);
            this.dgvSecoes.Name = "dgvSecoes";
            this.dgvSecoes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSecoes.Size = new System.Drawing.Size(565, 377);
            this.dgvSecoes.TabIndex = 4;
            // 
            // IdSecao
            // 
            this.IdSecao.FillWeight = 33.40196F;
            this.IdSecao.HeaderText = "ID";
            this.IdSecao.Name = "IdSecao";
            this.IdSecao.Width = 37;
            // 
            // NomeSecao
            // 
            this.NomeSecao.FillWeight = 63.95938F;
            this.NomeSecao.HeaderText = "Nome";
            this.NomeSecao.Name = "NomeSecao";
            // 
            // DescricaoSecao
            // 
            this.DescricaoSecao.FillWeight = 202.6386F;
            this.DescricaoSecao.HeaderText = "Descrição";
            this.DescricaoSecao.Name = "DescricaoSecao";
            this.DescricaoSecao.Width = 385;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(654, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Alocação de Armários - GLECC";
            // 
            // ConsultaArmarioAvanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 463);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbcConsulta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaArmarioAvanc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alocação de Armários";
            this.Activated += new System.EventHandler(this.ConsultaArmarioAvanc_Activated);
            this.tbcConsulta.ResumeLayout(false);
            this.tbpContratos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContratos)).EndInit();
            this.tbpLocatarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocatarios)).EndInit();
            this.tbpArmarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArmarios)).EndInit();
            this.tbpBlocos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).EndInit();
            this.tbpSecoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tbcConsulta;
        private System.Windows.Forms.TabPage tbpContratos;
        private System.Windows.Forms.TabPage tbpLocatarios;
        private System.Windows.Forms.TabPage tbpArmarios;
        private System.Windows.Forms.TabPage tbpBlocos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvContratos;
        private System.Windows.Forms.DataGridView dgvLocatarios;
        private System.Windows.Forms.DataGridView dgvArmarios;
        private System.Windows.Forms.DataGridView dgvBlocos;
        private System.Windows.Forms.TabPage tbpSecoes;
        private System.Windows.Forms.DataGridView dgvSecoes;
        private System.Windows.Forms.Button btnCadastContrato;
        private System.Windows.Forms.Button btnCadastLocatario;
        private System.Windows.Forms.Button btnCadastBloco;
        private System.Windows.Forms.Button btnCadastSecao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vsbDgvLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProntLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneLocatario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ContratoLocatario;
        private System.Windows.Forms.VScrollBar vsbDgvArm;
        private System.Windows.Forms.VScrollBar vsbDgvBloc;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroBloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecaoBloco;
        private System.Windows.Forms.VScrollBar vsbDgvContr;
        private System.Windows.Forms.VScrollBar vsbDgvSec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidadeContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContratoTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmarioContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocatarioContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlocoArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Secao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ArmarioTemContrato;
    }
}