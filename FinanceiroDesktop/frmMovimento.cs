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
    public partial class frmMovimento : Form
    {
        public frmMovimento()
        {
            InitializeComponent();
        }
        //================================================
        private void frmMovimento_Load(object sender, EventArgs e)
        {

            LimparCampos();
            Util.EstadoBotao(Util.EstadoTela.Novo, btn_salvar, btn_Excluir);
        }
        //================================================
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {

            }
        }
        //================================================
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //================================================
        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }
        //================================================
        private bool VerificarCampos()
        {
            bool ret = true;
            string campos = "";

            if (!dtp_Data.Checked)
            {
                ret = false;
                campos += " - Data, \n";
            }
            if (cb_tipoMovimento.SelectedIndex == -1)
            {
                ret = false;
                campos += " -  Tipo do Movimento, \n";
            }
            if (cb_Categoria.SelectedIndex ==-1)
            {
                ret = false;
                campos += " - Categoria, \n";
            }
            if (cb_Empresa.SelectedIndex ==-1)
            {
                ret = false;
                campos += " - Empresa, \n";
            }
            if (cb_Conta.SelectedIndex ==-1)
            {
                ret = false;
                campos += " - Conta, \n";
            }
            if (txtValor.Text.Trim() =="")
            {
                ret = false;
                campos += " - Valor";
            }
            if (!ret)
            {
                Util.ExibirMsg(campos);

            }
            return ret;
        }
        //================================================
        private void LimparCampos()
        {
            txtb_codigo.Clear();
            txtValor.Clear();
            txtb_Observacao.Clear();
            cb_Categoria.SelectedIndex = -1;
            cb_tipoMovimento.SelectedIndex = -1;
            cb_Empresa.SelectedIndex = -1;
            cb_Conta.SelectedIndex = -1;
            //datetimepiker - Data
            dtp_Data.Checked = false;
            dtp_Data.CustomFormat = " ";
            dtp_Data.Format = DateTimePickerFormat.Custom;
            //datetimepiker - DataInical
            dtp_inicial.Checked = false;
            dtp_inicial.CustomFormat = " ";
            dtp_inicial.Format = DateTimePickerFormat.Custom;

            //datetimepiker - DataFinal
            dtp_final.Checked = false;
            dtp_final.CustomFormat = " ";
            dtp_final.Format = DateTimePickerFormat.Custom;
        }
        //================================================
        private void dtp_Data_ValueChanged(object sender, EventArgs e)
        {
            dtp_Data.Checked = true;
            dtp_Data.CustomFormat = "dd/MM/yyyy";
        }

        private void dtp_inicial_ValueChanged(object sender, EventArgs e)
        {
            dtp_inicial.CustomFormat = "dd/MM/yyyy";
        }

        private void dtp_final_ValueChanged(object sender, EventArgs e)
        {
            dtp_final.CustomFormat = "dd/MM/yyyy";
        }
    }
}
