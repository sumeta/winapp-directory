﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winapp_directory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Temp"))
            {
                MessageBox.Show("Directory Exists!", "OK");
            }
            else
            {
                MessageBox.Show("Directory not Exists!", "Error");
            }
        }
    }
}
