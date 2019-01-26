namespace AlocArmario.View.LocatarioView
{
    partial class CadastroLocatario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroLocatario));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txbNome = new System.Windows.Forms.TextBox();
            txbEmail = new System.Windows.Forms.TextBox();
            txbPront = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnCadastrar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            mktTel = new System.Windows.Forms.MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(55, 88);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 16);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(31, 119);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 16);
            label2.TabIndex = 1;
            label2.Text = "Prontuário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(58, 152);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(45, 16);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(38, 184);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(65, 16);
            label4.TabIndex = 3;
            label4.Text = "Telefone:";
            // 
            // txbNome
            // 
            txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbNome.Location = new System.Drawing.Point(112, 88);
            txbNome.Margin = new System.Windows.Forms.Padding(0);
            txbNome.Name = "txbNome";
            txbNome.Size = new System.Drawing.Size(278, 22);
            txbNome.TabIndex = 0;
            // 
            // txbEmail
            // 
            txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbEmail.Location = new System.Drawing.Point(112, 152);
            txbEmail.Margin = new System.Windows.Forms.Padding(0);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new System.Drawing.Size(278, 22);
            txbEmail.TabIndex = 2;
            // 
            // txbPront
            // 
            txbPront.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbPront.Location = new System.Drawing.Point(112, 119);
            txbPront.Margin = new System.Windows.Forms.Padding(0);
            txbPront.Name = "txbPront";
            txbPront.Size = new System.Drawing.Size(278, 22);
            txbPront.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(122, 34);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(189, 24);
            label5.TabIndex = 8;
            label5.Text = "Cadastrar Locatário";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new System.Drawing.Point(142, 232);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(75, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += new System.EventHandler(btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(223, 232);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(btnCancelar_Click);
            // 
            // mktTel
            // 
            mktTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mktTel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            mktTel.Location = new System.Drawing.Point(112, 184);
            mktTel.Mask = "(00) 0000-00009";
            mktTel.Name = "mktTel";
            mktTel.Size = new System.Drawing.Size(278, 22);
            mktTel.TabIndex = 3;
            // 
            // CadastroLocatario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 293);
            Controls.Add(mktTel);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(label5);
            Controls.Add(txbPront);
            Controls.Add(txbEmail);
            Controls.Add(txbNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "CadastroLocatario";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Novo Locatário";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.MaskedTextBox mktTel;
    }
}