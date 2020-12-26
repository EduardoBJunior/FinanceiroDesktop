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
            ErroExclusao,
            DadosNaoEncontrado,
            CampoObg
        }

        public enum EstadoTela
        {
            Novo,
            Alterar
        }

        public static bool PerguntarAntesExclusao()
        {
            if (MessageBox.Show(Mensagens.Msg.MensagemPerguntaExcluir,Mensagens.Msg.TituloAviso,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
       



        }

        public static void VisibilidadeColunaGrid(DataGridView grid,string coluna, bool visivel)
        {
            grid.Columns[coluna].Visible = visivel;

        }

        public static void AlterarCabecalhoColuna(DataGridView grid, string coluna, string nome)
        {
            grid.Columns[coluna].HeaderText = nome;
        }
        public static void ConfigurarGrid(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ReadOnly = false;
        }

        public static void ExibirMsg(TipoMsg tipo)
        {
            switch (tipo)
            {
                case TipoMsg.Sucesso:
                    
                    MessageBox.Show(Mensagens.Msg.MensagemSucesso,Mensagens.Msg.TituloSucesso,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;

                case TipoMsg.Erro:

                    MessageBox.Show(Mensagens.Msg.MensagemErro,Mensagens.Msg.TituloErro,MessageBoxButtons.OK,MessageBoxIcon.Error);

                    break;

                case TipoMsg.DadosNaoEncontrado:

                    MessageBox.Show(Mensagens.Msg.MensagemRegistroNaoEncontrado,Mensagens.Msg.TituloAviso,MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    break;

                

                case TipoMsg.ErroExclusao:
                    MessageBox.Show(Mensagens.Msg.MensagemExcluir,Mensagens.Msg.TituloErro,MessageBoxButtons.OK,MessageBoxIcon.Error);
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
