using ProApp.UserControls;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            UC_Dp uc = new UC_Dp();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelZaklad2.Controls.Clear();
            panelZaklad2.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UC_Ko uc = new UC_Ko();
            addUserControl(uc);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UC_Dp uc = new UC_Dp();
            addUserControl(uc);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UC_Odo uc = new UC_Odo();
            addUserControl(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            UC_Sp uc = new UC_Sp();
            addUserControl(uc);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
