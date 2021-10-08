using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.Text = listBox1.Text;

            Form1 form = new Form1();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             listBox1.Items.Add(richTextBox1.Text);
        }
    }
}
