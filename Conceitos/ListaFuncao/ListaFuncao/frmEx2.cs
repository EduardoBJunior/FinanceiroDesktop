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
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }
        double n1,n2,n3, n4, n5;
        double soma;
        private void btnVerifica_Click(object sender, EventArgs e)
        {
            VerificarSenha(txtSenha.Text.Trim());
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            soma = SomarDoisNumeros(n1,n2);
            if (txtN1.Text.Trim() != "" && txtN2.Text.Trim() != "")
            {
               
                MessageBox.Show("O resultado da soma é: "+soma);
                grbSoma.Enabled = false;
                btnSoma.Enabled = false;
                grbMedia.Enabled = true;
                txtN3.Focus();
            }
            else
            {
                MessageBox.Show("Digite os dois numeros");
                txtN1.Focus();
                return;
            }
        }
        private void btnMedia_Click(object sender, EventArgs e)
        {
            n3 = Convert.ToDouble(txtN3.Text);
            n4 = Convert.ToDouble(txtN4.Text);
            n5 = Convert.ToDouble(txtN5.Text);

            if (txtN3.Text != "" && txtN4.Text != "" && txtN5.Text != "")
            {
                MessageBox.Show("O valor da Média é: "+Convert.ToString(CalcularMedia(n1,n2, n3, n4, n5)));
            }
        }
        public void VerificarSenha(string senha)
        {
            if (senha != "44332")
            {
                MessageBox.Show("Digite a Senha correta '44332'");
            }
            else
            {
                MessageBox.Show("Senha Correta");
                grbSoma.Enabled = true;
                txtSenha.Enabled = false;
                btnVerifica.Enabled = false;
            }
            
        }

        public double SomarDoisNumeros(double n1, double n2)
        {
            return n1 + n2;
        }

      
        public double CalcularMedia(double n1,double n2, double n3, double n4, double n5)
        {
            return ((n1 + n2 + n3 + n4 +n5) / 5);
        }

        
    }
}
