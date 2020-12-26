using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmpresaDAO
    {
        public void InserirEmpresa(tb_empresa objEmpresa)
        {
            banco objBanco = new banco();

            objBanco.AddTotb_empresa(objEmpresa);

            objBanco.SaveChanges();
        }

        public List<tb_empresa> ConsultarEmpresas(int codUserLogado) {

            banco objBanco = new banco();

            List<tb_empresa> lstRetorno = objBanco.tb_empresa.Where(emp => emp.id_usuario == codUserLogado).ToList();

            return lstRetorno;
        }
    }
}
