namespace AlocArmario.View.Cadastro
{
    partial class CadastroSecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroSecao));
            btnCancelar = new System.Windows.Forms.Button();
            btnCadastrar = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            txbDescricao = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txbNome = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            txbId = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(218, 156);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += new System.EventHandler(btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new System.Drawing.Point(137, 156);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new System.Drawing.Size(75, 23);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += new System.EventHandler(btnCadastrar_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(133, 28);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(163, 24);
            label5.TabIndex = 19;
            label5.Text = "Cadastrar Seção";
            // 
            // txbDescricao
            // 
            txbDescricao.AcceptsReturn = true;
            txbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbDescricao.Location = new System.Drawing.Point(116, 107);
            txbDescricao.Margin = new System.Windows.Forms.Padding(0);
            txbDescricao.Name = "txbDescricao";
            txbDescricao.Size = new System.Drawing.Size(260, 22);
            txbDescricao.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(43, 107);
            label1.Margin = new System.Windows.Forms.Padding(0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 16);
            label1.TabIndex = 10;
            label1.Text = "Descrição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(152, 73);
            label2.Margin = new System.Windows.Forms.Padding(0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 16);
            label2.TabIndex = 20;
            label2.Text = "Nome:";
            // 
            // txbNome
            // 
            txbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbNome.Location = new System.Drawing.Point(203, 73);
            txbNome.Name = "txbNome";
            txbNome.Size = new System.Drawing.Size(173, 22);
            txbNome.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(57, 73);
            label3.Margin = new System.Windows.Forms.Padding(0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 16);
            label3.TabIndex = 21;
            label3.Text = "Número:";
            // 
            // txbId
            // 
            txbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            txbId.Location = new System.Drawing.Point(116, 73);
            txbId.Name = "txbId";
            txbId.Size = new System.Drawing.Size(33, 22);
            txbId.TabIndex = 22;
            // 
            // CadastroSecao
            // 
            AcceptButton = btnCadastrar;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 209);
            Controls.Add(txbId);
            Controls.Add(label3);
            Controls.Add(txbNome);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(label5);
            Controls.Add(txbDescricao);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            Name = "CadastroSecao";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Nova Seção";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbId;
    }
}