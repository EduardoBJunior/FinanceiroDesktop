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
    public partial class frmConsultarEmpresa : Form
    {
        public frmConsultarEmpresa()
        {
            InitializeComponent();
        }
        private void frmConsultarEmpresa_Load(object sender, EventArgs e)
        {
            Util.ConfigurarCombo(cbEmpresas, "nome_empresa", "nome_empresa");
            Util.ConfiguracaoGridView(grdMovimentacao);
            CarregarCombos();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            FiltrarMovimentações();
        }


        public void CarregarCombos()
        {

            List<tb_empresa> lstEmpresa = new EmpresaDAO().ConsultarEmpresa(Usuario.codigoLogado);

            for (int i = 0; i < lstEmpresa.Count; i++)
            {
                lstEmpresa[i].nome_empresa = lstEmpresa[i].nome_empresa;
            }
            cbEmpresas.DataSource = lstEmpresa;
        }

        public void FiltrarMovimentações()
        {
            MovimentoDAO objDao
                = new MovimentoDAO();

            List<MovimentoVO> lstEmpresa = new List<MovimentoVO>();

            lstEmpresa = objDao.ConsultarMovimentoCategoria(Usuario.codigoLogado, dtpInicial.Value.Date, dtpFinal.Value.Date, ((tb_empresa)cbEmpresas.SelectedItem).id_empresa);

            grdMovimentacao.DataSource = lstEmpresa;
        }


    }
}
