using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System.ComponentModel;
using DAO;

namespace DAO
{
    public class MovimentoDAO
    {
        string strCon = "server=localhost;database=db_financeiro2;uid=root";

        public void ExcluirMovimento(int idMov, int tipo, decimal valor, int idConta)
        {
            banco2 objBanco = new banco2();

            tb_movimento objmovExcluir = objBanco.tb_movimento.FirstOrDefault(mov => mov.id_movimento == idMov);

            using (TransactionScope tran = new TransactionScope())
            {
                objBanco.DeleteObject(objmovExcluir);

                objBanco.SaveChanges();

                tb_conta objContaAtualizar = objBanco.tb_conta.FirstOrDefault(con => con.id_conta == idConta);

                if (tipo == 0)
                {
                    objContaAtualizar.saldo_conta -= valor;
                }
                else
                {
                    objContaAtualizar.saldo_conta += valor;
                }
                objBanco.SaveChanges();

                tran.Complete();
            }
        }

        public int LancarMovimentoProc(tb_movimento objMovi)
        {
            int ret = 0;
            MySqlConnection con = new MySqlConnection(strCon);

            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_realizar_movimento";
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("data_mov", objMovi.data_movimento);
            cmd.Parameters.AddWithValue("dataCadastro", objMovi.data_cadastro);
            cmd.Parameters.AddWithValue("tipo", objMovi.tipo_movimento);
            cmd.Parameters.AddWithValue("valor", objMovi.valor_movimento);
            cmd.Parameters.AddWithValue("obs", objMovi.ob_movimento);
            cmd.Parameters.AddWithValue("idEmp", objMovi.id_empresa);
            cmd.Parameters.AddWithValue("idCat", objMovi.id_categoria);
            cmd.Parameters.AddWithValue("idCon", objMovi.id_conta);
            cmd.Parameters.AddWithValue("idUser", objMovi.id_usuario);
            cmd.Parameters.AddWithValue("ret", MySqlDbType.Int32).Direction = ParameterDirection.Output;

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                ret = Convert.ToInt32(cmd.Parameters["ret"].Value);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return ret;
        }

        public void LancarMovimento(tb_movimento objMov)

        {

            banco2 objBanco = new banco2();
            objBanco.AddTotb_movimento(objMov);

            if (objMov.id_conta == null)
            {

            }
            else
            {
                using (TransactionScope t = new TransactionScope())
                {
                    //insere na tb_movimento
                    objBanco.SaveChanges();

                    tb_conta objConta = objBanco.tb_conta.FirstOrDefault(cont => cont.id_conta == objMov.id_conta);

                    //identificar se vai remover ou adicionar dinheiro verificando a combo de tipo 

                    if (objMov.tipo_movimento == 0)//entrada
                    {
                        objConta.saldo_conta += objMov.valor_movimento;
                    }
                    else//saida
                    {
                        objConta.saldo_conta -= objMov.valor_movimento;
                    }

                    //altera na tb_conta
                    objBanco.SaveChanges();
                    
                    //confirmação da Transactrion 
                    t.Complete();
                }
            }



        }

        public List<MovimentoVO> ConsultarMovimento(int codUser, DateTime dtInicial, DateTime dtFinal, short tipoMov)
        {
            banco2 objBanco = new banco2();
            //Lista de Retorno - O Movimento VO foi criado para personalizar um retorno devido ter mais de uma tabela  vinculada
            List<MovimentoVO> lstRetorno = new List<MovimentoVO>();
            // Lista de Consulta
            List<tb_movimento> lstConsulta = new List<tb_movimento>();

            if (tipoMov != 2)
            {
                // Alimenta a lista de consulta fcom os dados da tabela de movimento  quando  o tipo for especifico

                lstConsulta = objBanco.tb_movimento
                .Include("tb_conta")
                .Include("tb_categoria")
                .Include("tb_empresa")
                .Where(mov => mov.id_usuario == codUser
                       && mov.data_movimento >= dtInicial && mov.data_movimento <= dtFinal
                       && mov.tipo_movimento == tipoMov).ToList();
            }
            else
            {
                lstConsulta = objBanco.tb_movimento
                .Include("tb_conta")
                .Include("tb_categoria")
                .Include("tb_empresa")
                .Where(mov => mov.id_usuario == codUser
                       && mov.data_movimento >= dtInicial && mov.data_movimento <= dtFinal).ToList();
            }


            // este for vai percorrer  item a item da lista de Consulta 
            for (int i = 0; i < lstConsulta.Count ; i++)
            {
                //cria o obj
                MovimentoVO objvo = new MovimentoVO();

                //preenche as propriedades customizadas
                objvo.Categoria = lstConsulta[i].tb_categoria.nome_categoria;
                objvo.Empresa = lstConsulta[i].tb_empresa.nome_empresa;
                objvo.Conta = lstConsulta[i].tb_conta.numero_conta + " / Banco: " + lstConsulta[i].tb_conta.nome_banco;
                objvo.Data = lstConsulta[i].data_movimento.ToShortDateString();
                objvo.Valor = lstConsulta[i].valor_movimento;
                objvo.Tipo = lstConsulta[i].tipo_movimento == 0 ? "Entrada" : "Saída";

                objvo.objMov = lstConsulta[i];

                //Adiciona na lista de retorno
                lstRetorno.Add(objvo);
            }

            return lstRetorno;
        }

        public List<MovimentoVO> ConsultarMovimentoaProc(int codUser, DateTime dtInicial, DateTime dtFinal, short tipoMov)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            List<MovimentoVO> lstRtorno = new List<MovimentoVO>();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_filtrar_movimento";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("codUser", codUser);
            cmd.Parameters.AddWithValue("dt_ini", dtInicial);
            cmd.Parameters.AddWithValue("dt_fim", dtFinal);
            cmd.Parameters.AddWithValue("tipo", tipoMov);
            

            try
            {
                //abre a conexão
                cmd.Connection.Open();

                // vai executar e qguardar as linhas no obj de leitura de dados
                MySqlDataReader dr = cmd.ExecuteReader();

                //percorre as linahs retornadas e para cada interaçõa ceia um obj com as informações da linha da ves

                while (dr.Read())
                {
                    //criar o obj
                    MovimentoVO objvo = new MovimentoVO();

                    //preenche as propriedades customizadas
                    objvo.Categoria = dr["nome_categoria"].ToString();
                    objvo.Empresa = dr["nome_empresa"].ToString();
                    objvo.Conta = dr["numero_conta"].ToString() + " / Banco: " + dr["nome_banco"].ToString();
                    objvo.Data = dr["data_movimento"].ToString().Split(' ')[0];
                    objvo.Valor = Convert.ToDecimal(dr["valor_movimento"]);
                    objvo.Tipo = Convert.ToInt16(dr["tipo_movimento"]) == 0 ? "Entrada" : "Saída";
                    objvo.Obs = dr["ob_movimento"].ToString();

                    tb_movimento objMovDaVez = new tb_movimento();

                    objMovDaVez.id_movimento = Convert.ToInt32(dr["id_movimento"]);
                    objMovDaVez.id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    objMovDaVez.id_empresa= Convert.ToInt32(dr["id_empresa"]);
                    objMovDaVez.id_conta = Convert.ToInt32(dr["id_conta"]);
                    objMovDaVez.data_movimento = Convert.ToDateTime(dr["data_movimento"]);
                    objMovDaVez.valor_movimento = Convert.ToDecimal(dr["valor_movimento"]);
                    objMovDaVez.ob_movimento = Convert.ToString(dr["ob_movimento"]);
                    objMovDaVez.tipo_movimento = Convert.ToInt16(dr["tipo_movimento"]);

                    objvo.objMov = objMovDaVez;


                    lstRtorno.Add(objvo);
                   // objvo.objMov = lstConsulta[i];

                 

                }
                //verifica as linhas
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
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }
            return lstRtorno;
        }


        public List<MovimentoVO> ConsultarMovimentoConta(int codUser, DateTime dtInicial, DateTime dtFinal, int idConta) 
        {

            banco2 objBanco = new banco2();

            List<MovimentoVO> lstRetorno = new List<MovimentoVO>();
            List<tb_movimento> lstConsulta = new List<tb_movimento>();



            lstConsulta = objBanco.tb_movimento
           .Include("tb_conta")
           .Include("tb_categoria")
           .Include("tb_empresa")
           .Where(mov => mov.id_usuario == codUser
                  && mov.data_movimento >= dtInicial
                  && mov.data_movimento <= dtFinal
                  && mov.tb_conta.id_conta ==idConta).ToList();

                       

            for (int i = 0; i < lstConsulta.Count; i++)
            {
                //cria o obj
                MovimentoVO objvo = new MovimentoVO();

                //preenche as propriedades customizadas
                objvo.Conta = lstConsulta[i].tb_conta.nome_banco +  " / Numero : " + lstConsulta[i].tb_conta.numero_conta;
                objvo.Categoria = lstConsulta[i].tb_categoria.nome_categoria;
                objvo.Empresa = lstConsulta[i].tb_empresa.nome_empresa;
                
                objvo.Data = lstConsulta[i].data_movimento.ToShortDateString();
                objvo.Valor = lstConsulta[i].valor_movimento;
                objvo.Tipo = lstConsulta[i].tipo_movimento == 0 ? "Entrada" : "Saída";

                

                //Adiciona na lista de retorno
                lstRetorno.Add(objvo);
            }
            return lstRetorno;
        }

        public List<MovimentoVO> ConsultarMovimentoCategoria(int codUser, DateTime dtInicial, DateTime dtFinal, int idCategoria)
        {

            banco2 objBanco = new banco2();

            List<MovimentoVO> lstRetorno = new List<MovimentoVO>();
            List<tb_movimento> lstConsulta = new List<tb_movimento>();



            lstConsulta = objBanco.tb_movimento
           .Include("tb_conta")
           .Include("tb_categoria")
           .Include("tb_empresa")
           .Where(mov => mov.id_usuario == codUser
                  && mov.data_movimento >= dtInicial
                  && mov.data_movimento <= dtFinal
                  && mov.tb_categoria.id_categoria == idCategoria).ToList();



            for (int i = 0; i < lstConsulta.Count; i++)
            {
                //cria o obj
                MovimentoVO objvo = new MovimentoVO();

                //preenche as propriedades customizadas
                objvo.Conta = lstConsulta[i].tb_conta.nome_banco + " / Numero : " + lstConsulta[i].tb_conta.numero_conta;
                objvo.Categoria = lstConsulta[i].tb_categoria.nome_categoria;
                objvo.Empresa = lstConsulta[i].tb_empresa.nome_empresa;

                objvo.Data = lstConsulta[i].data_movimento.ToShortDateString();
                objvo.Valor = lstConsulta[i].valor_movimento;
                objvo.Tipo = lstConsulta[i].tipo_movimento == 0 ? "Entrada" : "Saída";



                //Adiciona na lista de retorno
                lstRetorno.Add(objvo);
            }
            return lstRetorno;
        }

        public List<MovimentoVO> ConsultarMovimentoEmpresa(int codUser, DateTime dtInicial, DateTime dtFinal, int idEmpresa)
        {

            banco2 objBanco = new banco2();

            List<MovimentoVO> lstRetorno = new List<MovimentoVO>();
            List<tb_movimento> lstConsulta = new List<tb_movimento>();



            lstConsulta = objBanco.tb_movimento
           .Include("tb_conta")
           .Include("tb_categoria")
           .Include("tb_empresa")
           .Where(mov => mov.id_usuario == codUser
                  && mov.data_movimento >= dtInicial
                  && mov.data_movimento <= dtFinal
                  && mov.tb_categoria.id_categoria == idEmpresa).ToList();



            for (int i = 0; i < lstConsulta.Count; i++)
            {
                //cria o obj
                MovimentoVO objvo = new MovimentoVO();

                //preenche as propriedades customizadas
                objvo.Conta = lstConsulta[i].tb_conta.nome_banco + " / Numero : " + lstConsulta[i].tb_conta.numero_conta;
                objvo.Categoria = lstConsulta[i].tb_categoria.nome_categoria;
                objvo.Empresa = lstConsulta[i].tb_empresa.nome_empresa;

                objvo.Data = lstConsulta[i].data_movimento.ToShortDateString();
                objvo.Valor = lstConsulta[i].valor_movimento;
                objvo.Tipo = lstConsulta[i].tipo_movimento == 0 ? "Entrada" : "Saída";



                //Adiciona na lista de retorno
                lstRetorno.Add(objvo);
            }
            return lstRetorno;
        }

    }
}
