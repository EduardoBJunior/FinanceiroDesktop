using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO
    {
        //============================================================================
        /*Para inserir a senha e so adicionar PWR = senha*/
        string strCon = "server=localhost;database=db_financeiro2;uid=root";
        //========================================================================
        //reescrever o Inserir Categria com o uso de proc
        public void InsereriCategoriaProc(tb_categoria objCategoria)
        {
            //1º passo - Criar um obj de conexão, utilizando a classe do banco(MySql)
            MySqlConnection con = new MySqlConnection(strCon);

            //2º passo - criar um obj de configuração que sera executado no bando 
            MySqlCommand cmd = new MySqlCommand();

            //3º passo - Configura o comando informado que será chamado uma procedure
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            // 4º Configurar o nome da proc
            cmd.CommandText = "sp_inserir_categoria";

            //5 º Configurar o obj de conexao

            cmd.Connection = con;

            //6 º configura os parametros para serem enviados para a proc
            cmd.Parameters.AddWithValue("nome", objCategoria.nome_categoria);
            cmd.Parameters.AddWithValue("data_cadastro", objCategoria.data_cadastro);
            cmd.Parameters.AddWithValue("id_user", objCategoria.id_usuario);

            //Verificar se será gravado com sucesso no banco
            try
            {
                //Abrir a conexão
                cmd.Connection.Open();
                //Executar a proc
                cmd.ExecuteNonQuery();

            }
            catch
            {

                throw;
            }
            finally
            {
                //esse bloco sempre será executado
                //utilizamos para fechar a conexão com o banco 
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }
        //============================================================================
        public void InserirCategoria(tb_categoria objCategoria)
        {
            // Cria o obj que representa o BD
            banco2 objbanco = new banco2();

            // No meu obj banco add an tb categoria o obj do parametro de entrada 
            objbanco.AddTotb_categoria(objCategoria);

            // Salava no BD
            objbanco.SaveChanges();
        }
        //============================================================================
        public List<tb_categoria> ConsultarCategoriaProc(int codUserLogado)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            List<tb_categoria> lstRtorno = new List<tb_categoria>();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_consultar_categoria";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("cod_user", codUserLogado);

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
                    tb_categoria objCat = new tb_categoria();

                    //pupula as propriedade de acordo com a coluna
                    objCat.nome_categoria = dr["nome_categoria"].ToString();
                    objCat.id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    objCat.data_cadastro = Convert.ToDateTime(dr["data_cadastro"]);

                    //adicionar  na lista de retorno
                    lstRtorno.Add(objCat);

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

        //===========================================================================
        /// <summary>
        /// Retorna todas as categorias do usuario logado;
        /// </summary>
        /// <param name="codUserLogado">Codigo do Logado</param>
        /// <returns>Lista de resultado</returns>
        public List<tb_categoria> ConsultarCategoria(int codUserLogado)
        {
            banco2 objBanco = new banco2();

            List<tb_categoria> lstRetorno = objBanco.tb_categoria.Where(cat => cat.id_usuario == codUserLogado).ToList();

            return lstRetorno;
        }
        //============================================================================
        public void AlterarCategoriaProc(tb_categoria ObjCategoriaAtualizada)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_alterar_categoria";
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("nome",ObjCategoriaAtualizada.nome_categoria);
            cmd.Parameters.AddWithValue("id_cat", ObjCategoriaAtualizada.id_categoria);

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
        public void AlterarCategoria(tb_categoria objCategoriaAtualizada)
        {
            //1º passo
            //conexão com o banco
            banco2 objBanco2 = new banco2();

            //resgata o registro antigo
            tb_categoria ObjResgate = objBanco2.tb_categoria.Where(cat => cat.id_categoria == objCategoriaAtualizada.id_categoria).FirstOrDefault();

            //2º passo
            //atualiza as informações
            ObjResgate.nome_categoria = objCategoriaAtualizada.nome_categoria;

            // Salva a alteração
            objBanco2.SaveChanges();


        }
        //============================================================================
        public void ExcluirCategoria(int codCategoria)
        {
            banco2 objBanco = new banco2();

            tb_categoria objResgate = objBanco.tb_categoria.Where(cat => cat.id_categoria == codCategoria).FirstOrDefault();

            objBanco.DeleteObject(objResgate);

            objBanco.SaveChanges();
        }
        //============================================================================
        public void ExcluirCategoriaProc(int id_cat)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_excluir_categoria";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("id_cat", id_cat);

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
