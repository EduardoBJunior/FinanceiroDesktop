using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasGenericas
{
    public partial class frmEX5 : Form
    {
        public frmEX5()
        {
            InitializeComponent();
        }
        string nome, materia, situacao;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            double media, nota1, nota2, nota3, nota4;

           

            VerificarCampos();

            nome = txtNome.Text.Trim();
            materia = TxtMateria.Text.Trim();
            nota1 = Convert.ToDouble(txtNota1.Text.Trim() == "" ? 0 : Convert.ToDouble(txtNota1.Text.Trim()));
            nota2 = Convert.ToDouble(txtNota2.Text.Trim() == "" ? 0 : Convert.ToDouble(txtNota2.Text.Trim()));
            nota3 = Convert.ToDouble(txtNota3.Text.Trim() == "" ? 0 : Convert.ToDouble(txtNota3.Text.Trim()));
            nota4 = Convert.ToDouble(txtNota4.Text.Trim() == "" ? 0 : Convert.ToDouble(txtNota4.Text.Trim()));

            media = CalcularMedia(nota1,nota2,nota3,nota4);

            if (media <= 0)
            {
                lbResultado.Text = "Preencha os campos e Calcule novamente!";
                txtNome.Focus();
            }
            else
            {
                lbResultado.Text = nome + "  Sua Situação na matéria de " + materia + " é : " + VerificarSituacao(media);
            }
           

            LimparCampos();
        }

        private string VerificarSituacao(double media)
        {
            
             if (media < 39)
            {
                situacao = "Reprovado!";
                lbResultado.ForeColor = Color.Red;
            } else if (media >= 40 && media <= 59) {
                situacao = "Exame!";
                lbResultado.ForeColor = Color.Gold;
            } else if (media >=60)
            {
                situacao = "Aprovado!";
                lbResultado.ForeColor = Color.Blue;
            }
            return situacao;
        }
        private void VerificarCampos()
        {
            if (txtNome.Text.Trim() == "" || TxtMateria.Text.Trim() == "" || txtNota1.Text.Trim() == "" || txtNota2.Text.Trim() == "" || txtNota3.Text.Trim() == "" || txtNota4.Text.Trim() == "")
            {
                MessageBox.Show("Preencha Todos os Campos!");
                
            }
           
        }
        //private void VerificarCampos(string nome, string materia, double n1, double n2, double n3, double n4)
        //{
        //    if (txtNome.Text.Trim() == "")
        //    {
        //        MessageBox.Show("Me diga seu Nome como devo chamar você?!");
        //        txtNome.Focus();
        //        return ;

        //    }
        //     if (TxtMateria.Text.Trim() == "")
        //     {
        //        MessageBox.Show("Não esqueça de informar sua Materia!");
        //        TxtMateria.Focus();
        //        return ;
        //     }
        //     if (txtNota1.Text.Trim() == "")
        //    {

        //        MessageBox.Show("Não esqueça de informar sua nota!");
        //        txtNota1.Focus();
        //            return ;
        //        }
        //     if (txtNota2.Text.Trim() == "")
        //    {

        //        MessageBox.Show("Não esqueça de informar sua nota!");
        //        txtNota2.Focus();
        //            return ;
        //        }
        //     if (txtNota3.Text.Trim() == "")
        //    {

        //        MessageBox.Show("Não esqueça de informar sua nota!");
        //        txtNota3.Focus();
        //            return ;
        //        }
        //     if (txtNota4.Text.Trim() == "")
        //    {

        //        MessageBox.Show("Não esqueça de informar sua nota!");
        //        txtNota4.Focus();
        //            return ;
        //        }
        //if (txtNome.Text.Trim() != "" && TxtMateria.Text.Trim() != "" && txtNota1.Text.Trim() != "" && txtNota2.Text.Trim() != "" && txtNota3.Text.Trim() != "" && txtNota4.Text.Trim() != "")
        //{

        //}
    //}

         private double CalcularMedia(double n1, double n2,double n3, double n4)
         {
            double peso = 60;
            return  (n1 + n2 + n3 + n4) / 6;
            

         }
        private void LimparCampos()
        {
            txtNome.Text = ""; 
            TxtMateria.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
           
        }
    }
}
