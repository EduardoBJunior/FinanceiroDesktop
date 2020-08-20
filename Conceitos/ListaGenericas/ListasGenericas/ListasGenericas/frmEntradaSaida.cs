using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasGenericas
{
    public partial class frmEntradaSaida : Form
    {
        public frmEntradaSaida()
        {
            InitializeComponent();
        }
        List<string> ListMeses = new List<string>();
        List<double> ListEntrada = new List<double>();
        List<double> ListSaida = new List<double>();
        List<double> ListTotalMes = new List<double>();
        double vlrGeral, vlrJaneiro, vlrFevereiro;
        
        

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string mes, tipo, valor;

            

            mes = Convert.ToString(cbxMes.SelectedItem);
            tipo = Convert.ToString(cbxTipo.SelectedItem);
            valor = txtValor.Text.Trim();
            

            VerificarCampos(mes,tipo,valor);
            VerificaTipo(tipo,double.Parse(valor));
            

            
            CarregarListas();
            

            if (vlrGeral < 0)
            {
                lbTGeral.ForeColor = Color.Red;
            }
            else
            {
                lbTGeral.ForeColor = Color.Blue;
            }
            lbTGeral.Text = "O Valor Geral é :"+Convert.ToString(vlrGeral);

            LimparCampos();
        }

        private void VerificarCampos(string mes, string tipo, string valor)
        {
            if (mes != "" && tipo != "" && valor != "")
            {
                ListMeses.Add(mes);
                
            }
            else
            {
                MessageBox.Show("Preencha os Campos Corretamente");
                return;
            }
            
        }
        //private void CalcularTotalMes(string mes,string tipo, double valor)
        //{
        //    if (cbxMes.SelectedItem.Equals("Janeiro"))
        //    {
                
        //        if (tipo == "Entrada")
        //        {
        //            vlrJaneiro += valor;
        //        }
        //        else
        //        {
        //           vlrJaneiro -= valor;
        //        }
                
        //    }
        //    else if (cbxMes.SelectedItem.Equals("Fevereiro"))
        //    {
               
        //        if (tipo == "Entrada")
        //        {
        //            vlrFevereiro += valor;
        //        }
        //        else
        //        {
        //          vlrFevereiro -= valor;
        //        }

        //    }

        //}
        
        private void VerificaTipo(string tipo, double valor)
        {
            if (tipo == "Entrada")
            {
                ListEntrada.Add(valor);
                vlrGeral += valor;
                

            }
            else
            {
                ListSaida.Add(valor);
                vlrGeral -= valor;
               
            }
            
        }
       

       

        private void LimparCampos()
        {
            cbxMes.SelectedIndex = -1;
            cbxTipo.SelectedIndex = -1;
            txtValor.Text = "";

        }
        private void CarregarListas()
        {
            ltbxMes.DataSource = null;
            ltbxEntrada.DataSource = null;
            ltbxSaida.DataSource = null;
            
            ltbxMes.DataSource = ListMeses;
            ltbxEntrada.DataSource = ListEntrada;
            ltbxSaida.DataSource = ListSaida;
            

        }

       

        
    }
}