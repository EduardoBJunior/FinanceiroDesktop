using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasGenericas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmList1 frm = new frmList1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEx2 frm = new frmEx2();
            frm.ShowDialog();
        }
        private void CarregarLista()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEx3 frm = new frmEx3();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmEntradaSaida frm = new frmEntradaSaida();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmEX5 frm = new frmEX5();
            frm.ShowDialog();
        }
    }
}
