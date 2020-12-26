using DAO;
using Mensagens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceiroDesktop
{
    public partial class frmConsultarConta : Form
    {
        public frmConsultarConta()
        {
            InitializeComponent();
        }


        private void frmConsultarConta_Load(object sender, EventArgs e)
        {
            Util.ConfiguracaoGridView(grdContas);
            Util.ConfigurarCombo(cbContas, "nome_banco", "idconta");
            //Util.VisibilidadeColuna(grdContas, "objMov",false);
            CarregarCombos();

        }

        private void CarregarCombos()
        {
            cbContas.SelectedIndex = -1;

            List<tb_conta> lstContas = new ContaDAO().ConsultarContaProc(Usuario.codigoLogado);
            for (int i = 0; i < lstContas.Count; i++)
            {
                lstContas[i].nome_banco = lstContas[i].nome_banco;
                // " / " Banco :" + lstContas[i].nome_banco + "Agência-Numero Conta: " + lstContas[i].agencia_conta + "-" + lstContas[i].numero_conta + " Saldo : R$ " + lstContas[i].saldo_conta
            }


            cbContas.DataSource = lstContas;
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            //string nomeCotnta = ((DAO.tb_conta)cbContas.SelectedItem).nome_banco;

            //FiltrarContaNome(nomeCotnta);
            FiltrarMovimentacaoConta();
            txtTotal.Text =  SomarTotalPesquisa().ToString();
        }

        private decimal SomarTotalPesquisa()
        {
            decimal total = 0;
            for (int i = 0; i < grdContas.Rows.Count; i++)
            {
                total += Convert.ToDecimal(grdContas.Rows[i].Cells["Valor"].Value);

            }
            return total;

        }

        private void FiltrarContaNome(string nomeConta)
        {
            ContaDAO objdao = new ContaDAO();

            List<ContaVO> lstFiltro = objdao.PesquisarConta(Usuario.codigoLogado, dtpInicial.Value.Date, dtpFinal.Value.Date, nomeConta).ToList();

            grdContas.DataSource = lstFiltro;

            Util.VisibilidadeColuna(grdContas, "objConta", false);
        }

        private void FiltrarMovimentacaoConta()
        {
            MovimentoDAO tbObjMov = new MovimentoDAO();

            List<MovimentoVO> lstFiltro = tbObjMov.ConsultarMovimentoConta(Usuario.codigoLogado, dtpInicial.Value.Date, dtpFinal.Value.Date, ((tb_conta)cbContas.SelectedItem).id_conta).ToList();
            
            grdContas.DataSource = lstFiltro;
        }
    }
}
