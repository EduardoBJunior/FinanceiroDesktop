using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaObj
{
    public partial class frmCrudEx1 : Form
    {
        public frmCrudEx1()
        {
            InitializeComponent();
            LimparCampos();
        }

        
        List<CrudMediaVO> lstMedia = new List<CrudMediaVO>();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, materia, situacao;
           double n1, n2, n3, n4;
           double media;
           int cod;
           CrudMediaVO aluno ;

            cod = Convert.ToInt32( txtCod.Text.Trim());
            if (VerificarCodigoRepetido(cod))
            {
                nome = txtNome.Text.Trim();
                materia = txtMateria.Text.Trim().ToUpper();
                n1 = Convert.ToDouble(txtN1.Text.Trim() != "" ? txtN1.Text.Trim() : "0");
                n2 = Convert.ToDouble(txtN2.Text.Trim() != "" ? txtN2.Text.Trim() : "0");
                n3 = Convert.ToDouble(txtN3.Text.Trim() != "" ? txtN3.Text.Trim() : "0");
                n4 = Convert.ToDouble(txtN4.Text.Trim() != "" ? txtN4.Text.Trim() : "0");

                media = CalcuarMedia(n1, n2, n3, n4);

                situacao = VerificarSituacao(media);

                aluno = CriarObjALuno(cod, nome, materia, situacao, media,n1,n2,n3,n4);

                AdicionarAluno(aluno);

                CarregarGrid();

               

                LimparCampos();

            }
            else
            {
                MessageBox.Show("Codigo ja Existente, Digite outro!");
            }
            


            //int campos = VerificarCampos(cod, nome, materia, n1, n2, n3, n4);

           

            //switch (campos)
            //{
            //    case 1 :
            //    MessageBox.Show("Digite o nome do Aluno");
            //    txtNome.Focus();
            //    break;
            //    case 2:
            //        MessageBox.Show("Digite a Materia a ser Cadastrada");
            //        txtMateria.Focus();
            //        break;
            //    case 3:
            //        MessageBox.Show("Digite a Primeira nota");
            //        txtN1.Focus();
            //        break;
            //    case 4:
            //        MessageBox.Show("Digite a Segunda nota");
            //        txtN2.Focus();
            //        break;
            //    case 5:
            //        MessageBox.Show("Digite a Terceira nota");
            //        txtN3.Focus();
            //        break;
            //    case 6:
            //        MessageBox.Show("Digite a Quarta nota");
            //        txtN4.Focus();
            //        break;
            //    case 7:
            //        MessageBox.Show("Digite o Codigo do registro");
            //        txtCod.Focus();
            //        break;
            //    case 0:
            //        MessageBox.Show("Cadastrado Com Sucesso");
            //        LimparCampos();
            //        break;
            //}
      
             


        }
        //======================================================================================

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            btnCadastrar.Enabled = true;
        }
        //======================================================================================

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string nome, materia;
            double n1, n2, n3, n4,media;
            int PosLinha,cod;

            PosLinha = Convert.ToInt32(txtPosLinha.Text);
            cod = Convert.ToInt32(txtCod.Text);
            nome = txtNome.Text.Trim();
            materia = txtMateria.Text.ToUpper().Trim();
            n1 = Convert.ToDouble(txtN1.Text.Trim());
            n2 = Convert.ToDouble(txtN2.Text.Trim());
            n3 = Convert.ToDouble(txtN3.Text.Trim());
            n4 = Convert.ToDouble(txtN4.Text.Trim());

            media = CalcuarMedia(n1, n2, n3, n4);


            lstMedia[PosLinha].Cod = cod;
            lstMedia[PosLinha].Nome = nome;
            lstMedia[PosLinha].Materia = materia;
            lstMedia[PosLinha].N1 = n1;
            lstMedia[PosLinha].N2 = n2;
            lstMedia[PosLinha].N3 = n3;
            lstMedia[PosLinha].N4 = n4;
            lstMedia[PosLinha].Media = media;
            lstMedia[PosLinha].Situacao = VerificarSituacao(media);
            

            CarregarGrid();
            LimparCampos();
        }   
        //======================================================================================

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int PosLinha;
            PosLinha = Convert.ToInt32(txtPosLinha.Text);

            lstMedia.RemoveAt(PosLinha);

            CarregarGrid();
            LimparCampos();
        }
        //======================================================================================

        private CrudMediaVO CriarObjALuno(int cod, string nome, string materia, string situcao,double n1,double n2,double n3,double n4, double media)
        {
            CrudMediaVO aluno = new CrudMediaVO();

            aluno.Cod = cod;
            aluno.Nome = nome;
            aluno.Materia = materia;
            aluno.Media = media;
            aluno.Situacao = situcao;
            aluno.N1 = n1;
            aluno.N2 = n2;
            aluno.N3 = n3;
            aluno.N4 = n4;

            return aluno;
        }
        //======================================================================================

        private void AdicionarAluno(CrudMediaVO Aluno)
        {
            lstMedia.Add(Aluno);
        }
        //======================================================================================

        private void CarregarGrid()
        {
           
            grdMedia.DataSource = null;
            grdMedia.DataSource = lstMedia;

            grdMedia.Columns["N1"].Visible = false;
            grdMedia.Columns["N2"].Visible = false;
            grdMedia.Columns["N3"].Visible = false;
            grdMedia.Columns["N4"].Visible = false;
        }
        //======================================================================================

        private int VerificarCampos(int cod,string nome,string materia, double n1, double n2,double n3,double n4)
        {
            if (cod <= 0 )
            {
                return 7;
            }   
            if (nome == "" || nome ==null )
            {
                return 1;
            }
            if (materia =="" || materia ==null)
            {
                return 2;
            }
            if (n1 <=0 )
            {
                return 3;
            }
            if (n2 <= 0)
            {
                return 4;
            }
            if (n3 <= 0)
            {
                return 5;
            }
            if (n4 <= 0)
            {
                return 6;
            }
            return 0;
        }
        //======================================================================================

        private double CalcuarMedia(double n1, double n2, double n3, double n4) {

            double media = (n1 + n2 + n3 + n4)/4;

            return media;
        }
        //======================================================================================

        public string VerificarSituacao(double media)
        {
            string situacao;

            if (media >=0 && media <=39)
            {
                situacao = "REPROVADO";
            }
            else if (media >= 40 && media <=59)
            {
                situacao = "EXAME";
            }
            else 
            {
                situacao = "APROVADO";
            }

            return situacao;
        }
        //======================================================================================

        private void LimparCampos()
        {
            txtCod.Text = "";
            txtNome.Text = "";
            txtMateria.Text = "";
            txtN1.Text = "";
            txtN2.Text = "";
            txtN3.Text = "";
            txtN4.Text = "";

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            
        }
        //=======================================================================================

        private bool VerificarCodigoRepetido(int cod)
        {
            bool ret = true;
            for (int i = 0; i < lstMedia.Count; i++)
            {
                if (cod == lstMedia[i].Cod)
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }
        //=======================================================================================

        private void grdMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdMedia.RowCount > 0)
            {
                CrudMediaVO AlunoClicado = (CrudMediaVO)grdMedia.CurrentRow.DataBoundItem;

                txtCod.Text = AlunoClicado.Cod.ToString();
                txtNome.Text = AlunoClicado.Nome;
                txtMateria.Text = AlunoClicado.Materia;
                txtN1.Text = AlunoClicado.N1.ToString();
                txtN2.Text = AlunoClicado.N2.ToString();
                txtN3.Text = AlunoClicado.N3.ToString();
                txtN4.Text = AlunoClicado.N4.ToString();

                txtPosLinha.Text = e.RowIndex.ToString();

                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCadastrar.Enabled = false;

            }
        }
        //=======================================================================================

        private void txt_TextChanged(object sender, EventArgs e)
        {
            grdMedia.DataSource = null;

            if (txtPesquisa.Text =="")
            {
                grdMedia.DataSource = lstMedia;
            }
            else
            {
                grdMedia.DataSource = lstMedia.Where(aluno => aluno.Materia.Contains(txtPesquisa.Text.Trim().ToUpper()));
            }
        }
    }
}
