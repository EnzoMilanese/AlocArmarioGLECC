namespace AlocArmario.View.Cadastro
{
    partial class CadastroContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroContrato));
            btnCancelar = new System.Windows.Forms.Button();
            btnCadastrar = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            cbxLocatario = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            cbxSecao = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            cbxBloco = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            cbxArmario = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            cbxTipoContrato = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            lblDataValidade = new System.Windows.Forms.Label();
            lblDataValor = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(247, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new System.Drawing.Point(166, 289);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += new System.EventHandler(btnCadastrar_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(153, 37);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(182, 24);
            label5.TabIndex = 1;
            label5.Text = "Cadastrar Contrato";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(32, 96);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(67, 16);
            label1.TabIndex = 0;
            label1.Text = "Locatário:";
            // 
            // cbxLocatario
            // 
            cbxLocatario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxLocatario.FormattingEnabled = true;
            cbxLocatario.Location = new System.Drawing.Point(102, 96);
            cbxLocatario.Name = "cbxLocatario";
            cbxLocatario.Size = new System.Drawing.Size(345, 24);
            cbxLocatario.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(48, 128);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 16);
            label2.TabIndex = 10;
            label2.Text = "Seção:";
            // 
            // cbxSecao
            // 
            cbxSecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxSecao.FormattingEnabled = true;
            cbxSecao.Location = new System.Drawing.Point(102, 128);
            cbxSecao.Name = "cbxSecao";
            cbxSecao.Size = new System.Drawing.Size(103, 24);
            cbxSecao.TabIndex = 1;
            cbxSecao.SelectionChangeCommitted += new System.EventHandler(cbxSecao_SelectionChangeCommitted);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(208, 128);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 16);
            label3.TabIndex = 8;
            label3.Text = "Bloco:";
            // 
            // cbxBloco
            // 
            cbxBloco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxBloco.FormattingEnabled = true;
            cbxBloco.Location = new System.Drawing.Point(257, 128);
            cbxBloco.Name = "cbxBloco";
            cbxBloco.Size = new System.Drawing.Size(63, 24);
            cbxBloco.TabIndex = 2;
            cbxBloco.SelectionChangeCommitted += new System.EventHandler(cbxBloco_SelectionChangeCommitted);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(323, 128);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(58, 16);
            label4.TabIndex = 9;
            label4.Text = "Armário:";
            // 
            // cbxArmario
            // 
            cbxArmario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxArmario.FormattingEnabled = true;
            cbxArmario.Location = new System.Drawing.Point(384, 128);
            cbxArmario.Name = "cbxArmario";
            cbxArmario.Size = new System.Drawing.Size(63, 24);
            cbxArmario.TabIndex = 3;
            cbxArmario.SelectionChangeCommitted += new System.EventHandler(cbxArmario_SelectionChangeCommitted);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(33, 184);
            label6.Margin = new System.Windows.Forms.Padding(0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(66, 16);
            label6.TabIndex = 11;
            label6.Text = "Validade:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(323, 184);
            label7.Margin = new System.Windows.Forms.Padding(0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(43, 16);
            label7.TabIndex = 12;
            label7.Text = "Valor:";
            // 
            // cbxTipoContrato
            // 
            cbxTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxTipoContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxTipoContrato.FormattingEnabled = true;
            cbxTipoContrato.Items.AddRange(new object[] {
            "Anual",
            "Semestral"});
            cbxTipoContrato.Location = new System.Drawing.Point(102, 184);
            cbxTipoContrato.Name = "cbxTipoContrato";
            cbxTipoContrato.Size = new System.Drawing.Size(218, 24);
            cbxTipoContrato.TabIndex = 15;
            cbxTipoContrato.SelectedIndexChanged += new System.EventHandler(cbxTipoContrato_SelectedIndexChanged);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(27, 219);
            label8.Margin = new System.Windows.Forms.Padding(0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(72, 16);
            label8.TabIndex = 17;
            label8.Text = "Válido até:";
            // 
            // lblDataValidade
            // 
            lblDataValidade.AutoSize = true;
            lblDataValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataValidade.Location = new System.Drawing.Point(99, 219);
            lblDataValidade.Margin = new System.Windows.Forms.Padding(0);
            lblDataValidade.Name = "lblDataValidade";
            lblDataValidade.Size = new System.Drawing.Size(99, 16);
            lblDataValidade.TabIndex = 18;
            lblDataValidade.Text = "[data validade]";
            // 
            // lblDataValor
            // 
            lblDataValor.AutoSize = true;
            lblDataValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataValor.Location = new System.Drawing.Point(366, 184);
            lblDataValor.Margin = new System.Windows.Forms.Padding(0);
            lblDataValor.Name = "lblDataValor";
            lblDataValor.Size = new System.Drawing.Size(51, 16);
            lblDataValor.TabIndex = 19;
            lblDataValor.Text = "[preço]";
            // 
            // CadastroContrato
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(494, 353);
            Controls.Add(lblDataValor);
            Controls.Add(lblDataValidade);
            Controls.Add(label8);
            Controls.Add(cbxTipoContrato);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbxArmario);
            Controls.Add(label4);
            Controls.Add(cbxBloco);
            Controls.Add(label3);
            Controls.Add(cbxSecao);
            Controls.Add(label2);
            Controls.Add(cbxLocatario);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "CadastroContrato";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Novo Contrato";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxLocatario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxSecao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBloco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxArmario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxTipoContrato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDataValidade;
        private System.Windows.Forms.Label lblDataValor;
    }
}