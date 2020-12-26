using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Web.UI;
using DAO;

namespace ControleFinanceiroWeb.Controllers
{
    public class UsuarioController : PageBase
    {
        // GET: Usuario
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Deslogar()
        {
            Session.Remove("Cod");
            return RedirectToAction("Login","Usuario");
        }
        public ActionResult Logar(string email, string senha)
        {
            string pagina = "";
            if (email.Trim() == "" || senha.Trim() =="")
            {
                ViewBag.Msg = Mensagens.Msg.MesagemCampoObg;
                ViewBag.Ret = 0;
                pagina = "Login";

            }
            else
            {
                UsuarioDAO objDao = new UsuarioDAO();
                int codLogado = objDao.ValidarLogin(email, senha);

                if (codLogado ==-1)
                {
                    ViewBag.Msg = Mensagens.Msg.MensagemUsusrioNaoEncontrado;
                    ViewBag.Ret = 0;
                    pagina = "Login";

                }
                else
                {
                    CodigoLogado = codLogado;
                    return RedirectToAction("Consultar", "Movimento");
                }
            }
            return View();
        }

        public ActionResult CriarConta(string nome, string email, string senha, string rsenha)
        {
            ViewBag.nome = nome;
            ViewBag.email = email;

            if (nome.Trim() == "" || email.Trim() == "" || senha.Trim() == "" || rsenha.Trim() == "")
            {
                ViewBag.Ret = 0;
                ViewBag.Msg = Mensagens.Msg.MesagemCampoObg;
            }
            else if (senha.Trim() != rsenha.Trim())
            {
                ViewBag.Ret = 0;
                ViewBag.Msg = Mensagens.Msg.MensagemSenhaNaoConfere;
            }
            else
            {
                tb_ususario objUsuario = new tb_ususario();
                UsuarioDAO objDao = new UsuarioDAO();

                objUsuario.nome_usuario = nome;
                objUsuario.email_usuario = email;
                objUsuario.senha_usuario = senha;
                objUsuario.data_cadastro = DateTime.Now;

                try
                {
                    objDao.CadastrarUsuario(objUsuario);
                    ViewBag.Ret = 1;
                    ViewBag.Msg = Mensagens.Msg.MensagemSucesso;
                    ViewBag.nome = "";
                    ViewBag.email = "";

                }
                catch (Exception)
                {

                    ViewBag.Ret = -1;
                    ViewBag.Msg = Mensagens.Msg.MensagemErro;
                }
            }
            return View ("Login");
        }
    }
}