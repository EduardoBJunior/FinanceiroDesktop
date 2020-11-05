using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;
using DAO;

namespace FinanceiroDesktop
{
    public partial class frmMovimento : Form
    {
        public frmMovimento()
        {
            InitializeComponent();
        }

        private void frmMovimento_Load(object sender, EventArgs e)
        {
            Util.ConfiguracaoGridView(grdLancamento);
            Util.ConfigurarCombo(cbCategoria, "nome_categoria", "id_categoria");
            Util.ConfigurarCombo(cbEmpresa, "nome_empresa", "id_empresa");
            Util.ConfigurarCombo(cbConta, "numero_conta", "id_conta");
            CarregarCombos();
            LimparCampos();
            Util.EstadoBotao(Util.EstadoTela.Novo,btnSalvar,btnExcluir);

            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (Util.PerguntarAntesExclusao())
            {
                int idMov = Convert.ToInt32(txtCod.Text);
                decimal valor = Convert.ToDecimal(txtValor.Text);
                int tipo = cbTipoLanc.SelectedIndex;
                int idCon = Convert.ToInt32(cbConta.SelectedValue);

                try
                {
                    new MovimentoDAO().ExcluirMovimento(idMov, tipo, valor,idCon);

                    Util.LimparCamposGenerico(grpMovi);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    FiltrarMovimento();
                    LimparCampos();
                    CamposTravar(true);
                    CarregarCombos();

                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.ErroExclusao);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CamposTravar(true);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_movimento ObjMov = new tb_movimento();
                MovimentoDAO objDao = new MovimentoDAO();

                ObjMov.id_usuario = Usuario.codigoLogado;
                ObjMov.data_movimento = dtpDataLancameto.Value.Date;
                ObjMov.tipo_movimento = Convert.ToInt16(cbTipoLanc.SelectedIndex);
                ObjMov.valor_movimento = Convert.ToDecimal(txtValor.Text);
                ObjMov.id_categoria = Convert.ToInt32(cbCategoria.SelectedValue);
                ObjMov.id_empresa = Convert.ToInt32(cbEmpresa.SelectedValue);
                if (cbConta.SelectedIndex != -1)
                {
                    ObjMov.id_conta = Convert.ToInt32(cbConta.SelectedValue);
                }
                
                ObjMov.ob_movimento = txtbObservacao.Text.Trim();
                ObjMov.data_cadastro = DateTime.Now;
                try
                {
                    //entiti
                    //objDao.LancarMovimento(ObjMov);
                    //LimparCampos();
                    //Util.ExibirMsg(Util.TipoMsg.Sucesso);

                    //usando proc
                    int ret = objDao.LancarMovimentoProc(ObjMov);
                    
                    if (ret ==1)
                    {
                        LimparCampos();
                        Util.ExibirMsg(Util.TipoMsg.Sucesso);
                        CarregarCombos();
                        
                    }
                    else
                    {
                        Util.ExibirMsg(Util.TipoMsg.Erro);
                    }
                }
                catch 
                {

                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FiltrarMovimento();
           
        }

        private void FiltrarMovimento()
        {
            MovimentoDAO objdao = new MovimentoDAO();
            List<MovimentoVO> lstFiltro = objdao.ConsultarMovimentoaProc(Usuario.codigoLogado, dtpIniPes.Value.Date, dtpFinalPes.Value.Date, Convert.ToInt16(cbTpMovPes.SelectedIndex));

            grdLancamento.DataSource = lstFiltro;
            Util.VisibilidadeColuna(grdLancamento, "ObjMov", false);
        }
        private void LimparCampos()
        {
            //cbTipoLanc.SelectedIndex = -1;
            //cbEmpresa.SelectedIndex = -1;
            //cbCategoria.SelectedIndex = -1;
            //cbConta.SelectedIndex = -1;
            Util.LimparCamposGenerico(gbLancamento);
            btnExcluir.Visible = false;
            btnSalvar.Enabled = true;
            

        }
        private void CarregarCombos()
        {
            cbTpMovPes.SelectedIndex = 2;
            
            cbCategoria.DataSource = new CategoriaDAO().ConsultarCategoriaProc(Usuario.codigoLogado);

            cbEmpresa.DataSource = new EmpresaDAO().ConsultarEmpresaProc(Usuario.codigoLogado);

            //cbConta.DataSource = new ContaDAO().ConsultarContaProc(Usuario.codigoLogado);

           

            List<tb_conta> lstContas = new ContaDAO().ConsultarContaProc(Usuario.codigoLogado);
            for (int i = 0; i < lstContas.Count; i++)
            {
                lstContas[i].numero_conta = "Banco :" + lstContas[i].nome_banco + " / " + "Agência-Numero Conta: " + lstContas[i].agencia_conta + "-" + lstContas[i].numero_conta + " Saldo : R$ " + lstContas[i].saldo_conta;
            }

            cbConta.DataSource = lstContas ;
        }
        private bool ValidarCampos()
        {
            string campos = "";
            bool ret = true;

            if (cbCategoria.SelectedIndex == -1)
            {
                ret = true;
                campos += " - Categoria, \n";
            }
            if (cbConta.SelectedIndex == -1)
            {
                ret = true;
                campos += " - Conta, \n";
            }
            if (cbEmpresa.SelectedIndex == -1)
            {
                ret = true;
                campos += " - Empresa, \n";
            }
            if (cbTipoLanc.SelectedIndex ==-1)
            {
                ret = true;
                campos += " - Tipo Empresa";
            }
            if (txtValor.Text.Trim()=="")
            {
                ret = true;
                campos += " - Valor";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            
            return ret;
        }
        private void gbLancamento_Enter(object sender, EventArgs e)
        {

        }
        private void CamposTravar(bool acao)
        {
            dtpDataLancameto.Enabled = acao;
            cbCategoria.Enabled = acao;
            cbEmpresa.Enabled = acao;
            cbConta.Enabled = acao;
            cbTipoLanc.Enabled = acao;
            txtbObservacao.Enabled = acao;
            txtValor.Enabled = acao;
        }

        private void grdLancamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdLancamento.RowCount >0)
            {
                MovimentoVO objlinha = (MovimentoVO)grdLancamento.CurrentRow.DataBoundItem;

                //cria uma variavel do tipo tb_movimento para subir as  infp
                tb_movimento objMovEditar = objlinha.objMov;

                //subir as info

                txtCod.Text = objMovEditar.id_movimento.ToString();
                txtbObservacao.Text = objMovEditar.ob_movimento;
                txtValor.Text = objMovEditar.valor_movimento.ToString();
                cbCategoria.SelectedValue = objMovEditar.id_categoria;
                cbEmpresa.SelectedValue = objMovEditar.id_empresa;
                cbConta.SelectedValue = objMovEditar.id_conta;
                cbTipoLanc.SelectedIndex = objMovEditar.tipo_movimento;
                dtpDataLancameto.Value = objMovEditar.data_movimento;

                btnSalvar.Enabled = false;
                btnExcluir.Visible = true;
                CamposTravar(false);

            }
        }

     
    }
}
