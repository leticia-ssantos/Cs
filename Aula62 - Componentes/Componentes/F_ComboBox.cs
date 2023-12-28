using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_comboBox : Form
    {
        public F_comboBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_tranposrtes.Text);
        }

        private void btn_limparElemnetos_Click(object sender, EventArgs e)
        {
            cb_tranposrtes.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cb_tranposrtes.Items.Add("Carro");
            cb_tranposrtes.Items.Add("Aviao");
            cb_tranposrtes.Items.Add("Navio");
            cb_tranposrtes.Items.Add("Onibus");
            cb_tranposrtes.Items.Add("Trem");
        }

        private void cb_tranposrtes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_tranporte.Text = cb_tranposrtes.Text;

        }

        private void btn_adicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            
            if(tb_tranporte.Text != "")
            {
                if(cb_tranposrtes.FindString(tb_tranporte.Text)<0)
                cb_tranposrtes.Items.Add(tb_tranporte.Text);
            }
        }
    }
}
