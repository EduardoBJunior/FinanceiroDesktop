using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaFuncao
{
    public partial class frmEx3 : Form
    {
        public frmEx3()
        {
            InitializeComponent();

        }

        private void btnFinalCompra_Click(object sender, EventArgs e)
        {
            double qtd1, qtd2, qtd3, qtd4, qtd5, mouse,teclado,dell,acer,pc, totalm,totalt,totald,totala,totalp;
            mouse = 25;
            teclado = 12;
            dell = 2500;
            acer = 3200;
            pc = 5000;
            
           qtd1 = Convert.ToDouble(txtMouse.Text.Trim() == "" ? 0 : Convert.ToDouble(txtMouse.Text.Trim()));
           qtd2 = Convert.ToDouble(txtTeclado.Text.Trim() == "" ? 0 : Convert.ToDouble(txtTeclado.Text.Trim()));
           qtd3 = Convert.ToDouble(txtDell.Text.Trim() == "" ? 0 : Convert.ToDouble(txtDell.Text.Trim()));
           qtd4 = Convert.ToDouble(txtAcer.Text.Trim() == "" ? 0 : Convert.ToDouble(txtAcer.Text.Trim()));
           qtd5 = Convert.ToDouble(txtPc.Text.Trim() == "" ? 0 : Convert.ToDouble(txtPc.Text.Trim()));

            
            lbResMouse.Text = Convert.ToString(totalm = CalcularTotalItem(mouse,qtd1));
            lbResTec.Text = Convert.ToString(totalt = CalcularTotalItem(teclado,qtd1));
            lbResDell.Text = Convert.ToString(totald = CalcularTotalItem(dell,qtd1));
            lbResAcer.Text = Convert.ToString(totala = CalcularTotalItem(acer,qtd1));
            lbResPC.Text = Convert.ToString(totalp = CalcularTotalItem(pc,qtd1));


            lbTotalGeral.Text = Convert.ToString(CalcularTotal(totalm,totalt,totald,totala,totalp));

            txtMouse.Text = "";
            txtTeclado.Text = "";
            txtDell.Text= "";
            txtAcer.Text= "";
            txtPc.Text = "";
        }
        //   private double Verificar(double n)
        //{
        //    if (n > 0 )
        //    {
        //         soma = soma + n;
        //    }
        //    return soma;
        //}

        private double CalcularTotalItem(double preco, double qtd)
        {
            return preco * qtd;
        }
        private double CalcularTotal(double n1,double n2,double n3,double n4, double n5)
        {
          
            return n1 + n2 + n3 + n4 + n5;
        }

        private void txtMouse_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
