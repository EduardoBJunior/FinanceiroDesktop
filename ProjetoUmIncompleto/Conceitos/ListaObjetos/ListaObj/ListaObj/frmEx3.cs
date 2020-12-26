using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaObj
{
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();
        }
        List<PessoaIMCVO> lstIMC = new List<PessoaIMCVO>();
      

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome, peso, altura, situacao;
            double vlrimc;
            PessoaIMCVO pessoaIMC;

            nome = txtNome.Text.Trim();
            peso = txtPeso.Text.Trim();
            altura = txtAltura.Text.Trim();

            vlrimc =CalcularIMC(Convert.ToDouble(peso), Convert.ToDouble(altura));
            situacao = VerificarStatusIMC(vlrimc);

            pessoaIMC = CriarPessoaIMC(nome, peso, altura,situacao,vlrimc);

            AdicionarIMC(pessoaIMC);

            CarregarGrid();
            LimparCampos();

        }
        private string VerificarStatusIMC(double imc)
        {
            string situacao;

            if (imc <= 18.5)
            {
                situacao = "Abaixo do Peso";
            }
            else if (imc >= 18.5 && imc <=24.9)
            {
                situacao = "Peso Normal";
            }
            else if (imc >= 25 && imc <=29.9)
            {
                situacao = "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                situacao = "Obesidade Grau 1";
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                situacao = "Obesidade Grau 2";
            }
            else
            {
                situacao = "Obesidade Grau 3";
            }

            return situacao;
        }

        private double CalcularIMC(double altura, double peso)
        {
            double imc = (peso / (altura * altura));
            return imc;
        }

        private PessoaIMCVO CriarPessoaIMC(string nome,string peso,string altura,string situacao,double vlrimc) {
            PessoaIMCVO vo = new PessoaIMCVO();

            vo.Nome = nome;
            vo.Peso = peso;
            vo.Altura = altura;
            vo.IMC = situacao;
            vo.vlrImc = vlrimc;

            return vo;
        }
        private void AdicionarIMC(PessoaIMCVO vo)
        {
            lstIMC.Add(vo);
        } 

        private void CarregarGrid()
        {
            dgvIMC.DataSource = null;
            dgvIMC.DataSource = lstIMC;
        }

        private void LimparCampos()
        {
            txtAltura.Text = "";
            txtNome.Text = "";
            txtPeso.Text = "";
        }
    }
}
