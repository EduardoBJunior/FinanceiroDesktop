using MySql.Data.MySqlClient;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO
    {

        string strCon = "server=localhost;database=db_financeiro;uid=root";

        //================================================================================
        public void InserirCategoriaProc(tb_categoria objCategoria)
        {
            //criar um obj de conexão, utilizando  a classe do MySQL
            MySqlConnection con = new MySqlConnection(strCon);

            // Criar um obj de configuração que será executado no BD

            MySqlCommand cmd = new MySqlCommand();

            //Configura o comando informado que será chamado uma procedore
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            //configurar o nome da proc
            cmd.CommandText = "sp_inserir_categoria";

            //configuar o obj da proc
            cmd.Connection = con;

            // configura os parametros para serem enviados para proc
            cmd.Parameters.AddWithValue("nome", objCategoria.nome_categoria);
            cmd.Parameters.AddWithValue("data_cadastro", objCategoria.DataCadastro_cat);
            cmd.Parameters.AddWithValue("id_user", objCategoria.id_usuario);

            try
            {
                //abrir a conexão
                cmd.Connection.Open();
                //executar
                cmd.ExecuteNonQuery();

            }
            catch
            {
                throw;

            }
            finally
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    //fecha a conexão 
                    cmd.Connection.Close();
                }
            }
        }

        public List<tb_categoria> ConsultarCategoriaProc(int codUserLogado)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            List<tb_categoria> lstRetorno = new List<tb_categoria>();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_consultar_categoria";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("cod_user", codUserLogado);

            try
            {
                cmd.Connection.Open();

                //executa e guarda a linha no objeto de leitura de dados
                MySqlDataReader dr = cmd.ExecuteReader();

                //percorre  as linhas retornadas e para cada iteração cria um onjeto com as informações da linha da vez.

                while (dr.Read())
                {
                    //cria o objeto
                    tb_categoria objCat = new tb_categoria();

                    //popula as priooridades deste obj de acordo  com as colunas das linhas
                    objCat.nome_categoria = dr["nome_categoria"].ToString();
                    objCat.id_categoria = Convert.ToInt32(dr["id_categoria"]);
                    objCat.DataCadastro_cat = Convert.ToDateTime(dr["DataCAdastro_cat"]);

                    //adiciona na lista de retorno;
                    lstRetorno.Add(objCat);
                }
                //verifica se encerrou as linhas
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
            return lstRetorno;
        }
        //================================================================================
        public void InserirCategoria(tb_categoria ObjCategoria)
{
    //cria o Objeto que representa o BD

    banco objbanco = new banco();

    //no meu obj banco, addicionar na tb categoria o obj do parametro de entrada
    objbanco.AddTotb_categoria(ObjCategoria);

    //salva no banco
    objbanco.SaveChanges();

}
        //================================================================================
        /// <summary>
        /// Retorna Todas as Categorias do usuario logado
        /// </summary>
        /// <param name="codUserLogado">Codigo Logado</param>
        /// <returns>Lista de Resultado</returns>
        public List<tb_categoria> ConsultarCategorias(int codUserLogado)
        {
            banco objbanco = new banco();
            List<tb_categoria> lstRetorno = objbanco.tb_categoria.Where(cat => cat.id_usuario == codUserLogado).ToList();

            return lstRetorno;
        }
        //=================================================================================
        public void AlterarCategoria(tb_categoria objCategoriaAtualizada)
        {

            banco objbanco = new banco();


            //resgata o registro antigo
            tb_categoria objResgate = objbanco.tb_categoria.Where(cat => cat.id_categoria == objCategoriaAtualizada.id_categoria).FirstOrDefault();

            //atualiza as informações
            objResgate.nome_categoria = objCategoriaAtualizada.nome_categoria;

            //Salva no Banco de dadso
            objbanco.SaveChanges();
        }
        //=================================================================================
        public void ExcluirCategoria(int codCategoria)
        {
            //
            banco objbanco = new banco();

            //resgata o registro
            tb_categoria objResgate = objbanco.tb_categoria.Where(cat => cat.id_categoria == codCategoria).FirstOrDefault();

            //deleta
            objbanco.DeleteObject(objResgate);
            //salvar
            objbanco.SaveChanges();
        }
    }
}
