using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;

namespace ControleFinanceiroWeb.Controllers
{
    public class MovimentoController : PageBase
    {
        public void CarregarComboEmpresa()
        {

            EmpresaDAO objEmpresa = new EmpresaDAO();
            ViewBag.lstEmpresa = objEmpresa.ConsultarEmpresa(CodigoLogado);
        }
        public void CarregarComboCategoria()
        {
            CategoriaDAO objCategoria = new CategoriaDAO();
            ViewBag.lstCategoria = objCategoria.ConsultarCategoria(CodigoLogado);
        }
        public void CarregarComboConta()
        {
            ContaDAO objConta = new ContaDAO();
            ViewBag.lstConta = objConta.ConsultarContas(CodigoLogado);
        }
        private void MontarTitulo(int TipoPag)
        {
            switch (TipoPag)
            {
                case 1: //Tela de Cadastro
                    ViewBag.Titulo = "Realizar Lançamneto";
                    ViewBag.SubTitulo = "Faça sua movimentação aqui ";
                    break;

                case 2: //Tela de Alterar
                    ViewBag.Titulo = "Aletar Categoria";
                    ViewBag.SubTitulo = "Altere suas Categorias aqui";
                    break;

                case 3: //Tela de Consulta
                    ViewBag.Titulo = "Consultar Categoria";
                    ViewBag.SubTitulo = "Consulte suas Categorias aqui";
                    break;

            }
        }
        // GET: Movimento
        public ActionResult Lancar()
        {
            MontarTitulo(1);
            CarregarComboCategoria();
            CarregarComboConta();
            CarregarComboEmpresa();

            return View();
        }
        public ActionResult Gravar(string data, string tipo, string valor, string cat, string emp, string conta, string obs)
        {
            if (data == "" || tipo == "" || valor == "" || cat == "" || emp == "" || conta == ""  )
            {
                ViewBag.Ret = 0;
                ViewBag.Msg = Mensagens.Msg.MesagemCampoObg;
            }
            else
            {

                tb_movimento objMov = new tb_movimento();
                MovimentoDAO objDao = new MovimentoDAO();

                objMov.tipo_movimento = Convert.ToInt16(tipo);
                objMov.valor_movimento = Convert.ToDecimal(valor);
                objMov.data_movimento = Convert.ToDateTime(data);
                objMov.ob_movimento = obs;
                objMov.id_empresa = Convert.ToInt32(emp);
                objMov.id_categoria = Convert.ToInt32(cat);
                objMov.id_conta = Convert.ToInt32(conta);

                try
                {
                    objDao.LancarMovimento(objMov);
                    ViewBag.Ret = 1;
                    ViewBag.Msg = Mensagens.Msg.MensagemSucesso;
                }
                catch (Exception)
                {

                    ViewBag.Ret = -1;
                    ViewBag.Msg = Mensagens.Msg.MensagemErro;
                }
                    
            }

            MontarTitulo(1);
            CarregarComboCategoria();
            CarregarComboConta();
            CarregarComboEmpresa();

            return View("Lancar");
        }
        public void FiltrarMovs(short tipo, DateTime datainicial,DateTime datafinal)
        {
            MovimentoDAO objdao = new MovimentoDAO();
            ViewBag.Movs = objdao.ConsultarMovimento(CodigoLogado, datainicial, datafinal, tipo);
        }

        public ActionResult Filtrar(string tipo, string datainicial, string datafinal)
        {
            ViewBag.Ini = datainicial;
            ViewBag.Fim = datafinal;

            if (datainicial == "" || datafinal == "")
            {
                ViewBag.Ret = 0;
                ViewBag.MSG = Mensagens.Msg.MesagemCampoObg;

            }
            else
            {
                DateTime dtinicial = Convert.ToDateTime(datainicial);
                DateTime dtfinal = Convert.ToDateTime(datafinal);
                short tipoPes = Convert.ToInt16(tipo);

                FiltrarMovs(tipoPes, dtinicial, dtfinal);

            }
            MontarTitulo(3);
            return View ("Consultar");
        }

        public ActionResult Consultar()
        {
            return View();
        }
    }
}