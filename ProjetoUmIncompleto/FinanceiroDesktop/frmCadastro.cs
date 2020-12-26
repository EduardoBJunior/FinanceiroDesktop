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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {

            }
        }


        private bool VerificarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNome.Text.Trim() =="")
            {
                ret = false;
                campos = "- Nome \n";
            }

            if (txtEmail.Text.Trim() =="")
            {
                ret = false;
                campos += "- Email \n";
            }

            if (txtSenha.Text.Trim() =="")
            {
                ret = false;
                campos += " - Senha \n";
            }else if (txtSenha.Text.Trim().Length < 6 )
            {
                ret = false;
                campos += "A quantidade Minima de caracteres para a senha é seis(6)";

            }else if (txtSenha.Text.Trim() != txtRepetirSenha.Text.Trim())
            {
                ret = false;
                campos += "A senhas digitadas são diferentes, Digite novamente";

            }

            
            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }

        

    }
}
