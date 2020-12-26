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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEX1 frm = new frmEX1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEx2 frm = new frmEx2();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEx3 frm = new frmEx3();
            frm.ShowDialog();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            frmEx4 frm = new frmEx4();
            frm.ShowDialog();
        }
    }
}
