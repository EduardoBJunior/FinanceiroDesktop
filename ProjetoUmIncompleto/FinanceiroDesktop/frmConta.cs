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
    public partial class frmConta : Form
    {
        public frmConta()
        {
            InitializeComponent();
        }

        private void frmConta_Load(object sender, EventArgs e)
        {
            Util.ConfigurarGrid(DGV_contas);
            Util.EstadoBotao(Util.EstadoTela.Novo, btn_salvar, btn_Excluir);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {

            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }
        private void LimparCampos()
        {
            txtb_nomeBanco.Clear();
            txtb_agencia.Clear();
            txtb_codigo.Clear();
            txtb_Saldo.Clear();
            txtb_numConta.Clear();
            cb_tipoConta.SelectedIndex = -1;
        }

        private bool VerificarCampos()
        {
            bool  ret = true;
            string campos = "";
            
            if (txtb_nomeBanco.Text.Trim()=="")
            {
                ret = false;
                campos += "- Nome do Banco. \n";

            }

            if (txtb_agencia.Text.Trim() == "")
            {
                ret = false;
                campos += " - Agência.\n";
            }
            if (txtb_numConta.Text.Trim() =="")
            {
                ret = false;
                campos += " - Numero da Conta.\n";
            }
            if (txtb_Saldo.Text.Trim() =="")
            {
                ret = false;
                campos += " - Saldo.\n";
            }
            //if (cb_tipoConta.SelectedIndex == -1)
            //{
            //    ret = false;
            //    campos += " - Tipo Conta.";
            //}

            if (!ret)
            {
                Util.ExibirMsg(campos);

            }
            return ret;
        }

        private void gb_CadConta_Enter(object sender, EventArgs e)
        {

        }
    }
}
