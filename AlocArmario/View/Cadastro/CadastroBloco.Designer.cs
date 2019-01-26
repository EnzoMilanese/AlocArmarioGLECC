namespace AlocArmario.View.Cadastro
{
    partial class CadastroBloco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBloco));
            label5 = new System.Windows.Forms.Label();
            cbxSecao = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            lblDataDescricao = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnCadastrar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(134, 32);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(157, 24);
            label5.TabIndex = 20;
            label5.Text = "Cadastrar Bloco";
            // 
            // cbxSecao
            // 
            cbxSecao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxSecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cbxSecao.FormattingEnabled = true;
            cbxSecao.ImeMode = System.Windows.Forms.ImeMode.Off;
            cbxSecao.Location = new System.Drawing.Point(107, 87);
            cbxSecao.Name = "cbxSecao";
            cbxSecao.Size = new System.Drawing.Size(103, 24);
            cbxSecao.TabIndex = 21;
            cbxSecao.SelectedIndexChanged += new System.EventHandler(cbxSecao_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(31, 116);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 16);
            label1.TabIndex = 22;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(53, 87);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 16);
            label2.TabIndex = 23;
            label2.Text = "Seção:";
            // 
            // lblDataDescricao
            // 
            lblDataDescricao.AutoSize = true;
            lblDataDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDataDescricao.Location = new System.Drawing.Point(104, 116);
            lblDataDescricao.Margin = new System.Windows.Forms.Padding(0);
            lblDataDescricao.MaximumSize = new System.Drawing.Size(260, 0);
            lblDataDescricao.Name = "lblDataDescricao";
            lblDataDescricao.Size = new System.Drawing.Size(76, 16);
            lblDataDescricao.TabIndex = 24;
            lblDataDescricao.Text = "[descricao]";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(216, 213);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new System.Drawing.Point(135, 213);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(75, 23);
            btnCadastrar.TabIndex = 25;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += new System.EventHandler(btnCadastrar_Click);
            // 
            // CadastroBloco
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 263);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(lblDataDescricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbxSecao);
            Controls.Add(label5);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "CadastroBloco";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Novo Bloco";
            Activated += new System.EventHandler(CadastroBloco_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSecao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDataDescricao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}