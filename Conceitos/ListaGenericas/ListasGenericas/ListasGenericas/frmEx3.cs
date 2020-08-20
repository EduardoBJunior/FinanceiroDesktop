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
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }
        List<string> ListNome = new List<string>();
        List<double> ListImc = new List<double>();
        List<string> ListSituacao = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            double peso, altura,IMCF;
            string nome;

            peso = Convert.ToDouble(txtPeso.Text.Trim());
            altura = double.Parse(txtAltura.Text.Trim());
            nome = txtNome.Text.Trim();

            VerificarCampos();
            IMCF = CalcularIMC(peso, altura);
            VerificarSituacao(IMCF);
            AdicionarNome(nome);
            AtualizarListas();
            LimparCampos();




        }
        private void VerificarCampos()
        {
            if (txtAltura.Text.Trim() =="" || txtNome.Text.Trim()=="" ||txtPeso.Text.Trim() =="")
            {
                MessageBox.Show("Preencha Todos os Campos!");
                return;
            }
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtPeso.Clear();
            txtAltura.Clear();
        }

        private double CalcularIMC(double peso, double altura)
        {
            double imc = peso / (altura * altura);
            AdicinarListaIMC(imc);
            return imc;
        }

        private void VerificarSituacao(double imc)
        {
            if(imc <= 18.4){
               ListSituacao.Add("Abaixo do Peso!");
                
            }else if(imc >=18.5 && imc <= 24.9)
            {
                ListSituacao.Add("Peso Normal");
            }else if(imc >=25 && imc <= 29.99)
            {
                ListSituacao.Add("Acima do Peso");
            }else if( imc >=30 && imc<= 34.99)
            {
                ListSituacao.Add("Obesidade I");
            }else if(imc >=35 && imc <= 39.99)
            {
                ListSituacao.Add("Obesidade II");
            }else if(imc >= 40)
            {
                ListSituacao.Add("Obesidade III");
            }
        }

        private void AdicinarListaIMC(double imc)
        {
            ListImc.Add(imc);
        }
        private void AdicionarNome(string nome) {
            ListNome.Add(nome);
        }

        private void AtualizarListas()
        {
            lboxIMC.DataSource = null;
            lboxNome.DataSource = null;
            lboxSitu.DataSource = null;
            lboxIMC.DataSource = ListImc;
            lboxNome.DataSource = ListNome;
            lboxSitu.DataSource = ListSituacao;
        }

    }
}
