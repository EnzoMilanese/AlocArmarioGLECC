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
            this.btnConsultLoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultLoc
            // 
            this.btnConsultLoc.Location = new System.Drawing.Point(12, 12);
            this.btnConsultLoc.Name = "btnConsultLoc";
            this.btnConsultLoc.Size = new System.Drawing.Size(145, 23);
            this.btnConsultLoc.TabIndex = 0;
            this.btnConsultLoc.Text = "Consultar Locatários";
            this.btnConsultLoc.UseVisualStyleBackColor = true;
            this.btnConsultLoc.Click += new System.EventHandler(this.btnCadastrarLoc_Click);
            // 
            // ConsultaArmarioAvanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultLoc);
            this.Name = "ConsultaArmarioAvanc";
            this.Text = "Alocação de Armários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultLoc;
    }
}