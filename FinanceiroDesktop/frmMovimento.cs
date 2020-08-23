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

        private void frmMovimento_Load(object sender, EventArgs e)
        {
            Util.EstadoBotao(Util.EstadoTela.Novo, Button btn_salvar);
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {

        }
    }
}
