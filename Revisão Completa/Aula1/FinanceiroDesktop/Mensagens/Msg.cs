using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensagens
{
    public static class Msg
    {
        //classe estatica não precisa instanciar 
        /// <summary>
        /// Ação Realizada com sucesso
        /// </summary>
        public static string MensagemSucesso = "Açao Realizada com sucesso";
        /// <summary>
        /// Ocorreu um erro na opreração
        /// </summary>
        public static string MensagemErro = "Ocorreu um erro na operção";
        /// <summary>
        /// Ocorreu um erro na Exclusão
        /// </summary>
        public static string MensagemErroExclusao = "Não Foi possivel Excluir o registro pois esta em uso!";
        /// <summary>
        /// Senha Diferente do Digitado
        /// </summary>
        public static string MensagemSenhaNaoConfere = "O campo Repetir senha não condfere com o valor digitado no campos senha";
        /// <summary>
        /// Não foi encontrado nenhum registro
        /// </summary>
        public static string MesagemRegistroNaoEncontrado = "Não foi encontrado nenhum registro";
        /// <summary>
        /// Favor preencher o(s) campo(s) obrigatorio(s)
        /// </summary>
        public static string MesagemCampoObg = "Favor preencher o(s) campo(s) obrigatorio(s)";

        public static string MesagemPerguntaExcluir = "Deseja Excluir o Item ?";

        public static string MensagemUsusrioNaoEncontrado = "Usuário não encontrado!";

        public static string TituloSucesso = "Sucesso";
        public static string TituloErro = "Erro";
        public static string TituloAviso = "Aviso";


    }
}
