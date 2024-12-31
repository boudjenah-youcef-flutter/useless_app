using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace demo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var name = text_name.Text;
            textc_chow.Text = name;
        }

        private void text_name_TextChanged(object sender, EventArgs e)
        {
          

        }

        private void rest_Click(object sender, EventArgs e)
        {
            textc_chow.ResetText();
            text_name.Clear();
        }
    }
}
