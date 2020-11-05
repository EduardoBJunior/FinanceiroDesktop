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
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            Util.ConfiguracaoGridView(grdEmpresaCadastrada);
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
            LimparCampos();
            CarregarGrid();

        }
        //===========================================================================
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                EmpresaDAO objDao = new EmpresaDAO();

                tb_empresa objEmpresa = new tb_empresa();

                objEmpresa.nome_empresa = txtbNome.Text.Trim();
                objEmpresa.tel_empresa = txtMaskTelefone.Text.Trim();
                objEmpresa.endereco_empresa = txtbEndereco.Text.Trim();
                objEmpresa.site_empresa =txtSite.Text.Trim();
                objEmpresa.data_cadastro = DateTime.Now;
                objEmpresa.id_usuario = Usuario.codigoLogado;

                try
                {
                    if (txtbCod.Text =="")
                    {
                        objDao.InserirEmpresaProc(objEmpresa);
                    }
                    else
                    {
                        objEmpresa.id_empresa = Convert.ToInt32(txtbCod.Text);
                        objDao.AlterarEmpresaProc(objEmpresa);
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
        //===========================================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
        }
        //===========================================================================
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntarAntesExclusao())
            {
                int codEmpresa = Convert.ToInt32(txtbCod.Text);
                try
                {
                    new EmpresaDAO().ExcluirEmpresaProc(codEmpresa);
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
        //===========================================================================
        private void grdEmpresaCadastrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //===========================================================================
        private void LimparCampos()
        {
            txtbCod.Clear();
            txtbNome.Clear();
            txtbEndereco.Clear();
            txtMaskTelefone.Clear();
            txtSite.Clear();
        }//===========================================================================

        private void CarregarGrid()
        {
            EmpresaDAO objdao = new EmpresaDAO();



            grdEmpresaCadastrada.DataSource = objdao.ConsultarEmpresaProc(Usuario.codigoLogado);


            //Criado Controle generico na Util para poder simplificar a atribui;áo dos campos visiveis
            Util.VisibilidadeColuna(grdEmpresaCadastrada, "id_empresa",false);
            Util.VisibilidadeColuna(grdEmpresaCadastrada,"tb_movimento",false);
            Util.VisibilidadeColuna(grdEmpresaCadastrada,"tb_ususario",false);
            Util.VisibilidadeColuna(grdEmpresaCadastrada,"id_usuario",false);

            //a baixo esta o processo manual de alteração de visibilidade
            //grdEmpresaCadastrada.Columns["id_empresa"].Visible = false;
            //grdEmpresaCadastrada.Columns["tb_movimento"].Visible = false;
            //grdEmpresaCadastrada.Columns["tb_ususario"].Visible = false;
            //grdEmpresaCadastrada.Columns["id_usuario"].Visible = false;



            // criado controle generico para simplificar a alteração do nome da grid
            Util.AlterarCabecalhoColunaGrid(grdEmpresaCadastrada, "nome_empresa"   , "Nome");
            Util.AlterarCabecalhoColunaGrid(grdEmpresaCadastrada,"tel_empresa"     ,"Telefone");
            Util.AlterarCabecalhoColunaGrid(grdEmpresaCadastrada,"endereco_empresa","Endereço");
            Util.AlterarCabecalhoColunaGrid(grdEmpresaCadastrada,"site_empresa"    ,"Site");
            Util.AlterarCabecalhoColunaGrid(grdEmpresaCadastrada,"data_cadastro"   ,"Cadastrado em");

            //abaixo esta o processo manual 
            //grdEmpresaCadastrada.Columns["nome_empresa"     ].HeaderText = "Nome";
            //grdEmpresaCadastrada.Columns["tel_empresa"      ].HeaderText = "Telefone";
            //grdEmpresaCadastrada.Columns["endereco_empresa" ].HeaderText = "Endereço";
            //grdEmpresaCadastrada.Columns["site_empresa"     ].HeaderText = "Site";
            //grdEmpresaCadastrada.Columns["data_cadastro"    ].HeaderText = "Cadastrado em";

            



        }
        //===========================================================================
        private bool VerificarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtbNome.Text.Trim() =="")
            {
                ret = false;
                campos = " - Nome \n";
            }

            if (txtbEndereco.Text.Trim() =="")
            {
                ret = false;
                campos += " - Endereco \n";
            }
            if (txtMaskTelefone.Text.Trim() == "")
            {
                ret = false;
                campos += " - Telefone \n";
            }
            if (txtSite.Text.Trim()=="")
            {
                ret = false;
                campos += " - Site";
            }
            

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }
        //=========================================================================
        private void grdEmpresaCadastrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdEmpresaCadastrada.RowCount > 0)
            {
                tb_empresa ObjLinhaClicada = (tb_empresa)grdEmpresaCadastrada.CurrentRow.DataBoundItem;

                txtbCod.Text = ObjLinhaClicada.id_empresa.ToString();
                txtbNome.Text = ObjLinhaClicada.nome_empresa;
                txtbEndereco.Text = ObjLinhaClicada.endereco_empresa;
                txtMaskTelefone.Text = ObjLinhaClicada.tel_empresa;
                txtSite.Text = ObjLinhaClicada.site_empresa;

                Util.EstadoBotao(Util.EstadoTela.Alterar,btnSalvar,btnExcluir);
            }
        }

       
    }
}
