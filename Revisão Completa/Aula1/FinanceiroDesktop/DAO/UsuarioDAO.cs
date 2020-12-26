using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class UsuarioDAO
    {

        public void CriarConta(tb_ususario objUser)
        {
            banco2 objbanco = new banco2();

            objbanco.AddTotb_ususario(objUser);
            objbanco.SaveChanges();
        }

        public int ValidarLogin(string email,string senha)
        {
            banco2 objbanco = new banco2();

            tb_ususario objUser = objbanco.tb_ususario.FirstOrDefault(use => use.email_usuario == email && use.senha_usuario == senha);

            //verificar se encontrou 

            if (objUser == null)
            {
                return -1;
            }
            else
            {
                return objUser.id_usuario;
            }


           
        }

        public void  CadastrarUsuario(tb_ususario ObjUsuario)
        {
            banco2 objBanco = new banco2();

            objBanco.AddTotb_ususario(ObjUsuario);

            objBanco.SaveChanges();

        }
    }
}
