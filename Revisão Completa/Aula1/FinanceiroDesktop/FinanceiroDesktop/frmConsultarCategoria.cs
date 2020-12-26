using DAO;
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
    public partial class frmConsultarCategoria : Form
    {
        public frmConsultarCategoria()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FiltrarMovimentoCategoria();
            txtTotal.Text = SomarTotal().ToString();
        }



        private void frmConsultarCategoria_Load(object sender, EventArgs e)
        {
            CarregarCombos();
            Util.ConfigurarCombo(cbCategoria, "nome_categoria", "nome_categoria");
        }

        public void FiltrarMovimentoCategoria()
        {
            MovimentoDAO objDao
                = new MovimentoDAO();

            List<MovimentoVO> lstCategoria = new List<MovimentoVO>();

            lstCategoria = objDao.ConsultarMovimentoCategoria(Usuario.codigoLogado, dtp_inicio.Value.Date, dtp_final.Value.Date,((tb_categoria)cbCategoria.SelectedItem).id_categoria);

            grdCategoria.DataSource = lstCategoria;
        }
        public decimal SomarTotal()
        {
            decimal total = 0;
            for (int i = 0; i < grdCategoria.Rows.Count; i++)
            {
                total += Convert.ToDecimal(grdCategoria.Rows[i].Cells["Valor"].Value);

            }
            return total;
        }
        public void CarregarCombos()
        {
           
            List<tb_categoria> lstCat = new List<tb_categoria>();

            lstCat = new CategoriaDAO().ConsultarCategoria(Usuario.codigoLogado);
            for (int i = 0; i < lstCat.Count; i++)
            {
                lstCat[i].nome_categoria = lstCat[i].nome_categoria;
            }

            cbCategoria.DataSource = lstCat;
        }
    }
}
