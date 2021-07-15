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
    public partial class Form4 : Form
    {
        Form2 form2 = null;
        Form6 form6 = null;
        int id;
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Croaziere' table. You can move, or remove it, as needed.
            this.croaziereTableAdapter.Fill(this.database1DataSet.Croaziere);
            CB.Text = "3zile";
        }

        private void CB_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            String Porturi = dataGridView1.CurrentCell.Value.ToString();

            //form2 = new Form2();
            //form2.Visible = true;
            form6 = new Form6();
            form6.Retine(Porturi);
            form6.Visible = true;
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0) == true)
            {
                id = int.Parse(dataGridView1.CurrentCell.Value.ToString());
                this.croaziereTableAdapter.UpdateQuery(dtpS.Value.ToString(), dtpF.Value.ToString(), id);
                if (CB.Text == "")
                    this.croaziereTableAdapter.Fill(this.database1DataSet.Croaziere);
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

            

            
        }
    }
}
