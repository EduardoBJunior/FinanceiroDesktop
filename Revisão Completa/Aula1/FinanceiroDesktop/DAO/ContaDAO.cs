using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ContaDAO
    {
      
        string strCon = "server=localhost;database=db_financeiro2;uid=root";
        //============================================================================
        public void InserirContaProc(tb_conta ObjConta)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "sp_inserir_conta";

            cmd.Connection = con;

            cmd.Parameters.AddWithValue("nome", ObjConta.nome_banco);
            cmd.Parameters.AddWithValue("agencia", ObjConta.agencia_conta);
            cmd.Parameters.AddWithValue("numero", ObjConta.numero_conta);
            cmd.Parameters.AddWithValue("saldo", ObjConta.saldo_conta);
            cmd.Parameters.AddWithValue("tipo_conta", ObjConta.tipo_conta);
            cmd.Parameters.AddWithValue("datacadastro", ObjConta.data_cadastro);
            cmd.Parameters.AddWithValue("id_user",ObjConta.id_usuario);

            try
            {
                cmd.Connection.Open();

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (cmd.Connection.State ==System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }
        //============================================================================
        public List<tb_conta> ConsultarContaProc(int codUserLogado)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            List<tb_conta> lstRetorno = new List<tb_conta>();


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_consultar_conta";
            cmd.Connection = con;
            
            cmd.Parameters.AddWithValue("id_user", codUserLogado);

            try
            {
                cmd.Connection.Open();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    tb_conta objConta = new tb_conta();
                    objConta.id_conta = Convert.ToInt32(dr["id_conta"]);
                    objConta.nome_banco = dr["nome_banco"].ToString();
                    objConta.agencia_conta = dr["agencia_conta"].ToString();
                    objConta.numero_conta = dr["numero_conta"].ToString();
                    objConta.saldo_conta = Convert.ToDecimal(dr["saldo_conta"]);
                    objConta.tipo_conta= Convert.ToInt16(dr["tipo_conta"]);
                    objConta.data_cadastro = Convert.ToDateTime(dr["data_cadastro"]);
                   


                    lstRetorno.Add(objConta);

                }
                if (dr.HasRows)
                {
                    dr.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }

            }
            return lstRetorno;

        }
        //============================================================================
        public List<ContaVO> ConsultarContaVO(int codUserLogado) {
            
            banco2 objbanco = new banco2();

            List<ContaVO> lstRetorno = new List<ContaVO>();

            List<tb_conta> lstConsulta = new List<tb_conta>();

            lstConsulta = objbanco.tb_conta.Where(con => con.id_usuario == codUserLogado).ToList();

            for (int i = 0; i < lstConsulta.Count; i++)
            {
                ContaVO objVo = new ContaVO();

                objVo.NomeBanco = lstConsulta[i].nome_banco;
                objVo.Agencia = lstConsulta[i].agencia_conta;
                objVo.NumeroConta = lstConsulta[i].numero_conta;
                objVo.Saldo = lstConsulta[i].saldo_conta.ToString();
                objVo.Tipo = lstConsulta[i].tipo_conta == 0 ? "Poupança" : "Corrente";

                lstRetorno.Add(objVo);
            }


            return lstRetorno;
        }
        //============================================================================
        public void AlterarContaProc(tb_conta ObjContaAtualizada)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_alterar_Conta";
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("nome",ObjContaAtualizada.nome_banco);
            cmd.Parameters.AddWithValue("agencia",ObjContaAtualizada.agencia_conta);
            cmd.Parameters.AddWithValue("numero",ObjContaAtualizada.numero_conta);
            cmd.Parameters.AddWithValue("saldo",ObjContaAtualizada.saldo_conta);
            cmd.Parameters.AddWithValue("tipoConta",ObjContaAtualizada.tipo_conta);
            cmd.Parameters.AddWithValue("idConta",ObjContaAtualizada.id_conta);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }

        //============================================================================
        public void InserirConta(tb_conta objConta)
        {
            //Cria  o obejeto do banco 

            banco2 objbanco = new banco2();

            //adiciona na tb conta o obj do parametro de entrada
            objbanco.AddTotb_conta(objConta);

            //salva no banco
            objbanco.SaveChanges();
             
        }
        //============================================================================
        /// <summary>
        /// Retorna todas as Categorias do usuario logado
        /// </summary>
        /// <param name="codUserLogado">Codigo do Logado</param>
        /// <returns> Lista de reusltado</returns>
        public List<tb_conta> ConsultarContas(int codUserLogado)
        {
            banco2 objbanco = new banco2();

            List<tb_conta> lstRetorno = objbanco.tb_conta.Where(cont => cont.id_usuario == codUserLogado).ToList();

            return lstRetorno;
        }
        //=========================================================================
        public List<ContaVO>PesquisarConta(int codUser, DateTime dataInicial, DateTime dataFinal, string NomeConta )
        {
            banco2 objBanco = new banco2();

            List<ContaVO> lstRetorno = new List<ContaVO>();
            List<tb_conta> lstConsulta = new List<tb_conta>();

            lstConsulta = objBanco.tb_conta.Where(co => co.id_usuario == codUser && co.nome_banco == NomeConta && co.data_cadastro >= dataInicial && co.data_cadastro <= dataFinal ).ToList();

            for (int i = 0; i < lstConsulta.Count; i++)
            {
                ContaVO objvo = new ContaVO();

                objvo.NomeBanco = lstConsulta[i].nome_banco;
                objvo.Agencia = lstConsulta[i].agencia_conta;
                objvo.NumeroConta = lstConsulta[i].numero_conta;
                objvo.Saldo = lstConsulta[i].saldo_conta.ToString();
                objvo.Tipo = lstConsulta[i].tipo_conta == 0 ? "Poupança" : "Corrente";
                
                objvo.objConta = lstConsulta[i];

                lstRetorno.Add(objvo);

            }

            return lstRetorno;

        }
        //=========================================================================
        //public List<MovimentoVO>PesquisarMovimentoConta(int codUser, DateTime dataInicial, DateTime dataFinal, )

        //=========================================================

        public void AlterarConta(tb_conta ObjContaAtualizada)
        {
            banco2 objBanco = new banco2();

            tb_conta objResgate = objBanco.tb_conta.Where(cont => cont.id_conta == ObjContaAtualizada.id_conta).FirstOrDefault();

            objResgate.nome_banco = ObjContaAtualizada.nome_banco;
            objResgate.agencia_conta = ObjContaAtualizada.agencia_conta;
            objResgate.numero_conta = ObjContaAtualizada.numero_conta;
            objResgate.saldo_conta = ObjContaAtualizada.saldo_conta;
            objResgate.tipo_conta = ObjContaAtualizada.tipo_conta;

            objBanco.SaveChanges();

        }
        //=========================================================================
        public void ExcluirConta(int codConta)
        {
            banco2 objBanco = new banco2();

            tb_conta objResgate = objBanco.tb_conta.Where(cont => cont.id_conta == codConta).FirstOrDefault();

            objBanco.DeleteObject(objResgate);

            objBanco.SaveChanges();
        }
        
        //============================================================================

        public void ExcluirContaProc(int idConta)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_excluir_conta";

            cmd.Connection = con;

            cmd.Parameters.AddWithValue("idConta",idConta);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
        }

    }
}
