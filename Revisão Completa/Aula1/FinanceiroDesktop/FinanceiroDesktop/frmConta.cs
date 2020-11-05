using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace FinanceiroDesktop
{
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }
        //==============================================================
        private void frmConta_Load(object sender, EventArgs e)
        {
            LimparCampos();
            Util.EstadoBotao(Util.EstadoTela.Novo,btnSalvar,btnExcluir);
            Util.ConfiguracaoGridView(grdContaCadastrada);

            CarregarGridVO();

        }

        //==============================================================
            
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                //cria o obj dao
                ContaDAO objdao = new ContaDAO();

                //cria o obj que ira receber as informações da tela - nocaso a tabela do banco

                tb_conta objConta = new tb_conta();

                objConta.nome_banco = txtbNomeBanco.Text.Trim();
                objConta.agencia_conta = txtbAgencia.Text.Trim();
                objConta.numero_conta = txtNumeroConta.Text.Trim();
                objConta.tipo_conta =Convert.ToInt16(cbTipoConta.SelectedIndex);
                objConta.saldo_conta = decimal.Parse(txtbSaldoAtual.Text.Trim());
                objConta.id_usuario = Usuario.codigoLogado;
                objConta.data_cadastro = DateTime.Now;

                try
                {
                    if (txtbCod.Text == "")
                    {
                        objdao.InserirContaProc(objConta);
                    }
                    else
                    {
                        objConta.id_conta = Convert.ToInt32(txtbCod.Text);
                        objdao.AlterarContaProc(objConta);
                    }

                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    LimparCampos();
                    CarregarGridVO();
                    Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }

            }
        }

        //==============================================================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.LimparCamposGenerico(gbGerConta);
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
        }

        //==============================================================

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntarAntesExclusao())
            {
                int CodConta = Convert.ToInt32(txtbCod.Text);

                try
                {
                    new ContaDAO().ExcluirContaProc(CodConta);

                    LimparCampos();
                    CarregarGridVO();
                    Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
                   
                }
                catch (Exception)
                {

                    Util.ExibirMsg(Util.TipoMsg.ErroExclusao);
                }
              
            }
        }

        //==============================================================

        private void LimparCampos()
        {
            txtbAgencia.Clear();
            txtbCod.Clear();
            txtbNomeBanco.Clear();
            txtbSaldoAtual.Clear();
            txtNumeroConta.Clear();
            cbTipoConta.SelectedIndex = -1;
            
        }

        //==============================================================

        private bool VerificarCampos()
        {
            bool ret = true;
            string campos = "";

            if(txtbAgencia.Text.Trim() == "")
            {
                ret = false;
                campos += " - Agência \n";
            }
            if (txtbNomeBanco.Text.Trim() =="")
            {
                ret = false;
                campos += " - Nome Banco \n";

            }
            if (txtbSaldoAtual.Text.Trim() == "")
            {
                ret = false;
                campos += " - Saldo Atual\n";
            }
            if (txtNumeroConta.Text.Trim() =="")
            {
                ret = false;
                campos += " - Numero da Conta\n";
            }
            if (cbTipoConta.SelectedIndex == -1)
            {
                ret = false;
                campos += " - Tipo da Conta";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }

        //==============================================================

        public void CarregarGridVO()
        {
            ContaDAO objDao = new ContaDAO();

            List<ContaVO> lista = objDao.ConsultarContaVO(Usuario.codigoLogado);

            grdContaCadastrada.DataSource = lista;
        }
        public void CarregarGrid()
        {
            
            //INSTANCIA O OBJ DAO
            ContaDAO objdao = new ContaDAO();

            // alterar o campo tipo para aparecer a descrição
            List<tb_conta> lista = objdao.ConsultarContaProc(Usuario.codigoLogado);
         
            // a recuperação para a tela da erro 
            for (int i = 0; i < lista.Count; i++)
            {
                //lista[i].tipo_conta = lista[i].tipo_conta == Convert.ToInt16(1) ? "Corrente" : "Poupança";
            }

            grdContaCadastrada.DataSource = lista;

            //grdContaCadastrada.DataSource = objdao.ConsultarContaProc(Usuario.codigoLogado);
            //alteraçao dos campos da GRid

            grdContaCadastrada.Columns["id_conta"].Visible = false;
            grdContaCadastrada.Columns["id_usuario"].Visible = false;
            grdContaCadastrada.Columns["tb_ususario"].Visible = false;
            grdContaCadastrada.Columns["tb_movimento"].Visible = false;
           
            
            grdContaCadastrada.Columns["nome_banco"].HeaderText = "Nome";
            grdContaCadastrada.Columns["agencia_conta"].HeaderText = "Agência";
            grdContaCadastrada.Columns["numero_conta"].HeaderText = "Numero";
            grdContaCadastrada.Columns["saldo_conta"].HeaderText = "Saldo";
            grdContaCadastrada.Columns["tipo_conta"].HeaderText = "Tipo";
            grdContaCadastrada.Columns["data_cadastro"].HeaderText = "Cadastrado em";


           
        }

        private void grdContaCadastrada_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdContaCadastrada.RowCount > 0)
            {
                ContaVO objLinha = (ContaVO)grdContaCadastrada.CurrentRow.DataBoundItem;

                tb_conta objContaEditar = objLinha.objConta;

                txtbCod.Text = objContaEditar.id_conta.ToString();
                txtbNomeBanco.Text = objContaEditar.nome_banco;
                txtbAgencia.Text = objContaEditar.agencia_conta;
                txtNumeroConta.Text = objContaEditar.numero_conta;
                txtbSaldoAtual.Text = objContaEditar.saldo_conta.ToString();
                cbTipoConta.SelectedIndex = objContaEditar.tipo_conta;


                //tb_conta ObjLinhaClicada = (tb_conta)grdContaCadastrada.CurrentRow.DataBoundItem;

                //txtbCod.Text = ObjLinhaClicada.id_conta.ToString();
                //txtbNomeBanco.Text = ObjLinhaClicada.nome_banco;
                //txtbAgencia.Text = ObjLinhaClicada.agencia_conta;
                //txtNumeroConta.Text = ObjLinhaClicada.numero_conta;
                //txtbSaldoAtual.Text = ObjLinhaClicada.saldo_conta.ToString();
                //cbTipoConta.SelectedIndex = Convert.ToInt32(ObjLinhaClicada.tipo_conta);

                Util.EstadoBotao(Util.EstadoTela.Alterar, btnSalvar, btnExcluir);

            }
        }
    }
}
