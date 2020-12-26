using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaFuncao
{
    public partial class frmEx4 : Form
    {
        public frmEx4()
        {
            InitializeComponent();
            txtResp2.Visible = false;
            btn2.Visible = false;
            lbPerg2.Visible = false;
        }
        string resp1 = "stack";
        string resp2 = "double";

        private void button1_Click(object sender, EventArgs e)
        {
            VerificarResposta1(txtResp1.Text.Trim());
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            VerificarResposta2(txtResp2.Text.Trim());
        }
        public void VerificarResposta1(string res)
        {
            if (res == resp1)
            {
                MessageBox.Show("Parabens você acertou!!");
                txtResp2.Visible = true;
                btn2.Visible = true;
                lbPerg2.Visible = true;
                lbPerg1.Enabled = false;
                button1.Enabled = false;
                txtResp1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Voce Errou tente novamente!");
                return;
            }

        }
        public  void VerificarResposta2(string res)
        {
            if (res == resp2)
            {
                MessageBox.Show("Parabéns você Acertou !!");
                lbPerg2.Enabled = false;
                txtResp2.Enabled = false;
                btn2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Você Errou Tenten novamente");
                return;
            }
        }
    }
}
