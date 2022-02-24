using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RTadeusiewicz.NN.Example05
{
    /* 
     * This is the class of program's 'About...' box
     *
     */  
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }
    }
}