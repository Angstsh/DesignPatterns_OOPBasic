﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOriented
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatShout_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat("小咪");
            cat.ShoutNum = 5;
            MessageBox.Show(cat.Shout());
        }
    }
}
