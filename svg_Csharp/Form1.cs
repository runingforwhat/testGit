using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SvgNet;

namespace svg_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
                //string filename = openFileDialog1.FileName;
                string filename = "C:\\Users\\liu\\Desktop\\b.svg";
                textBox1.Text = filename;
               
            //}
        }
    }
}
