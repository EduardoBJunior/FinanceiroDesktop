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
    public partial class frmSalario : Form
    {
        public frmSalario()
        {
            InitializeComponent();
        }

        List<double> lstSalarioFinal = new List<double>();
        List<double> lstSeparar = new List<double>();
        string ultpesq, rdvalor;
        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double salario = Convert.ToDouble(txtSalario.Text.Trim());
            double percent = Convert.ToDouble(txtAumento.Text.Trim());
            double salariofinal;
            salariofinal= CalcularNovoSalario(salario,percent);

            PopularLista(salariofinal);
            CarregarListas();
            LimparCampos();

        }

        private void btnSep_Click(object sender, EventArgs e)
        {
            if (ultpesq != txtPes.Text.Trim() || rdvalor != rdvalor)
            {

            }
            
            Pesquisar(txtPes.Text.Trim());
            LimparCampos();


            
            
            
        }
        //==============================================================
        private double CalcularNovoSalario(double salario, double aumento)
        {
            return salario + (salario * (aumento/100));
        }
        //==============================================================
        private void PopularLista(double salarioFinal)
        {
            lstSalarioFinal.Add(salarioFinal);
        }
        //==============================================================
        private void CarregarListas()
        {
            lstboxSalrio.DataSource = null;
            lstboxFiltro.DataSource = null;

            lstboxFiltro.DataSource = lstSeparar;
            lstboxSalrio.DataSource = lstSalarioFinal;
        }
        //==============================================================
        private void Pesquisar(string valor)
        {
            ultpesq = txtPes.Text;

          

            if (rdMaior.Checked)
            {
                lstSeparar.Clear();
                for (int qtdLista = 0; qtdLista < lstSalarioFinal.Count;qtdLista++)
                {
                    if (lstSalarioFinal[qtdLista] > Convert.ToDouble(valor))
                        {
                            lstSeparar.Add(lstSalarioFinal[qtdLista]);
                        CarregarListas();
                        }
                }

            }
             if (rdMenor.Checked)
            {
                lstSeparar.Clear();
                for (int qtdLista = 0; qtdLista < lstSalarioFinal.Count; qtdLista++)
                {
                    if (lstSalarioFinal[qtdLista] < Convert.ToDouble(valor))
                    {
                        lstSeparar.Add(lstSalarioFinal[qtdLista]);
                        CarregarListas();
                    }
                }

            }

            
            
            
            
        }
        //==============================================================
        private void LimparCampos()
        {
            txtAumento.Text = "";
            txtSalario.Text = "";

            txtPes.Text = "";
        }


    }
}
   
