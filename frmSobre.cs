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
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();
        }

        private void btnWhatsaapp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://api.whatsapp.com/send?phone=5515988151683");
        }
    }
}
