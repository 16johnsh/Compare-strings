﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compare_strings
{
    public partial class StringComparer : Form
    {
        public StringComparer()
        {
            InitializeComponent();
        }

        private void lbly_Click(object sender, EventArgs e)
        {

        }

        private void StringComparer_Load(object sender, EventArgs e)
        {

        }

        private void txtx_TextChanged(object sender, EventArgs e)
        {
            
        }

        public bool validateUserInput(string userInput)
        {
            if(userInput.Length == 0)
            {
                Message = "you need to enter a string";
            }
        }
    }
}
