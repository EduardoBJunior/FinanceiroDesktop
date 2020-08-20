using Mensagens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceiroDesktop
{
    public static class Util
    {
        public enum TipoMsg
        {
            Sucesso, 
            Erro,
            DadosNaoEncontrado,
            CampoObg
        }

        public enum EstadoTela
        {
            Novo,
            Alterar
        }

        public static void ExibirMsg(TipoMsg tipo)
        {
            switch (tipo)
            {
                case TipoMsg.Sucesso:
                    
                    MessageBox.Show(Mensagens.Msg.MesagemSucesso,Mensagens.Msg.TituloSucesso,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                case TipoMsg.Erro:

                    MessageBox.Show(Mensagens.Msg.MensagemErro,Mensagens.Msg.TituloSucesso,MessageBoxButtons.OK,MessageBoxIcon.Error);

                    break;

                case TipoMsg.DadosNaoEncontrado:

                    MessageBox.Show(Mensagens.Msg.MessagemRegistroNaoEncontrado,Mensagens.Msg.TituloAviso,MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    break;

            }
        }

        public static void ExibirMsg(string campos)
        {
            MessageBox.Show(Mensagens.Msg.MessagemCampoObg +"\n\n" + campos, Mensagens.Msg.TituloAviso, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static void EstadoBotao(EstadoTela estado, Button btnSalvar, Button btnExcluir)
        {
            switch (estado)
            {
                case EstadoTela.Novo:
                    btnSalvar.Text = "Cadastrar";
                    btnExcluir.Visible = false;
                    break;

                case EstadoTela.Alterar:
                    btnSalvar.Text = "Alterar";
                    btnExcluir.Visible = true;
                    break;
                
            }
        }
    }
}
