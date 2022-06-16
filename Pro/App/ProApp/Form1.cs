using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProApp
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

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text=="test@gmail.com" && guna2TextBox2.Text=="test123")
            {
                new Form3().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email alebo heslo je nesprávne, skúste znova.");
                guna2TextBox1.Clear();
                guna2TextBox2.Clear();
                guna2TextBox1.Focus();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
