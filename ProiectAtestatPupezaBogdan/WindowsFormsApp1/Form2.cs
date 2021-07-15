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
    public partial class Form2 : Form
    {

        Form1 form1 = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        
        private void btnA_Click(object sender, EventArgs e)
        {
            if (tbUser.Text == "turist" && tbPass.Text == "proiect")
            {
                form1.Visible = true;
                this.Hide();
                form1.Verif(true);


                if (form1.Visible == false)
                {
                    this.Close();
                }
            }

            if (tbUser.Text == "admin" && tbPass.Text == "proiect")
            {
                form1.Visible = true;
                this.Hide();
                form1.Verif(false);
            }
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
