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
    public partial class ListaFrmObjExemplo : Form
    {
        public ListaFrmObjExemplo()
        {
            InitializeComponent();
        }

        //===================================================================
        //variaveis Globais
        List<PessoaVO> lstPessoas = new List<PessoaVO>();

        //===================================================================
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nome, endereco;
            int idade;
            PessoaVO voRecebe;

            nome = txtNome.Text.Trim();
            endereco = txtEndereco.Text.Trim();
            idade = Convert.ToInt32(txtIdade.Text);

            voRecebe =  CriarObj(nome,endereco,idade);

            AddPessoa(voRecebe);
            CarregarGrid();
            LimparCampos();

        }

        //===================================================================
        private PessoaVO CriarObj(string nome,string endereco,int idade)
        {
            PessoaVO vo = new PessoaVO();

            vo.Nome = nome;
            vo.Endereco = endereco;
            vo.Idade =idade;

            return vo;
        }

        //===================================================================
        private void AddPessoa(PessoaVO vo)
        {
            lstPessoas.Add(vo);
        }

        //===================================================================

        private void CarregarGrid()
        {
            grdRes.DataSource = null;
            grdRes.DataSource = lstPessoas;
        }
        //===================================================================

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtIdade.Text = "";
        }
        //===================================================================
        private void PesquisarNome()
        {
            grdRes.DataSource = null;
            if (txtNomePesq.Text.Trim() =="")
            {
                grdRes.DataSource = lstPessoas;
            }
            else
            {
                grdRes.DataSource = lstPessoas.Where(pess => pess.Nome.Contains(txtNomePesq.Text.Trim())).ToList();
            }
            
        }
        //===================================================================
        private void txtNomePesq_TextChanged(object sender, EventArgs e)
        {
            PesquisarNome();
        }
        //===================================================================
        private void btnPesq_Click(object sender, EventArgs e)
        {
            PesquisarIdade();
        }
        //===================================================================
        private void PesquisarIdade()
        {
            grdRes.DataSource = null;
            if (txtPesqIdade.Text.Trim() == "")
            {
                grdRes.DataSource = lstPessoas;
            }
            else
            {
                grdRes.DataSource = lstPessoas.Where(pess => pess.Nome.Contains(txtPesqIdade.Text.Trim())).ToList();
            }

        }
    }
}
