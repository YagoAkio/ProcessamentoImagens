﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    public partial class ModalConfig : Form
    {
        public ModalConfig()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void ModalConfig_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fecha(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
