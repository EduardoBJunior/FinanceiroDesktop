﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinanceiroDesktop
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void gerenciarCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.ShowDialog();
        }

        private void gerenciarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpresa frm = new frmEmpresa();
            frm.ShowDialog();
        }

        private void gerenciarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConta frm = new frmConta();
            frm.ShowDialog();
        }

        private void lançarMovimentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimento frm = new frmMovimento();
            frm.ShowDialog();
        }

        private void porEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarMovimentoEmpresa frm = new frmConsultarMovimentoEmpresa();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void porCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCategoria frm = new frmConsultarCategoria();
            frm.ShowDialog();
        }

        private void porContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarConta frm = new frmConsultarConta();
            frm.ShowDialog();
        }
    }
}
