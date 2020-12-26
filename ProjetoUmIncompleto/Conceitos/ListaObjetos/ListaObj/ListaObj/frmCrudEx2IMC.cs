using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaObj
{
    public partial class frmCrudEx2IMC : Form
    {
        public frmCrudEx2IMC()
        {
            InitializeComponent();
            EstadoInicial();
        }

        List<CrudPessoaIMCVO> lstPessIMC = new List<CrudPessoaIMCVO>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, classificacao;
            double peso, altura, imc;
            int cod, posLinha;
            CrudPessoaIMCVO pessoaIMC;

            cod = Convert.ToInt32(txtCodigo.Text.Trim());

            if (VerificarCodigoRepetido(cod))
            {
                nome = txtNome.Text.Trim();
                peso = Convert.ToDouble(txtPeso.Text.Trim());
                altura = Convert.ToDouble(txtAltura.Text);

                imc = CalcularIMC(peso,altura);

                classificacao = VerificarSituacaoIMC(imc);

                pessoaIMC = CriarPeessIMC(cod,nome,peso,altura,imc,classificacao);

                AdicionarPessoaIMC(pessoaIMC);

                CarregarGrid();
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Codigo já existente");
            }
            


        }

        private bool VerificarCodigoRepetido(int cod)
        {
            bool ret = true;
            for (int i = 0; i < lstPessIMC.Count; i++)
            {
                if (cod == lstPessIMC[i].Cod)
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }

        //==========================================================================================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
        //==========================================================================================================================
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome,situ;
            double peso, altura, imc;
            int posLinha, Cod;

            txtCodigo.ReadOnly = false;

            posLinha = Convert.ToInt32(txtPosLinha.Text.Trim()) ;

            Cod = Convert.ToInt32(txtCodigo.Text.Trim());
         
           
                nome = txtNome.Text.Trim();
                peso = Convert.ToDouble(txtPeso.Text.Trim());
                altura = Convert.ToDouble(txtAltura.Text.Trim());

                imc = CalcularIMC(peso, altura);
                situ = VerificarSituacaoIMC(imc);

                lstPessIMC[posLinha].Cod = Cod;
                lstPessIMC[posLinha].Nome = nome;
                lstPessIMC[posLinha].Classificacao = situ;
                lstPessIMC[posLinha].Altura = altura;
                lstPessIMC[posLinha].Peso = peso;
                lstPessIMC[posLinha].IMC = imc;

                CarregarGrid();
                EstadoInicial();


        }
        //==========================================================================================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int posLinha;
            posLinha = Convert.ToInt32(txtPosLinha.Text);

            lstPessIMC.RemoveAt(posLinha);

            EstadoInicial();
        }
        //==========================================================================================================================
        private string VerificarSituacaoIMC(double imc)
        {
            string classificacao = "";

            
            if (imc <18.5)
            {
                classificacao = "MAGRZA";
            }
            else if (imc >=18.5 && imc <= 24.9)
            {
                classificacao = "NORMAL";
            }
            else if (imc >=25 && imc<=29.9)
            {
                classificacao = "SOBREPESO";
            }
            else if (imc >=30 && imc<=39.9)
            {
                classificacao = "OBESIDADE";
            }
            else
            {
                classificacao = "OBESIDADE GRAVE";
            }
            return classificacao ;
        }
        //==========================================================================================================================
        private double CalcularIMC(double peso, double altura)
        {
            double alturaq = altura * altura;
          
            double imc = peso / alturaq;

            return imc ;
        }
        //==========================================================================================================================
        private void CarregarGrid()
        {
            grdResultIMC.DataSource = null;
            grdResultIMC.DataSource = lstPessIMC;
        }
        //==========================================================================================================================
        private void EstadoInicial() 
        {
            LimparCampos();
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = true;
        }
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtPeso.Text = "";
            txtAltura.Text = "";
            
        }
        //==========================================================================================================================
        private CrudPessoaIMCVO CriarPeessIMC(int cod,string nome, double peso,double altura, double imc, string classificacao)
        {
            CrudPessoaIMCVO PessImc = new CrudPessoaIMCVO();
            
            PessImc.Cod = cod;
            PessImc.Nome = nome;
            PessImc.Peso = peso;
            PessImc.Altura = altura;
            PessImc.IMC = imc;
            PessImc.Classificacao =classificacao;

            return PessImc;
        }
        //==========================================================================================================================
        private void AdicionarPessoaIMC(CrudPessoaIMCVO pess)
        {
            lstPessIMC.Add(pess);
        }

        private void grdResultIMC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdResultIMC.RowCount > 0)
            {
                CrudPessoaIMCVO PessImcLinha = (CrudPessoaIMCVO)grdResultIMC.CurrentRow.DataBoundItem;

                txtCodigo.Text = PessImcLinha.Cod.ToString();
                txtNome.Text = PessImcLinha.Nome;
                txtAltura.Text = PessImcLinha.Altura.ToString();
                txtPeso.Text = PessImcLinha.Peso.ToString();

                txtPosLinha.Text = e.RowIndex.ToString();

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;


            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            double inicial, final;
            inicial = Convert.ToDouble(txtImcInicial.Text);
            final = Convert.ToDouble(txtImcFinal.Text);

            if (lstPessIMC.Count > 0)
            {
                for (int i = 0; i < lstPessIMC.Count; i++)
                {
                    if (inicial >= lstPessIMC[i].IMC && final <= lstPessIMC[i].IMC)
                    {
                        
                        grdResultIMC.DataSource = lstPessIMC[i];

                    }

                }
            }
            else
            {
                MessageBox.Show("Não exite cadastro");
            }

            
        }
    }
}
