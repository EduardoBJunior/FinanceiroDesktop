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
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }
        List<double> ListaPar = new List<double>();
        List<double> ListaImpar = new List<double>();

        private void button1_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtNum.Text.Trim());
            CalcularPar(numero);
            LimparCampos();
            CarregarLista();

        }
        private void AdicionarPar(double num)
        {
            ListaPar.Add(num);
        }

        private void AdicionarImpar(double num)
        {
            ListaImpar.Add(num);
        }

        private void CalcularPar(double num)
        {
            if (num%2==0)
            {
                AdicionarPar(num);
            }
            else
            {
                AdicionarImpar(num);
            }
            
        }
        private void CarregarLista()
        {
            lboxPar.DataSource = null;
            lboxPar.DataSource = ListaPar;
            lboxImpar.DataSource = null;
            lboxImpar.DataSource = ListaImpar;
        }
        private void LimparCampos()
        {
            txtNum.Clear();
        }
    }
}
