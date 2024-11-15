using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void اعضاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            members m = new members();
            m.ShowDialog();
        }

        private void راهنمایاستفادهازبرنامهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a = new about();
            a.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void راهنماToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
           aboutme b = new aboutme();
           b.ShowDialog();
        }
    }
}
