using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagens
{
    public class Msg
    {
        /// <summary>
        /// Acão realizada com sucesso
        /// </summary>
        public static string MensagemSucesso = "Acão realizada com sucesso";
        /// <summary>
        /// Ocorreu um erro na operação
        /// </summary>
        public static string MensagemErro = "Ocorreu um Erro na operação";
        /// <summary>
        /// Não foi Encontrado nenhum registro
        /// </summary>
        public static string MensagemRegistroNaoEncontrado = "Não foi Encontrado nenhum registro";
        /// <summary>
        /// Favor Preencher o(s) campos(s) obrigatório(s)
        /// </summary>
        public static string MensagemCampoObg = "Favor Preencher o(s) campos(s) obrigatório(s)";
        /// <summary>
        /// Deseja realmente excluir o item?
        /// </summary>
        public static string MensagemPerguntaExcluir = "Deseja realmente excluir o item?";
        /// <summary>
        /// Não Foi possivel excluir o registro, pois está em uso.
        /// </summary>
        public static string MensagemExcluir = "Não Foi possivel excluir o registro, pois está em uso.";


        public static string TituloSucesso = "Sucesso";
        public static string TituloErro = "Erro";
        public static string TituloAviso= "Aviso";
        public static String TituloErroExcluao = "Excluir";

    }
}
