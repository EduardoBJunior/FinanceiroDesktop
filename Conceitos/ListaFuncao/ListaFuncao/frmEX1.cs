using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaFuncao
{
    public partial class frmEX1 : Form
    {
        public frmEX1()
        {
            InitializeComponent();
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(VerificaCampos(txtN1.Text));
            double n2 = Convert.ToDouble(VerificaCampos(txtN2.Text));
            double n3 = Convert.ToDouble(VerificaCampos(txtN2.Text));
            double n4 = Convert.ToDouble(VerificaCampos(txtN2.Text));
            double n5 = Convert.ToDouble(VerificaCampos(txtN2.Text));
            

            double soma = SomarDoisNumeros(n1, n2);

            MessageBox.Show("A Total somado dos valores é igual a : " + soma);

            double div = DivisaoRestUm(soma, n3);

            MessageBox.Show("O total da soma dividido pelo numeor 3 é :" + div);

            double quad = CalcularQuadrado(soma, n4);

            MessageBox.Show("O Quadrado do numero é : " + quad);

            double sub = SubitrairValor(soma, n5);
            MessageBox.Show("A subitração  do numero é : " + sub);

            LimparCampos(txtN1.Text);
            LimparCampos(txtN2.Text);
            LimparCampos(txtN3.Text);
            LimparCampos(txtN4.Text);
            LimparCampos(txtN5.Text);
        }

        private string VerificaCampos(string campo)
        {
            
            if (campo == "")
            {
                MessageBox.Show("O Campo esta sem valor, preencha o campo");

            }
            
            return campo;
        }
        private double SomarDoisNumeros(double n1, double n2)
        {
            return n1 + n2;
        }

        private double DivisaoRestUm (double soma, double n3) {
            return soma / n3;
        }
        private double CalcularQuadrado(double soma, double n4 ) {
            return soma + (n4 * n4);
        }

        private double SubitrairValor(double soma, double n5)
        {
            return soma - n5;
        }

        private string LimparCampos(string n1)
        {
            return n1 = "";
        }
       
    }
}
