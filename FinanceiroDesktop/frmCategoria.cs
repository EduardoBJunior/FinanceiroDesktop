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
    public partial class frmCategoria: Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                //cria o obj que permitira usar as operaçoes d
                CategoriaDAO objdao = new CategoriaDAO();

                // criar o objeto que será valorizado suas propriedades de acordo a tela
                tb_categoria objCategoria = new tb_categoria();

                objCategoria.nome_categoria = txtNome.Text.Trim();
                objCategoria.id_usuario = Usuario.CodigoLogado;
                objCategoria.DataCadastro_cat = DateTime.Now;


                try
                {
                    if (txtCodigo.Text =="")
                    {
                        objdao.InserirCategoriaProc(objCategoria);
                    }
                    else
                    {

                        objCategoria.id_categoria = Convert.ToInt32(txtCodigo.Text);

                        objdao.AlterarCategoria(objCategoria);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.EstadoBotao(Util.EstadoTela.Novo,btnSalvar,btnExcluir);
            LimparCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntarAntesExclusao())
            {
                int codCategoria = Convert.ToInt32(txtCodigo.Text);
                try
                {
                    new CategoriaDAO().ExcluirCategoria(codCategoria);
                    LimparCampos();
                    CarregarGrid();
                    Util.EstadoBotao(Util.EstadoTela.Novo,btnSalvar,btnExcluir);

                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.ErroExclusao);
                }
            }
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();


        }

        private void EstadoBotaoInicial()
        {
            btnExcluir.Visible = false;
            btnSalvar.Text = "Cadastrar";
        }

        private bool VerificarCampos()
        {
            bool ret = true;
            string campos ="";
            if (txtNome.Text.Trim() =="")
            {
                ret = false;
                campos = "- Nome \n";
            }


            if (!ret)
            {
                MessageBox.Show("Preencha o(s) campo(s) Obrigatorio(s) \n\n"+ campos,"Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            return ret;
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(DGV_Categorias);
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
            LimparCampos();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            CategoriaDAO objdao = new CategoriaDAO();

            DGV_Categorias.DataSource = objdao.ConsultarCategoriaProc(Usuario.CodigoLogado);
            //oculta colunas
            //DGV_Categorias.Columns["id_categoria"].Visible = false;
            //DGV_Categorias.Columns["id_usuario"].Visible = false;
            //DGV_Categorias.Columns["tb_usuario"].Visible = false;
            //DGV_Categorias.Columns["tb_movimento"].Visible = false;

            Util.VisibilidadeColunaGrid(DGV_Categorias, "id_categoria", false);
            Util.VisibilidadeColunaGrid(DGV_Categorias, "id_usuario", false);
            Util.VisibilidadeColunaGrid(DGV_Categorias, "tb_usuario", false);
            Util.VisibilidadeColunaGrid(DGV_Categorias, "tb_movimento", false);

            

            //modifica  cabeçaljo das colunas

            //DGV_Categorias.Columns["nome_categoria"].HeaderText = "Categoria";
            //DGV_Categorias.Columns["DataCadastro_cat"].HeaderText = "Cadastrado em";

            Util.AlterarCabecalhoColuna(DGV_Categorias, "nome_categoria", "Categoria");
            Util.AlterarCabecalhoColuna(DGV_Categorias, "DataCadastro_cat", "Cadastrado em");
        }

        private void DGV_Categorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DGV_Categorias.RowCount > 0)
            {
                //recupera o obj clicado
                tb_categoria objLinhaClicado = (tb_categoria)DGV_Categorias.CurrentRow.DataBoundItem;

                //Pupula os campos de Edicao

                txtCodigo.Text = objLinhaClicado.id_categoria.ToString();
                txtNome.Text = objLinhaClicado.nome_categoria;

                //atualiza os botões
                Util.EstadoBotao(Util.EstadoTela.Alterar,btnSalvar,btnExcluir);
            }
        }
    }
}
