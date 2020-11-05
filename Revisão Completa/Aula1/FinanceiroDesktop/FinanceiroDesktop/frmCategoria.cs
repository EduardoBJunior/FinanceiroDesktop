using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace FinanceiroDesktop
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }
        //=============================================================================
        private void frmCategoria_Load(object sender, EventArgs e)
        {
            LimparCampos();
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
            Util.ConfiguracaoGridView(grdCategorias);
            CarregarGrid();
        }
        //=============================================================================
        private void txtNomeCateg_TextChanged(object sender, EventArgs e)
        {

        }
        //=============================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                //cria o obj que permitira usar as operações
                CategoriaDAO objdao = new CategoriaDAO();

                //Cria o obj que será valirizado susa propriedade de acordo  a tela 
                tb_categoria objCategoria = new tb_categoria();

                objCategoria.nome_categoria = txtbNomeCateg.Text.Trim();
                objCategoria.id_usuario= Usuario.codigoLogado;
                objCategoria.data_cadastro = DateTime.Now;

                try
                {
                    if (txtbCod.Text =="")
                    {
                        objdao.InsereriCategoriaProc(objCategoria);
                    }
                    else
                    {
                        objCategoria.id_categoria = Convert.ToInt32(txtbCod.Text);
                        objdao.AlterarCategoriaProc(objCategoria);
                    }
                    
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarGrid();
                }
                catch 
                {
                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }
            }
        }
        //=============================================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
        }
        //=============================================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntarAntesExclusao())
            {
                int codCategoria = Convert.ToInt32(txtbCod.Text);

                try
                {

                    new CategoriaDAO().ExcluirCategoriaProc(codCategoria);
                    LimparCampos();
                    CarregarGrid();
                    Util.EstadoBotao(Util.EstadoTela.Novo,btnSalvar,btnExcluir);
                }
                catch (Exception )
                {

                    Util.ExibirMsg(Util.TipoMsg.ErroExclusao);
                }
            }
        }
        //=============================================================================
        private void LimparCampos()
        {
            txtbCod.Clear();
            txtbNomeCateg.Clear();
           

        }
        //=============================================================================
        private void EstadoInicial()
        {

            btnExcluir.Visible = false;
            btnSalvar.Text = "Cadastrar";
        }
        //=============================================================================
        private void CarregarGrid()
        {
            CategoriaDAO objdao = new CategoriaDAO();

            grdCategorias.DataSource = objdao.ConsultarCategoria(Usuario.codigoLogado);

            grdCategorias.Columns["id_categoria"].Visible =  false;
            grdCategorias.Columns["id_usuario"].Visible = false;
            grdCategorias.Columns["tb_ususario"].Visible = false;
            grdCategorias.Columns["tb_movimento"].Visible = false;

            grdCategorias.Columns["nome_categoria"].HeaderText = "Categoria";
            grdCategorias.Columns["data_cadastro"].HeaderText = "Cadastrado em";
        }
        //=============================================================================
        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtbNomeCateg.Text.Trim() =="")
            {
                ret = false;
                campos = "- Nome";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }


            return ret;
        }

        private void grdCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //verifica se tem registro na grid

            if (grdCategorias.RowCount > 0)
            {
                //recupera o obj clicado() linhe
                tb_categoria objLinhaClicada = (tb_categoria)grdCategorias.CurrentRow.DataBoundItem;

                //popula os campos de edição
                txtbCod.Text = objLinhaClicada.id_categoria.ToString();
                txtbNomeCateg.Text = objLinhaClicada.nome_categoria;

                Util.EstadoBotao(Util.EstadoTela.Alterar, btnSalvar, btnExcluir);


            }
        }

        private void grdCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
