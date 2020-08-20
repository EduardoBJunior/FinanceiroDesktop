using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaObj
{
    public partial class frmEx1 : Form
    {
        public frmEx1()
        {
            InitializeComponent();
        }
        List<ProdutoVo> lstProdutos = new List<ProdutoVo>();
        //==================================================

        private void frmEx1_Load(object sender, EventArgs e)
        {
            Estadoinicial();
        }

        //==================================================

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, descricao;
            double compra, venda;
            int cod;
            ProdutoVo produto;

            cod = Convert.ToInt32(txtCodigo.Text.Trim());

            if (VerificarCodigoRepetido(cod))
            {
                nome = txtNome.Text.Trim();
                descricao = txtDescricao.Text.Trim();
                compra = Convert.ToDouble(txtCompra.Text.Trim());
                venda = Convert.ToDouble(txtVenda.Text.Trim());

                produto = CriarProduto(nome, descricao, compra, venda, cod);
               
                AdicionarProduto(produto);
                Estadoinicial();
                LimparCampos();
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("Codigo ja existente, Digite outro");
            }

        }

        //============================================================
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome, des;
            double vcompra, vvenda;
            int cod, posLinha;

            posLinha = Convert.ToInt32(txtPosLinha.Text);
            cod = Convert.ToInt32(txtCodigo.Text);
            nome = txtNome.Text.Trim();
            des = txtDescricao.Text.Trim();
            vvenda = Convert.ToDouble(txtVenda.Text);
            vcompra = Convert.ToDouble(txtCompra.Text);

            //Modifica a Posicao da Lista
            lstProdutos[posLinha].Codigo = cod;
            lstProdutos[posLinha].Nome = nome;
            lstProdutos[posLinha].Venda = vvenda;
            lstProdutos[posLinha].Compra = vcompra;
            lstProdutos[posLinha].Descricao = des;

            CarregaGrid();
            Estadoinicial();

        }

        //============================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int posLinha;
            posLinha = Convert.ToInt32(txtPosLinha.Text);
            lstProdutos.RemoveAt(posLinha);

            CarregaGrid();
            Estadoinicial();
        }

        //============================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Estadoinicial();
        }
        
        //==================================================
        private ProdutoVo CriarProduto(string nome, string descricao, double compra, double venda, int cod)
        {
            ProdutoVo prod = new ProdutoVo();

            prod.Codigo = cod;
            prod.Nome = nome;
            prod.Descricao = descricao;
            prod.Compra = compra;
            prod.Venda = venda;

            return prod;
        }

        //==================================================
        private void AdicionarProduto(ProdutoVo prod)
        {
            lstProdutos.Add(prod);
        }

        //==================================================
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtVenda.Text = "";
            txtCompra.Text = "";
        }

        //==================================================
        private void CarregaGrid()
        {
            grdResult.DataSource = null;
            grdResult.DataSource = lstProdutos;
        }

        //==================================================
        private void txtPesProd_TextChanged(object sender, EventArgs e)
        {
            grdResult.DataSource = null;

            if (txtPesProd.Text.Trim() == "")
            {
                grdResult.DataSource = lstProdutos;
            }
            else
            {
                grdResult.DataSource = lstProdutos.Where(pespro => pespro.Descricao.Contains(txtPesProd.Text.Trim())).ToList();
            }
        }

        //============================================================
        private void btnPesq_Click(object sender, EventArgs e)
        {

            PesquisarValor();

        }

        //============================================================
        private void PesquisarValor()
        {
            double inicial, final;
            inicial = Convert.ToDouble(txtInicial.Text.Trim());
            final = Convert.ToDouble(txtFinal.Text.Trim());

            grdResult.DataSource = null;

            if (rdCompra.Checked)
            {
                grdResult.DataSource = lstProdutos.Where(prod => prod.Compra >= inicial && prod.Compra <= final).ToList();
            }
            else if (rdVenda.Checked)
            {
                grdResult.DataSource = lstProdutos.Where(prod => prod.Venda >= inicial && prod.Venda <= final).ToList();
            }

        }

        //============================================================
        private void grdResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdResult.RowCount > 0)
            {
                ProdutoVo objLinhaClicada = (ProdutoVo)grdResult.CurrentRow.DataBoundItem;

                txtCodigo.Text = objLinhaClicada.Codigo.ToString();
                txtDescricao.Text = objLinhaClicada.Descricao.ToString();
                txtCompra.Text = objLinhaClicada.Compra.ToString();
                txtVenda.Text = objLinhaClicada.Venda.ToString();
                txtNome.Text = objLinhaClicada.Nome;

                //Armazena o index da linha Clicada
                txtPosLinha.Text = e.RowIndex.ToString();

                //Ativa os buttons de edicao
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = true;
            }



        }

        //============================================================
        private void Estadoinicial()
        {
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            LimparCampos();
        }



        //============================================================
       
        private bool VerificarCodigoRepetido(int cod)
        {
            bool ret = true;
            for (int i = 0; i < lstProdutos.Count; i++)
            {
                if (cod == lstProdutos[i].Codigo)
                {

                    ret = false;
                    break;
                }

            }
            return ret;
        }

    }

}
