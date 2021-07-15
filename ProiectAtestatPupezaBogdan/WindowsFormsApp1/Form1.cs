using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        public Form1()
        {
            InitializeComponent();
        }

        public void Verif(bool turist)
        {
            if (turist == true)
                this.administrareToolStripMenuItem.Visible = false;
            else
                this.turistiToolStripMenuItem.Visible = false;
        }


        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void administrareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3.Visible = true;
            this.Hide();
        }

        private void turistiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form4.Visible = true;
            this.Hide();
        }
    }
    
}
