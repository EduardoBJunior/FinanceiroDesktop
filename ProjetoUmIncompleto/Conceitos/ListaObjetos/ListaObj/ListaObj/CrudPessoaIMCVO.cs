using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ListaObj
{
    class CrudPessoaIMCVO
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public double IMC { get; set; }
        public string Classificacao { get; set; }
    }
}
