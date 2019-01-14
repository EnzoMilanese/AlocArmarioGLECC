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
            this.btnCadastContrato = new System.Windows.Forms.Button();
            this.dgvContratos = new System.Windows.Forms.DataGridView();
            this.IdContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValidadeContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArmarioContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocatarioContrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpLocatarios = new System.Windows.Forms.TabPage();
            this.btnCadastLocatario = new System.Windows.Forms.Button();
            this.dgvLocatarios = new System.Windows.Forms.DataGridView();
            this.IdLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProntLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefoneLocatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoLocatario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbpArmarios = new System.Windows.Forms.TabPage();
            this.dgvArmarios = new System.Windows.Forms.DataGridView();
            this.tbpBlocos = new System.Windows.Forms.TabPage();
            this.btnCadastBloco = new System.Windows.Forms.Button();
            this.dgvBlocos = new System.Windows.Forms.DataGridView();
            this.IdBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecaoBloco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpSecoes = new System.Windows.Forms.TabPage();
            this.btnCadastSecao = new System.Windows.Forms.Button();
            this.dgvSecoes = new System.Windows.Forms.DataGridView();
            this.IdSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoSecao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IdArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlocoArmario = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // 
            // tbpContratos
            // 
            this.tbpContratos.Controls.Add(this.btnCadastContrato);
            this.tbpContratos.Controls.Add(this.dgvContratos);
            this.tbpContratos.Location = new System.Drawing.Point(4, 22);
            this.tbpContratos.Name = "tbpContratos";
            this.tbpContratos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpContratos.Size = new System.Drawing.Size(852, 389);
            this.tbpContratos.TabIndex = 0;
            this.tbpContratos.Text = "Contratos";
            this.tbpContratos.UseVisualStyleBackColor = true;
            // 
            // btnCadastContrato
            // 
            this.btnCadastContrato.Location = new System.Drawing.Point(6, 6);
            this.btnCadastContrato.Name = "btnCadastContrato";
            this.btnCadastContrato.Size = new System.Drawing.Size(254, 38);
            this.btnCadastContrato.TabIndex = 4;
            this.btnCadastContrato.Text = "Novo Contrato";
            this.btnCadastContrato.UseVisualStyleBackColor = true;
            // 
            // dgvContratos
            // 
            this.dgvContratos.AllowUserToAddRows = false;
            this.dgvContratos.AllowUserToDeleteRows = false;
            this.dgvContratos.AllowUserToOrderColumns = true;
            this.dgvContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContratos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContratos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdContrato,
            this.ValidadeContrato,
            this.ValorContrato,
            this.ArmarioContrato,
            this.LocatarioContrato});
            this.dgvContratos.Location = new System.Drawing.Point(266, 6);
            this.dgvContratos.Name = "dgvContratos";
            this.dgvContratos.Size = new System.Drawing.Size(580, 377);
            this.dgvContratos.TabIndex = 3;
            this.dgvContratos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContratos_CellContentClick);
            // 
            // IdContrato
            // 
            this.IdContrato.HeaderText = "ID";
            this.IdContrato.Name = "IdContrato";
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
            // 
            // ArmarioContrato
            // 
            this.ArmarioContrato.HeaderText = "Armário";
            this.ArmarioContrato.Name = "ArmarioContrato";
            // 
            // LocatarioContrato
            // 
            this.LocatarioContrato.HeaderText = "Locatário";
            this.LocatarioContrato.Name = "LocatarioContrato";
            // 
            // tbpLocatarios
            // 
            this.tbpLocatarios.Controls.Add(this.btnCadastLocatario);
            this.tbpLocatarios.Controls.Add(this.dgvLocatarios);
            this.tbpLocatarios.Location = new System.Drawing.Point(4, 22);
            this.tbpLocatarios.Name = "tbpLocatarios";
            this.tbpLocatarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLocatarios.Size = new System.Drawing.Size(852, 389);
            this.tbpLocatarios.TabIndex = 1;
            this.tbpLocatarios.Text = "Locatários";
            this.tbpLocatarios.UseVisualStyleBackColor = true;
            // 
            // btnCadastLocatario
            // 
            this.btnCadastLocatario.Location = new System.Drawing.Point(6, 6);
            this.btnCadastLocatario.Name = "btnCadastLocatario";
            this.btnCadastLocatario.Size = new System.Drawing.Size(254, 38);
            this.btnCadastLocatario.TabIndex = 5;
            this.btnCadastLocatario.Text = "Novo Locatário";
            this.btnCadastLocatario.UseVisualStyleBackColor = true;
            // 
            // dgvLocatarios
            // 
            this.dgvLocatarios.AllowUserToAddRows = false;
            this.dgvLocatarios.AllowUserToDeleteRows = false;
            this.dgvLocatarios.AllowUserToOrderColumns = true;
            this.dgvLocatarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocatarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
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
            this.dgvLocatarios.Size = new System.Drawing.Size(580, 377);
            this.dgvLocatarios.TabIndex = 3;
            // 
            // IdLocatario
            // 
            this.IdLocatario.HeaderText = "ID";
            this.IdLocatario.Name = "IdLocatario";
            // 
            // NomeLocatario
            // 
            this.NomeLocatario.HeaderText = "Nome";
            this.NomeLocatario.Name = "NomeLocatario";
            // 
            // ProntLocatario
            // 
            this.ProntLocatario.HeaderText = "Prontuário";
            this.ProntLocatario.Name = "ProntLocatario";
            // 
            // EmailLocatario
            // 
            this.EmailLocatario.HeaderText = "Email";
            this.EmailLocatario.Name = "EmailLocatario";
            // 
            // TelefoneLocatario
            // 
            this.TelefoneLocatario.HeaderText = "Telefone";
            this.TelefoneLocatario.Name = "TelefoneLocatario";
            // 
            // ContratoLocatario
            // 
            this.ContratoLocatario.HeaderText = "Contrato";
            this.ContratoLocatario.Name = "ContratoLocatario";
            // 
            // tbpArmarios
            // 
            this.tbpArmarios.Controls.Add(this.dgvArmarios);
            this.tbpArmarios.Location = new System.Drawing.Point(4, 22);
            this.tbpArmarios.Name = "tbpArmarios";
            this.tbpArmarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpArmarios.Size = new System.Drawing.Size(852, 389);
            this.tbpArmarios.TabIndex = 2;
            this.tbpArmarios.Text = "Armarios";
            this.tbpArmarios.UseVisualStyleBackColor = true;
            // 
            // dgvArmarios
            // 
            this.dgvArmarios.AllowUserToAddRows = false;
            this.dgvArmarios.AllowUserToDeleteRows = false;
            this.dgvArmarios.AllowUserToOrderColumns = true;
            this.dgvArmarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArmarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvArmarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArmarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArmario,
            this.NumeroArmario,
            this.BlocoArmario});
            this.dgvArmarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArmarios.Location = new System.Drawing.Point(266, 6);
            this.dgvArmarios.Name = "dgvArmarios";
            this.dgvArmarios.Size = new System.Drawing.Size(580, 377);
            this.dgvArmarios.TabIndex = 3;
            // 
            // tbpBlocos
            // 
            this.tbpBlocos.Controls.Add(this.btnCadastBloco);
            this.tbpBlocos.Controls.Add(this.dgvBlocos);
            this.tbpBlocos.Location = new System.Drawing.Point(4, 22);
            this.tbpBlocos.Name = "tbpBlocos";
            this.tbpBlocos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBlocos.Size = new System.Drawing.Size(852, 389);
            this.tbpBlocos.TabIndex = 3;
            this.tbpBlocos.Text = "Blocos";
            this.tbpBlocos.UseVisualStyleBackColor = true;
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
            this.dgvBlocos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBlocos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvBlocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBloco,
            this.NomeBloco,
            this.SecaoBloco});
            this.dgvBlocos.Location = new System.Drawing.Point(266, 6);
            this.dgvBlocos.Name = "dgvBlocos";
            this.dgvBlocos.Size = new System.Drawing.Size(580, 377);
            this.dgvBlocos.TabIndex = 3;
            // 
            // IdBloco
            // 
            this.IdBloco.HeaderText = "ID";
            this.IdBloco.Name = "IdBloco";
            // 
            // NomeBloco
            // 
            this.NomeBloco.HeaderText = "Nome";
            this.NomeBloco.Name = "NomeBloco";
            // 
            // SecaoBloco
            // 
            this.SecaoBloco.HeaderText = "Seção";
            this.SecaoBloco.Name = "SecaoBloco";
            // 
            // tbpSecoes
            // 
            this.tbpSecoes.Controls.Add(this.btnCadastSecao);
            this.tbpSecoes.Controls.Add(this.dgvSecoes);
            this.tbpSecoes.Location = new System.Drawing.Point(4, 22);
            this.tbpSecoes.Name = "tbpSecoes";
            this.tbpSecoes.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSecoes.Size = new System.Drawing.Size(852, 389);
            this.tbpSecoes.TabIndex = 4;
            this.tbpSecoes.Text = "Seções";
            this.tbpSecoes.UseVisualStyleBackColor = true;
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
            this.dgvSecoes.AllowUserToOrderColumns = true;
            this.dgvSecoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecoes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvSecoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSecao,
            this.NomeSecao,
            this.DescricaoSecao});
            this.dgvSecoes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSecoes.Location = new System.Drawing.Point(266, 6);
            this.dgvSecoes.Name = "dgvSecoes";
            this.dgvSecoes.Size = new System.Drawing.Size(580, 377);
            this.dgvSecoes.TabIndex = 4;
            // 
            // IdSecao
            // 
            this.IdSecao.FillWeight = 54.82233F;
            this.IdSecao.HeaderText = "ID";
            this.IdSecao.Name = "IdSecao";
            // 
            // NomeSecao
            // 
            this.NomeSecao.FillWeight = 122.5888F;
            this.NomeSecao.HeaderText = "Nome";
            this.NomeSecao.Name = "NomeSecao";
            // 
            // DescricaoSecao
            // 
            this.DescricaoSecao.FillWeight = 122.5888F;
            this.DescricaoSecao.HeaderText = "Descrição";
            this.DescricaoSecao.Name = "DescricaoSecao";
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
            // IdArmario
            // 
            this.IdArmario.HeaderText = "ID";
            this.IdArmario.Name = "IdArmario";
            // 
            // NumeroArmario
            // 
            this.NumeroArmario.HeaderText = "Número";
            this.NumeroArmario.Name = "NumeroArmario";
            // 
            // BlocoArmario
            // 
            this.BlocoArmario.HeaderText = "Bloco";
            this.BlocoArmario.Name = "BlocoArmario";
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
            this.Load += new System.EventHandler(this.ConsultaArmarioAvanc_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeBloco;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecaoBloco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoSecao;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValidadeContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArmarioContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocatarioContrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProntLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefoneLocatario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ContratoLocatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroArmario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlocoArmario;
    }
}