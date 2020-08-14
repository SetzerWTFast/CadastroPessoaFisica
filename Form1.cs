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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            tspData.Text = DateTime.Now.ToLongDateString();
        }

        private void timeHora_Tick(object sender, EventArgs e)
        {
            tspHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void pessoaFísicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFisico Cadastro = new frmCadastroFisico();
            Cadastro.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre Sobre = new frmSobre();
            Sobre.Show();
        }

        private void pessoaFísicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaFisico Consulta = new frmConsultaFisico();
            Consulta.Show();
        }
    }
}
