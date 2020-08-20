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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro cadastro = new frmCadastro();
            cadastro.ShowDialog();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtb_LoginEmail.Text.Trim() =="")
            {
                ret = false;

                campos = "- E-mail \n";
            }
            if (txtb_LoginSenha.Text.Trim() =="")
            {
                ret = false;

                campos += "- Senha";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }
    }
}
