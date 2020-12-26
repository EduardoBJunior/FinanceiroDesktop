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
    public partial class frmCalcularMedia : Form
    {
        public frmCalcularMedia()
        {
            InitializeComponent();
        }

        List<double> lstMedia = new List<double>();
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4 ;

            n1 = Convert.ToDouble(txtn1.Text);
            n2 = Convert.ToDouble(txtn2.Text);
            n3 = Convert.ToDouble(txtn3.Text);
            n4 = Convert.ToDouble(txtn4.Text);

            lstMedia.Add(CalcularMedia(n1, n2, n3, n4));
            CarregarLista();
        }

        private double CalcularMedia(double n1, double n2, double n3,double n4)
        {
            return (n1 + n2 + n3 + n4) / 4;
        }
        private void CarregarLista()
        {
            lboxMedias.DataSource = null;
            lboxMedias.DataSource = lstMedia;
        }
            

        private void btnVer_Click(object sender, EventArgs e)
        {
            int rep = 0, ex = 0, apro =0;

            for (int i = 0; i < lstMedia.Count; i++)
            {
                if (lstMedia[i] >=0 && lstMedia[i]<=39)
                {
                    rep++;
                }
                else if (lstMedia[i] >=40 && lstMedia[i]<=59)
                {
                    ex++;
                }else if(lstMedia[i] > 60)
                {
                    apro++;
                    
                }
                txtRep.Text = Convert.ToString(rep);
                txtExam.Text = Convert.ToString(ex);
                txtAprov.Text = Convert.ToString(apro);
                txtAprov.Visible = true;
                txtExam.Visible = true;
                txtRep.Visible = true;
                lbExam.Visible = true;
                lblRep.Visible = true;
                lblAprov.Visible = true;
            }
        }
    }
}
