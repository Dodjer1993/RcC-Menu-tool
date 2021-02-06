using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RcC_Menu_tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Add_Your_Tools frm = new Add_Your_Tools();
            frm.Owner = this;
            frm.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Your_Tools frm = new Edit_Your_Tools();
            frm.Owner = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }
    }
}
