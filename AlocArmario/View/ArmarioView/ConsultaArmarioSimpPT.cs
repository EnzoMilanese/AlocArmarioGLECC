using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AlocArmarioPrototipo
{
    public partial class ConsultaArmarioSimp : Form
    {
        public ConsultaArmarioSimp()
        {
            InitializeComponent();
        }

        private void btnAlugar_Click(object sender, EventArgs e)
        {          
        }

        private void btnDestituir_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(0, 192, 0);

            lblStatus.Text = "Vago";
            lblStatus.ForeColor = Color.FromArgb(0, 192, 0);

            lblDataNome.Text = "...";
            lblDataPront.Text = "...";
            lblDataVenc.Text = "...";
            

            btnAlugar.Visible = true;
            btnCertific.Visible = false;
            btnDestituir.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblPlaceholder.Visible = false;

            lblStatus.Text = "Alugado";
            lblStatus.ForeColor = Color.FromArgb(192, 0, 0);

            lblDataCod.Text = "BAT1001";
            lblDataBloc.Text = "Batcaverna 1";
            lblDataNum.Text = "1";

            lblDataNome.Text = "Enzo Milanese";
            lblDataPront.Text = "1550543";
            lblDataVenc.Text = "01/01/2019";

            btnAlugar.Visible = false;
            btnCertific.Visible = true;
            btnDestituir.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lblPlaceholder.Visible = false;

            lblStatus.Text = "Vago";
            lblStatus.ForeColor = Color.FromArgb(0, 192, 0);

            lblDataCod.Text = "BAT1005";
            lblDataBloc.Text = "Batcaverna 1";
            lblDataNum.Text = "5";

            lblDataNome.Text = "...";
            lblDataPront.Text = "...";
            lblDataVenc.Text = "...";

            btnAlugar.Visible = true;
            btnCertific.Visible = false;
            btnDestituir.Visible = false;
        }
    }
}
