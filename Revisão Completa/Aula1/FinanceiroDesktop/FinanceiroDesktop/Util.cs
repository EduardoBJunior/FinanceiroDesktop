using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            DadosNaoEncontrados,
            CampoObg,
            UsuarioNãoEcontrado
        }
        //=========================================================
        public static bool PerguntarAntesExclusao()
        {
            if (MessageBox.Show(Mensagens.Msg.MesagemPerguntaExcluir,Mensagens.Msg.TituloAviso,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //====================================================================
        public enum EstadoTela
        {
            Novo,
            Alterar
        }
        //====================================================================
        public static void VisibilidadeColuna(DataGridView grid, string coluna, bool visivel)
        {
            grid.Columns[coluna].Visible = visivel;
        }
        //====================================================================
        public static void AlterarCabecalhoColunaGrid(DataGridView grid, string coluna, string NovoNome )
        {
            grid.Columns[coluna].HeaderText = NovoNome;
        }
        //====================================================================
        public static void ConfiguracaoGridView(DataGridView grid)
        {
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.MultiSelect = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect ;

        }

        //====================================================================
        public static void ExibirMsg(TipoMsg tipo)
        {
            switch (tipo)
            {
                case TipoMsg.Sucesso:
                    MessageBox.Show(Mensagens.Msg.MensagemSucesso, Mensagens.Msg.TituloSucesso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.Erro:
                    MessageBox.Show(Mensagens.Msg.MensagemErro, Mensagens.Msg.TituloErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case TipoMsg.DadosNaoEncontrados:
                    MessageBox.Show(Mensagens.Msg.MesagemRegistroNaoEncontrado, Mensagens.Msg.TituloAviso, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case TipoMsg.ErroExclusao:
                    MessageBox.Show(Mensagens.Msg.MensagemErroExclusao, Mensagens.Msg.TituloAviso,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
                case TipoMsg.UsuarioNãoEcontrado:
                    MessageBox.Show(Mensagens.Msg.MensagemUsusrioNaoEncontrado, Mensagens.Msg.TituloAviso,MessageBoxButtons.OK,MessageBoxIcon.Information);
                    break;
            }
        }

        //====================================================================
        public static void ExibirMsg(string campos)
        {
            MessageBox.Show(Mensagens.Msg.MesagemCampoObg+"\n\n"+campos,Mensagens.Msg.TituloAviso,MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        //====================================================================
        public static void EstadoBotao(EstadoTela estado,Button btnSalvar,Button btnExcluir)
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
                default:
                    break;
            }
        }

        //====================================================================

        public static void ConfigurarCombo(ComboBox c, string display, string value)
        {
            c.DisplayMember = display;
            c.ValueMember = value;
        }

        //======================================================================

        public static void LimparCamposGenerico(GroupBox g)
        {
            for (int i = 0; i < g.Controls.Count; i++)
            {
                switch (g.Controls[i].GetType().Name)
                {
                    case "TextBox":
                        TextBox campo = (TextBox)(g.Controls[i]);
                        campo.Clear();
                        break;

                    case "ComboBox":
                        ComboBox combo = (ComboBox)(g.Controls[i]);
                        combo.SelectedIndex = -1;
                        break;
                }
            }
        }

    }
}
