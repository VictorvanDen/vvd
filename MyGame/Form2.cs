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
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string r1 = textBox1.Text.ToString();
            string r2 = textBox2.Text.ToString();
            Form F1 = new Form1(r1, r2);
            this.Hide();
            F1.ShowDialog();
            this.Close();

        }
       
    }
}
