using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.CodeDom;

namespace DAO
{
    public class EmpresaDAO
    {
        string strCon = "server=localhost;database=db_financeiro2;uid=root";

        //============================================================================
        public void InserirEmpresaProc(tb_empresa objEmpresa)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "sp_inserir_empresa";

            cmd.Connection = con;

            cmd.Parameters.AddWithValue("nome",objEmpresa.nome_empresa);
            cmd.Parameters.AddWithValue("telefone",objEmpresa.tel_empresa);
            cmd.Parameters.AddWithValue("endereco",objEmpresa.endereco_empresa);
            cmd.Parameters.AddWithValue("site",objEmpresa.site_empresa);
            cmd.Parameters.AddWithValue("data_cadastro",objEmpresa.data_cadastro);
            cmd.Parameters.AddWithValue("id_user",objEmpresa.id_usuario);

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
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
            }

        }
        //=============================================================================
        public List<tb_empresa> ConsultarEmpresaProc(int codUserLogado)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();
            List<tb_empresa> lstRtorno = new List<tb_empresa>();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_consultar_empresa";
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
                    tb_empresa objEmp = new tb_empresa();

                    //pupula as propriedade de acordo com a coluna
                    objEmp.nome_empresa = dr["nome_empresa"].ToString();
                    objEmp.tel_empresa = dr["tel_empresa"].ToString();
                    objEmp.endereco_empresa = dr["endereco_empresa"].ToString();
                    objEmp.site_empresa = dr["site_empresa"].ToString();
                    objEmp.data_cadastro = Convert.ToDateTime(dr["data_cadastro"]);
                    objEmp.id_empresa = Convert.ToInt32(dr["id_empresa"]);

                    //adicionar  na lista de retorno
                    lstRtorno.Add(objEmp);

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
        //=========================================================================
        public void AlterarEmpresaProc( tb_empresa objEmpresaAtualizada)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "sp_alterar_empresa";

            cmd.Connection = con;

            cmd.Parameters.AddWithValue("nome_empresa", objEmpresaAtualizada.nome_empresa);
            cmd.Parameters.AddWithValue("tel_empresa", objEmpresaAtualizada.tel_empresa);
            cmd.Parameters.AddWithValue("endereco_empresa", objEmpresaAtualizada.endereco_empresa);
            cmd.Parameters.AddWithValue("site_empresa", objEmpresaAtualizada.site_empresa);
            cmd.Parameters.AddWithValue("id_emp", objEmpresaAtualizada.id_empresa);

            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                if (cmd.Connection.State == System.Data.ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                throw;
            }
        }
        //=========================================================================
        public void ExcluirEmpresaProc(int codEmpresa)
        {
            MySqlConnection con = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.CommandText = "sp_excluir_empresa";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("idEmpresa",codEmpresa);

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
        //=========================================================================
        public void InserirEmpresa(tb_empresa ObjEmpresa)
        {
            banco2 objbanco = new banco2();

            objbanco.AddTotb_empresa(ObjEmpresa);

            objbanco.SaveChanges();
        }
        //=============================================================================
        public List<tb_empresa> ConsultarEmpresa(int idCodUser)
        {
            banco2 objbanco = new banco2();

            List<tb_empresa> lstRetorno = objbanco.tb_empresa.Where(emp => emp.id_usuario == idCodUser).ToList();

            return lstRetorno;
        }

        //========================================================================
        public void AlterarEmpresa(tb_empresa objEmpresaAtualizada)
        {
            banco2 ObjBanco2 = new banco2();

            tb_empresa objResgate = ObjBanco2.tb_empresa.Where(emp => emp.id_empresa == objEmpresaAtualizada.id_empresa).FirstOrDefault();

            objResgate.nome_empresa = objEmpresaAtualizada.nome_empresa;
            objResgate.tel_empresa = objEmpresaAtualizada.tel_empresa;
            objResgate.endereco_empresa = objEmpresaAtualizada.endereco_empresa;
            objResgate.site_empresa = objEmpresaAtualizada.site_empresa;

            ObjBanco2.SaveChanges();
        }
        //=======================================================================

        public void ExcluirEmpresa(int codEmpresa)
        {
            banco2 objBanco = new banco2();

            tb_empresa objResgate = objBanco.tb_empresa.Where(emp => emp.id_empresa == codEmpresa).FirstOrDefault();

            objBanco.DeleteObject(objResgate);

            objBanco.SaveChanges();
        }
    }
}
