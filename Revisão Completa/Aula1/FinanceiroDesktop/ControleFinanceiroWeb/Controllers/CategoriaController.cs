using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAO;

namespace ControleFinanceiroWeb.Controllers
{
    public class CategoriaController : PageBase
    {
        private void MontarTitulo(int TipoPag)
        {
            switch (TipoPag)
            {
                case 1: //Tela de Cadastro
                    ViewBag.Titulo = "Nova Categoria";
                    ViewBag.SubTitulo = "Cadastre suas Categorias aqui";
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

        // GET: Categoria
        public ActionResult Cadastrar()
        {
            MontarTitulo(1);

            return View();
        }

        public ActionResult Consultar()
        {
            MontarTitulo(3);
            CarregarCategorias();
            return View();
        }

        public ActionResult Alterar(string cod, string nome)
        {
            MontarTitulo(2);

            ViewBag.cod = cod;
            ViewBag.nome = nome;

            return View();
        }

        private void CarregarCategorias()
        {
            CategoriaDAO objDao = new CategoriaDAO();
            List<tb_categoria> lst = objDao.ConsultarCategoria(CodigoLogado);
            ViewBag.LstCategorias = lst;

        }


        public ActionResult Gravar(string cod, string nome, string btn)
        {
            string pagina = "";

            if (btn == "excluir")
            {
                
                int codCat = Convert.ToInt32(cod);
                CategoriaDAO objdao = new CategoriaDAO();

                try
                {
                    objdao.ExcluirCategoria(codCat);
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
                CarregarCategorias();

            }
            else
            {


                if (nome.Trim() == "")
                {
                    ViewBag.Ret = 0;
                    ViewBag.Msg = Mensagens.Msg.MesagemCampoObg;

                    if (cod == null)
                    {
                        pagina = "Cadastrar";
                        MontarTitulo(1);
                    }
                    else
                    {
                        pagina = "Alterar";
                        MontarTitulo(2);
                    }
                }
                else
                {
                    tb_categoria objCategoria = new tb_categoria();
                    CategoriaDAO objDao = new CategoriaDAO();

                    objCategoria.id_categoria = Convert.ToInt32(cod);
                    objCategoria.nome_categoria = nome;
                    objCategoria.id_usuario = CodigoLogado;
                    objCategoria.data_cadastro = DateTime.Now;

                    try
                    {
                        if (cod == null || cod =="")
                        {
                            objDao.InsereriCategoriaProc(objCategoria);
                            pagina = "Cadastrar";
                            MontarTitulo(1);
                        }
                        else
                        {
                            objCategoria.id_categoria = Convert.ToInt32(cod);
                            objDao.AlterarCategoria(objCategoria);

                            pagina = "Consultar";
                            MontarTitulo(3);
                            CarregarCategorias();
                        }

                        ViewBag.Ret = 1;
                        ViewBag.Msg = Mensagens.Msg.MensagemSucesso;
                    }
                    catch (Exception)
                    {

                        ViewBag.Ret = -1;
                        ViewBag.Msg = Mensagens.Msg.MensagemErro;

                        if (cod == null)
                        {
                            pagina = "Cadastrar";
                            MontarTitulo(1);
                        }
                        else
                        {
                            pagina = "Alterar";
                            MontarTitulo(2);
                        }
                    }

                }


            }

            return View(pagina);
        }
    }
}