﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddInventory
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            if(ActiveMdiChild==null)
            {
              ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild !=  null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        
    }
    }
}
