namespace AlocArmario
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.rdbSimples = new System.Windows.Forms.RadioButton();
            this.rdbAvancado = new System.Windows.Forms.RadioButton();
            this.grbxInterface = new System.Windows.Forms.GroupBox();
            this.lblDescInterf = new System.Windows.Forms.Label();
            this.grbxInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Alocação de Armários";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prontuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // txbPront
            // 
            this.txbPront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPront.Location = new System.Drawing.Point(158, 115);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(217, 22);
            this.txbPront.TabIndex = 0;
            // 
            // txbSenha
            // 
            this.txbSenha.CausesValidation = false;
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(158, 148);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(217, 22);
            this.txbSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(194, 288);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbSimples
            // 
            this.rdbSimples.AutoSize = true;
            this.rdbSimples.Location = new System.Drawing.Point(6, 21);
            this.rdbSimples.Name = "rdbSimples";
            this.rdbSimples.Size = new System.Drawing.Size(75, 20);
            this.rdbSimples.TabIndex = 0;
            this.rdbSimples.Text = "Simples";
            this.rdbSimples.UseVisualStyleBackColor = true;
            this.rdbSimples.CheckedChanged += new System.EventHandler(this.rdbSimples_CheckedChanged);
            // 
            // rdbAvancado
            // 
            this.rdbAvancado.AutoSize = true;
            this.rdbAvancado.Location = new System.Drawing.Point(6, 47);
            this.rdbAvancado.Name = "rdbAvancado";
            this.rdbAvancado.Size = new System.Drawing.Size(88, 20);
            this.rdbAvancado.TabIndex = 1;
            this.rdbAvancado.Text = "Avançada";
            this.rdbAvancado.UseVisualStyleBackColor = true;
            this.rdbAvancado.CheckedChanged += new System.EventHandler(this.rdbAvancado_CheckedChanged);
            // 
            // grbxInterface
            // 
            this.grbxInterface.Controls.Add(this.lblDescInterf);
            this.grbxInterface.Controls.Add(this.rdbSimples);
            this.grbxInterface.Controls.Add(this.rdbAvancado);
            this.grbxInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbxInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbxInterface.Location = new System.Drawing.Point(64, 190);
            this.grbxInterface.Name = "grbxInterface";
            this.grbxInterface.Size = new System.Drawing.Size(343, 78);
            this.grbxInterface.TabIndex = 3;
            this.grbxInterface.TabStop = false;
            this.grbxInterface.Text = "Interface";
            // 
            // lblDescInterf
            // 
            this.lblDescInterf.AutoSize = true;
            this.lblDescInterf.Location = new System.Drawing.Point(108, 18);
            this.lblDescInterf.Name = "lblDescInterf";
            this.lblDescInterf.Size = new System.Drawing.Size(70, 16);
            this.lblDescInterf.TabIndex = 2;
            this.lblDescInterf.Text = "Descrição";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 336);
            this.Controls.Add(this.grbxInterface);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Alocação de Armários";
            this.grbxInterface.ResumeLayout(false);
            this.grbxInterface.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.RadioButton rdbSimples;
        private System.Windows.Forms.RadioButton rdbAvancado;
        private System.Windows.Forms.GroupBox grbxInterface;
        private System.Windows.Forms.Label lblDescInterf;
    }
}

