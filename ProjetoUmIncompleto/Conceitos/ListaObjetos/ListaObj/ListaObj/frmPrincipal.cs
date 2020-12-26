using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaObj
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnLstObjeto_Click(object sender, EventArgs e)
        {
            ListaFrmObjExemplo frm = new ListaFrmObjExemplo();
            frm.ShowDialog();

        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            frmEx1 frm = new frmEx1();
            frm.ShowDialog();

        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            Ex2 frm = new Ex2();
            frm.ShowDialog();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            frmEx3 frm = new frmEx3();
            frm.ShowDialog();
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            frmCrudEx1 frm = new frmCrudEx1();
            frm.ShowDialog();
        }

        private void btnCrude2_Click(object sender, EventArgs e)
        {
            frmCrudEx2IMC frm = new frmCrudEx2IMC();
            frm.ShowDialog();

        }
    }
}
