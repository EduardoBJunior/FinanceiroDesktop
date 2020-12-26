using DAO;
using Mensagens;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.WebPages;

namespace ControleFinanceiroWeb.Controllers
{
    public class EmpresaController : PageBase
    {
        // GET: Empresa

        private void MontarTitulo(int TipoPag)
        {
            switch (TipoPag)
            {
                case 1: //Tela de Cadastro
                    ViewBag.Titulo = "Nova Empresa";
                    ViewBag.SubTitulo = "Cadastre suas Empresa aqui";
                    break;

                case 2: //Tela de Alterar
                    ViewBag.Titulo = "Aletar Empresa";
                    ViewBag.SubTitulo = "Altere suas Empresa aqui";
                    break;

                case 3: //Tela de Consulta
                    ViewBag.Titulo = "Consultar Empresa";
                    ViewBag.SubTitulo = "Consulte suas Empresa aqui";
                    break;

            }
        }
        public ActionResult Cadastrar()
        {
            MontarTitulo(1);

            return View();
        }

        public ActionResult Alterar(string cod, string nome, string tel, string end, string sit)
        {
            MontarTitulo(2);

            ViewBag.cod = cod;
            ViewBag.nome = nome;
            ViewBag.tel = tel;
            ViewBag.end = end;
            ViewBag.sit = sit;

            return View();
        }

        public ActionResult Consultar()
        {
            MontarTitulo(3);
            ConsultarEmpresas();
            return View();
        }

        public ActionResult Gravar(string nome, string tel, string end, string sit, string cod, string btn)
        {
            string pagina = "";
           

            if (btn == "excluir")
            {
                int codEmpresa = Convert.ToInt32(cod);
                EmpresaDAO ObjDao = new EmpresaDAO();

                try
                {
                    

                    ObjDao.ExcluirEmpresa(codEmpresa);
                    ViewBag.Ret = 1;
                    ViewBag.Msg = Mensagens.Msg.MensagemSucesso;

                }
                catch (Exception)
                {
                    ViewBag.Ret = -1;
                    ViewBag.Msg = Mensagens.Msg.MensagemErroExclusao;
                }

                pagina = "Consultar";
                MontarTitulo(3);
                ConsultarEmpresas();
            }
            else
            {


                if (nome.Trim() == "" || tel.Trim() == "" || end.Trim() == "" || sit == "")
                {
                    ViewBag.Ret = 0;
                    ViewBag.Msg = Mensagens.Msg.MesagemCampoObg;

                    if (cod == null)
                    {
                        MontarTitulo(1);
                        pagina = "Cadastrar";
                    }
                    else
                    {
                        MontarTitulo(2);
                        pagina = "Alterar";
                    }
                }
                else
                {
                    EmpresaDAO objdao = new EmpresaDAO();
                    tb_empresa objEmpresa = new tb_empresa();

                   
                    objEmpresa.nome_empresa = nome;
                    objEmpresa.tel_empresa = tel;
                    objEmpresa.endereco_empresa = end;
                    objEmpresa.site_empresa = sit;
                    objEmpresa.data_cadastro = DateTime.Now;
                    objEmpresa.id_usuario = CodigoLogado;

                    try
                    {
                        if (cod == null)
                        {

                            objdao.InserirEmpresa(objEmpresa);
                            MontarTitulo(1);
                            pagina = "Cadastrar";

                        }
                        else
                           {

                            objdao.AlterarEmpresa(objEmpresa);
                            MontarTitulo(2);
                            pagina = "Alterar";

                        }
                        ViewBag.ret = 1;
                        ViewBag.Msg = Mensagens.Msg.MensagemSucesso;
                    }
                    catch (Exception ex)
                    {
                        ViewBag.ret = -1;
                        ViewBag.Msg = Mensagens.Msg.MensagemErro;

                        if (cod == null)
                        {
                            MontarTitulo(1);
                            pagina = "Cadastrar";
                        }
                        else
                        {
                            MontarTitulo(2);
                            pagina = "Alterar";
                        }
                    }

                    MontarTitulo(1);

                    

                }
                
            }
            return View(pagina);
        }



        private void ConsultarEmpresas()
        {
            EmpresaDAO objdao = new EmpresaDAO();
            List<tb_empresa> objRes = objdao.ConsultarEmpresa(CodigoLogado);

            ViewBag.LstEmpresas = objRes;
        }


    }
}