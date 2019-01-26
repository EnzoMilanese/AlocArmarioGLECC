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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            txbPront = new System.Windows.Forms.TextBox();
            txbSenha = new System.Windows.Forms.TextBox();
            btnEntrar = new System.Windows.Forms.Button();
            rdbSimples = new System.Windows.Forms.RadioButton();
            rdbAvancado = new System.Windows.Forms.RadioButton();
            grbxInterface = new System.Windows.Forms.GroupBox();
            lblDescInterf = new System.Windows.Forms.Label();
            grbxInterface.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(54, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(353, 37);
            label1.TabIndex = 6;
            label1.Text = "Alocação de Armários";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(78, 115);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 16);
            label2.TabIndex = 5;
            label2.Text = "Prontuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(100, 148);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(50, 16);
            label3.TabIndex = 6;
            label3.Text = "Senha:";
            // 
            // txbPront
            // 
            txbPront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbPront.Location = new System.Drawing.Point(158, 115);
            txbPront.Name = "txbPront";
            txbPront.Size = new System.Drawing.Size(217, 22);
            txbPront.TabIndex = 0;
            // 
            // txbSenha
            // 
            txbSenha.CausesValidation = false;
            txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbSenha.Location = new System.Drawing.Point(158, 148);
            txbSenha.Name = "txbSenha";
            txbSenha.PasswordChar = '*';
            txbSenha.Size = new System.Drawing.Size(217, 22);
            txbSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new System.Drawing.Point(194, 288);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new System.Drawing.Size(75, 23);
            btnEntrar.TabIndex = 2;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += new System.EventHandler(button1_Click);
            // 
            // rdbSimples
            // 
            rdbSimples.AutoSize = true;
            rdbSimples.Location = new System.Drawing.Point(6, 21);
            rdbSimples.Name = "rdbSimples";
            rdbSimples.Size = new System.Drawing.Size(75, 20);
            rdbSimples.TabIndex = 0;
            rdbSimples.Text = "Simples";
            rdbSimples.UseVisualStyleBackColor = true;
            rdbSimples.CheckedChanged += new System.EventHandler(rdbSimples_CheckedChanged);
            // 
            // rdbAvancado
            // 
            rdbAvancado.AutoSize = true;
            rdbAvancado.Location = new System.Drawing.Point(6, 47);
            rdbAvancado.Name = "rdbAvancado";
            rdbAvancado.Size = new System.Drawing.Size(88, 20);
            rdbAvancado.TabIndex = 1;
            rdbAvancado.Text = "Avançada";
            rdbAvancado.UseVisualStyleBackColor = true;
            rdbAvancado.CheckedChanged += new System.EventHandler(rdbAvancado_CheckedChanged);
            // 
            // grbxInterface
            // 
            grbxInterface.Controls.Add(lblDescInterf);
            grbxInterface.Controls.Add(rdbSimples);
            grbxInterface.Controls.Add(rdbAvancado);
            grbxInterface.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            grbxInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            grbxInterface.Location = new System.Drawing.Point(64, 190);
            grbxInterface.Name = "grbxInterface";
            grbxInterface.Size = new System.Drawing.Size(343, 78);
            grbxInterface.TabIndex = 3;
            grbxInterface.TabStop = false;
            grbxInterface.Text = "Interface";
            // 
            // lblDescInterf
            // 
            lblDescInterf.AutoSize = true;
            lblDescInterf.Location = new System.Drawing.Point(108, 18);
            lblDescInterf.Name = "lblDescInterf";
            lblDescInterf.Size = new System.Drawing.Size(70, 16);
            lblDescInterf.TabIndex = 2;
            lblDescInterf.Text = "Descrição";
            // 
            // Login
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(454, 336);
            Controls.Add(grbxInterface);
            Controls.Add(btnEntrar);
            Controls.Add(txbSenha);
            Controls.Add(txbPront);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "Login";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Alocação de Armários";
            grbxInterface.ResumeLayout(false);
            grbxInterface.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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

