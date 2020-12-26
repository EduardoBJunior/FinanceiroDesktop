using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class ContaDAO
    {
        banco objBanco = new banco();
        public void InserirConta(tb_conta objConta)
        {
            objBanco.AddTotb_conta(objBanco);
            objBanco.SaveChanges();
        }

        //public AlterarConta(tb_conta objcontaAtualizada)
        //{
        //    //resgatar a conta
        //    tb_conta objResgate = objBanco.tb_conta.FirstOrDefault(con => con.id_conta == objcontaAtualizada.id_conta);
        //    //atualiza as informações
        //    objResgate.nome_banco = objcontaAtualizada.nome_banco;
        //    objResgate.agencia_conta = objcontaAtualizada.agencia_conta;
        //    objResgate.numero_conta = objcontaAtualizada.numero_conta;
        //    objResgate.saldo_conta = objcontaAtualizada.saldo_conta;
        //    objres

        //    objBanco.SaveChanges();
        //}

        //public void ExcluirConta(int idConta)
        //{

        //    //resgatar conta
        //    tb_conta objResgate = objBanco.tb_conta
        //}


    }
}
