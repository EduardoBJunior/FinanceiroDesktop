using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaObj
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        List<MateriaVO> lstMateria = new List<MateriaVO>();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome, materia, situacao;
            double n1, n2, n3, n4, media;
            MateriaVO aluno;
            int cod, idxLinha;

            cod = Int32.Parse(txtCod.Text.Trim());
            nome = txtNome.Text.Trim() != "" ? txtNome.Text.Trim(): "0";
            materia = txtMateria.Text.Trim() != "" ? txtMateria.Text.Trim().ToUpper() : "0";
            n1 = txtN1.Text.Trim() != "" ? Convert.ToDouble(txtN1.Text.Trim()) : 0;
            n2 = txtN2.Text.Trim() != "" ? Convert.ToDouble(txtN2.Text.Trim()) : 0;
            n3 = txtN3.Text.Trim() != "" ? Convert.ToDouble(txtN3.Text.Trim()) : 0;
            n4 = txtN4.Text.Trim() != "" ? Convert.ToDouble(txtN4.Text.Trim()) : 0;

            VerificaCampos(nome, materia, n1, n2, n3, n4);

            media = CalcularMedia(n1,n2,n3,n4);

            situacao = VerificaSituacao(media);

            aluno = CriarObjMAteria(cod,nome,materia,media,situacao);

            AdicionarAluno(aluno);

            CarregarGrid();

            LimparCampos();



        }
        //============================================================
        private void  VerificaCampos(string nome, string materia,double n1,double n2,double n3,double n4 )
        {
            if (nome == "0")
            {
                MessageBox.Show("Prencha o campo Nome!");
                txtNome.Focus();
                return ;
            }
            if(materia == "0")
            {
                MessageBox.Show("Prencha o campo Materia!");
                txtMateria.Focus();
                return;
            }
            if (n1 == 0)
            {
                MessageBox.Show("Prencha o campo Nota 1!");
                txtN1.Focus();
                return;
            }
            
            if (n2 == 0)
            {
                MessageBox.Show("Prencha o campo Nota 2!");
                txtN2.Focus();
                return;
            }
            
            if (n3 == 0)
            {
                MessageBox.Show("Prencha o campo Nota 3!");
                txtN3.Focus();
                return;
            }
            
            if (n4 == 0)
            {
                MessageBox.Show("Prencha o campo Nota 4!");
                txtN4.Focus();
                return;
            }

        }

        //============================================================
        private MateriaVO CriarObjMAteria (int cod, string nome, string materia, double media, string situacao)
        {
            MateriaVO vo = new MateriaVO();

            vo.Codigo= cod;
            vo.Nome = nome;
            vo.Materia = materia;
            vo.Media = media;
            vo.Situacao = situacao;
            

            return vo;
        }
        //============================================================
        private void AdicionarAluno(MateriaVO mat)
        {
            lstMateria.Add(mat);
        }
        //============================================================
        public double CalcularMedia(double n1, double n2 ,double n3, double n4)
        {
            double media = (n1 + n2 + n3 + n4) / 4;

            return media;
        }
        //============================================================
        public string VerificaSituacao(double media)
        {
            string situacao;
            if (media <=39)
            {
                situacao = "REPROVADO";
            }
            else if (media >= 40 && media <= 59)
            {
                situacao = "EXAME";
            }
            else
            {
                situacao = "APROVADO";
            }

            return situacao;
        }
        //============================================================
        public void CarregarGrid()
        {
            grdMedia.DataSource = null;
            grdMedia.DataSource = lstMateria;
        }
        //============================================================
        public void LimparCampos()
        {
            txtCod.Text = "";
            txtMateria.Text = "";
            txtNome.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";
            
        }
        //============================================================
        private void txtPesMat_TextChanged(object sender, EventArgs e)
        {
            grdMedia.DataSource = null;
            if (txtPesMat.Text.Trim() == "")
            {
                grdMedia.DataSource = lstMateria;
            }
            else
            {
                grdMedia.DataSource = lstMateria.Where(mat => mat.Materia.Contains(txtPesMat.Text.Trim().ToUpper())).ToList();
            }
        }

        private void txtPesSit_TextChanged(object sender, EventArgs e)
        {
            grdMedia.DataSource = lstMateria.Where(sit => sit.Situacao.Contains(txtPesSit.Text.Trim().ToUpper())).ToList();
        }

        private void Ex2_Load(object sender, EventArgs e)
        {

        }

        private void grdMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMedia.RowCount >0)
            {
                //recuperar o onjeto da linha clicada 

            }
        }
    }
}
