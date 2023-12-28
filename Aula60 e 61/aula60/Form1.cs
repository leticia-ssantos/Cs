using System;
using System.Windows.Forms;

namespace aula60
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_texto_Click(object sender, EventArgs e)
        {
            
            lb_texto.Text = tb_texto.Text;

        }
    }
}
