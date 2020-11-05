using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class MovimentoVO
    {
        public string Data{ get; set; }
        public decimal Valor { get; set; }
        public string Obs { get; set; }
        public string Categoria { get; set; }
        public string Empresa { get; set; }
        public string  Conta { get; set; }
        public string Tipo { get; set; }
        public tb_movimento objMov { get; set; }
    }
}
