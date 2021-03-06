﻿using DAO;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastro frm = new frmCadastro();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                UsuarioDAO objDAO = new UsuarioDAO();

                int codUser = objDAO.ValidarLogin(txtEmail.Text.Trim(), txtSenha.Text.Trim());
                if (codUser ==-1)
                {
                    Util.ExibirMsg(Util.TipoMsg.UsuarioNãoEcontrado);
                }
                else
                {
                    Usuario.codigoLogado = codUser;
                    this.DialogResult = DialogResult.OK;
                }
            }
            
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += " - E-Mail \n";
            }
            if (txtSenha.Text.Trim() =="")
            {
                ret = false;
                campos += " - Senha";
            }

            if (!ret)
            {
                Util.ExibirMsg(campos);
            }
            return ret;
        }
    }
}
