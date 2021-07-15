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
    public partial class Form5 : Form
    {
        Form2 form2 = new Form2();
        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Croaziere' table. You can move, or remove it, as needed.
            this.croaziereTableAdapter.Fill(this.database1DataSet.Croaziere);
            CB.Text = "3zile";

        }

        private void CB_TextChanged(object sender, EventArgs e)
        {
            if (CB.Text == "3zile")
            {
                this.croaziereTableAdapter.FillBy(this.database1DataSet.Croaziere, 3);
            }
            if (CB.Text == "5zile")
            {
                this.croaziereTableAdapter.FillBy(this.database1DataSet.Croaziere, 5);
            }
            if (CB.Text == "8zile")
            {
                this.croaziereTableAdapter.FillBy(this.database1DataSet.Croaziere, 8);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            form2.Visible = true;
            this.Close();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
