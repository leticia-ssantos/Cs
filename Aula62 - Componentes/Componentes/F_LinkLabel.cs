﻿using System;
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
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0,6,"www.google.com.br");
            ll_multiplosLinks.Links.Add(9, 5, "www.youtube.com/cfbcursos");
            ll_multiplosLinks.Links.Add(17, 7, "www.youtube.com.br");

            ll_multiplosLinks.Links[2].Enabled = false;
        }

        private void ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://youtube.com/cfbcursos?nome"+tb_nome.Text);
            
            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited= true;
        }

        private void ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            e.Link.Visited = true;
        }
    }
}
