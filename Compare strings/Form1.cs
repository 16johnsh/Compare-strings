using System;
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

        public bool validateUserInput(string userInput)
        {
            bool valid = true;
            if (userInput.Length == 0)
            {                
                valid = false;
            }

            return valid;
        }
        
        private void txtx_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txty_TextChanged(object sender, EventArgs e)
        {
            
        }       

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string inputX = txtx.Text;
            string inputY = txty.Text;

            if (validateUserInput(inputX) == false)
            {
                MessageBox.Show("Please enter a value for stringX");
            }

            if (validateUserInput(inputY) == false)
            {
                MessageBox.Show("Please enter a value for stringY");
            }
        }

        private void lbly_Click(object sender, EventArgs e)
        {

        }

        private void StringComparer_Load(object sender, EventArgs e)
        {

        }
    }

}
