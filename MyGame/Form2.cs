using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Form2 : Form
    {
        public Form2(string r1)
        {
            InitializeComponent();
            textBox1.Text = r1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string r1 = textBox1.ToString(); 
            Form F1 = new Form1();
            this.Hide();
            F1.ShowDialog();
            this.Close();

        }
       
    }
}
