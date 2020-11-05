using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ContaVO
    {
        public string NomeBanco { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public string Saldo { get; set; }
        public string Tipo { get; set; }

        public tb_conta objConta { get; set; }
    }
}
