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
    public partial class frmList1 : Form
    {
        public frmList1()
        {
            InitializeComponent();
        }

        List<double> AumentoSalario = new List<double>();
        double soma;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double sal, aum,salfinal;

            sal = Convert.ToDouble(txtSal.Text.Trim()=="" ? 0 : Convert.ToDouble(txtSal.Text.Trim()));
            aum = Convert.ToDouble(txtAumento.Text.Trim() ==""? 0 : Convert.ToDouble(txtAumento.Text.Trim()));



            salfinal = CalcularAumento(sal, aum);
            AdicionarLista(salfinal);
            
            LimparCampos();
            CarregarLista();
        }

        
        private double CalcularAumento(double sal, double aum)
        {
            return sal += sal * aum/100;
        }
        private void AdicionarLista(double sal)
        {
            AumentoSalario.Add(sal);
        }
        private void LimparCampos()
        {
            txtAumento.Clear();
            txtSal.Clear();
        }
        private void CarregarLista()
        {
            lboxSalAu.DataSource = null;
            lboxSalAu.DataSource = AumentoSalario;
        }

        
    }
}
