using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nicolemills_module5activity
{
    public partial class Form1 : Form
    {
        string filename;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpen = new OpenFileDialog
            {
                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
            };

            if (fileOpen.ShowDialog() == DialogResult.OK)
            {
                filename = fileOpen.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
