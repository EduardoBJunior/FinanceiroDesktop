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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_ususario objUser = new tb_ususario();

                UsuarioDAO objDao = new UsuarioDAO();

                objUser.nome_usuario = txtNome.Text.Trim();
                objUser.senha_usuario = txtSenha.Text.Trim();
                objUser.email_usuario = txtEmail.Text.Trim();
                objUser.data_cadastro = DateTime.Now;

                try
                {
                    objDao.CriarConta(objUser);
                    Util.ExibirMsg(Util.TipoMsg.Sucesso);
                    Util.LimparCamposGenerico(grpCad);
                }
                catch (Exception)
                {

                    Util.ExibirMsg(Util.TipoMsg.Erro);
                }


                
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome, \n";

            }
            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += "- E-Mail,\n";
            }
            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += "- Senha";
            } else if (txtSenha.Text.Trim().Length < 6)
            {
                ret = false;
                campos += "- A senha deve ter no minimo 6 digitos.";
            }
            else if (txtSenha.Text.Trim() != txtRepSenha.Text.Trim())
            {
                ret = false;
                campos += "- As senhas devem ser identicas!";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
