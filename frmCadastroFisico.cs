using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoaFisica
{
    public partial class frmCadastroFisico : Form
    {
        public frmCadastroFisico()
        {
            InitializeComponent();
        }

        private void frmCadastroFisico_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Keys.Tab)
            {
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txtCep.Text);

                DataSet ds = new DataSet();
                ds.ReadXml(xml);

                txtEndereco.Text = ds.Tables[0].Rows[0]["Logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["Bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["Cidade"].ToString();
                cmbUf.Text = ds.Tables[0].Rows[0]["UF"].ToString();
                txtLogradouro.Text = ds.Tables[0].Rows[0][5].ToString();

                txtNumero.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBairro.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCnpj.Clear();
            txtCriacao.Clear();
            txtEndereco.Clear();
            txtFantasia.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtObservacao.Clear();
            txtRazaoSocial.Clear();
            txtRazaoSocial.Focus();
        }
    }
}
