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

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Util.EstadoBotao(Util.EstadoTela.Novo,btnSalvar,btnExcluir);
            LimparCampos();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

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
            Util.EstadoBotao(Util.EstadoTela.Novo, btnSalvar, btnExcluir);
            LimparCampos();
        }
    }
}
