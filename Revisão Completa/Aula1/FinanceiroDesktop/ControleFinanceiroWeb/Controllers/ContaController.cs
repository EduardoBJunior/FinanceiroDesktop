using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleFinanceiroWeb.Controllers
{
    public class ContaController : PageBase
    {
        // GET: Conta
        private void MontarTitulo(int TipoPag)
        {
            switch (TipoPag)
            {
                case 1: //Tela de Cadastro
                    ViewBag.Titulo = "Nova Conta";
                    ViewBag.SubTitulo = "Cadastre suas Contas aqui";
                    break;

                case 2: //Tela de Alterar
                    ViewBag.Titulo = "Aletar Conta";
                    ViewBag.SubTitulo = "Altere suas Contas  aqui";
                    break;

                case 3: //Tela de Consulta
                    ViewBag.Titulo = "Consultar Conta";
                    ViewBag.SubTitulo = "Consulte suas Contas aqui";
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
            CarregarContas();
            return View();
        }

        public ActionResult Alterar(string cod, string nomeBanco, string numConta, string agencia,string tipoConta, string saldoAtual)
        {
            MontarTitulo(2);

            ViewBag.cod = cod;
            ViewBag.nomeBanco = nomeBanco;
            ViewBag.numConta = numConta;
            ViewBag.agencia = agencia;
            ViewBag.tipoConta = tipoConta;
            ViewBag.saldoAtual = saldoAtual;

            return View();
        }

        private void CarregarContas()
        {
            ContaDAO objDao = new ContaDAO();
            List<tb_conta> lst = objDao.ConsultarContas(CodigoLogado);
            ViewBag.LstConta = lst;

        }


        public ActionResult Gravar(string cod, string nomeBanco, string numConta, string agencia,string tipoConta, string saldoAtual, string btn)
        {
            string pagina = "";

            if (btn == "excluir")
            {

                int codConta = Convert.ToInt32(cod);
                ContaDAO objdao = new ContaDAO();

                try
                {
                    objdao.ExcluirConta(codConta);
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
                CarregarContas();

            }
            else
            {


                if (nomeBanco.Trim() == ""|| numConta.Trim() == "" || agencia.Trim() == "" || saldoAtual.Trim() =="" )
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
                    tb_conta objConta = new tb_conta();
                    ContaDAO objDao = new ContaDAO();

                   
                    objConta.nome_banco = nomeBanco;
                    objConta.id_usuario = CodigoLogado;
                    objConta.numero_conta = numConta;
                    objConta.agencia_conta = agencia;
                    objConta.tipo_conta = Convert.ToInt16(tipoConta);
                    objConta.saldo_conta = Convert.ToDecimal(saldoAtual);
                    objConta.data_cadastro = DateTime.Now;

                    try
                    {
                        if (cod == null || cod == "")
                        {
                            objDao.InserirConta(objConta);
                            pagina = "Cadastrar";
                            MontarTitulo(1);
                        }
                        else
                        {
                            objConta.id_conta = Convert.ToInt32(cod);
                            objDao.AlterarConta(objConta);

                            pagina = "Consultar";
                            MontarTitulo(3);
                            CarregarContas();
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