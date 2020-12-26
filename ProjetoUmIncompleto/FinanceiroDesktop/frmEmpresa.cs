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
            Util.ConfigurarGrid(DGV_Empresas);
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
               
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void DGV_Empresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtb_nomeEmpresa.Clear();
            txtb_telefone.Clear();
            txtb_endereco.Clear();
            txtb_site.Clear();
        }
        private bool VerificarCampos()
        {
            bool ret = true;
            string campos = "";

            //if (txtCodigo.Text.Trim() =="")
            //{
            //    ret = false;
            //    campos += " - Código.\n";
            //}
            if (txtb_nomeEmpresa.Text.Trim() =="")
            {
                ret = false;
                campos +=" - Nome.\n";
            }
            if (txtb_telefone.Text.Trim() =="")
            {
                ret = false;
                campos += " - Telefone.\n";
            }
            if (txtb_endereco.Text.Trim() =="")
            {
                ret = false;
                campos += " - Endereço. \n";
            }
            if (txtb_site.Text.Trim()=="")
            {
                ret = false;
                campos += " - Site.";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }


            return ret;
        }
    }
}
