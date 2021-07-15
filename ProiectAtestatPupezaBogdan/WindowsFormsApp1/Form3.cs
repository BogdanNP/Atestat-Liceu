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
    public partial class Form3 : Form
    {
        private int cntPort = new int();
        private bool[] port = new bool[13];
        private int[] xLoc = new int[13];
        private int[] yLoc = new int[13];
        private string[] numePort = new string[13] { "", "Varna", "Burgas", "Istambul",
            "Zonguladak", "Samsun", "Batumi", "Sochi", "Novorossiysk", "Yalta", "Sevastopol", "Odessa",  "Constanta" };
        private int[,] distante = new int[,]
            {
                {0, 176, 244, 366, 397, 742, 1099, 892, 718, 466, 394, 305},
                { 176, 0, 118, 272, 368, 769, 1139, 952, 775, 520, 478, 476 },
                { 248, 118, 0, 230, 373, 816, 1171, 1003, 836, 591, 542, 557 },
                { 366, 272, 230, 0, 249, 730, 1093, 936, 807, 579, 548, 644 },
                { 397, 368, 373, 249, 0, 487, 857, 712, 596, 394, 398, 577 },
                { 742, 769, 816, 730, 487, 0, 454, 382, 411, 400, 475, 739 },
                { 1099, 1139, 1171, 1093, 857, 454, 0, 273, 510, 684, 788, 1054 },
                { 892, 952, 1003, 936, 712, 382, 273, 0, 248, 450, 551, 825 },
                { 718, 775, 836, 807, 596, 411, 510, 248, 0, 252, 371, 639 },
                { 466, 520, 591, 579, 394, 400, 684, 450, 252, 0, 117, 392 },
                { 394, 478, 542, 548, 398, 475, 788, 551, 371, 117, 0, 305 },
                { 305, 476, 557, 644, 577, 739, 1054, 825, 639, 392, 305, 0 }

            };
        private int Distanta = 0;
        private int[] x = new int[13];

        Form5 form5 = null;

        public Form3()
        {
            InitializeComponent();
        }

        

        private void p1_Click(object sender, EventArgs e)
        {
            if (port[1] == false)
                cntPort++;
            lblX.Text = p1.Location.X.ToString();
            lblY.Text = p1.Location.Y.ToString();
            port[1] = true;
            xLoc[1] = p1.Location.X;
            yLoc[1] = p1.Location.Y;
        }

        private void p2_Click(object sender, EventArgs e)
        {
            if (port[2] == false)
                cntPort++;
            lblX.Text = p2.Location.X.ToString();
            lblY.Text = p2.Location.Y.ToString();
            port[2] = true;
            xLoc[2] = p2.Location.X;
            yLoc[2] = p2.Location.Y;
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (port[3] == false)
                cntPort++;
            lblX.Text = p3.Location.X.ToString();
            lblY.Text = p3.Location.Y.ToString();
            port[3] = true;
            xLoc[3] = p3.Location.X;
            yLoc[3] = p3.Location.Y;
        }

        private void p4_Click(object sender, EventArgs e)
        {
            if (port[4] == false)
                cntPort++;
            lblX.Text = p4.Location.X.ToString();
            lblY.Text = p4.Location.Y.ToString();
            port[4] = true;
            xLoc[4] = p4.Location.X;
            yLoc[4] = p4.Location.Y;
        }

        private void p5_Click(object sender, EventArgs e)
        {
            if (port[5] == false)
                cntPort++;
            lblX.Text = p5.Location.X.ToString();
            lblY.Text = p5.Location.Y.ToString();
            port[5] = true;
            xLoc[5] = p5.Location.X;
            yLoc[5] = p5.Location.Y;
        }

        private void p6_Click(object sender, EventArgs e)
        {
            if (port[6] == false)
                cntPort++;
            lblX.Text = p6.Location.X.ToString();
            lblY.Text = p6.Location.Y.ToString();
            port[6] = true;
            xLoc[6] = p6.Location.X;
            yLoc[6] = p6.Location.Y;
        }

        private void p7_Click(object sender, EventArgs e)
        {
            if (port[7] == false)
                cntPort++;
            lblX.Text = p7.Location.X.ToString();
            lblY.Text = p7.Location.Y.ToString();
            port[7] = true;
            xLoc[7] = p7.Location.X;
            yLoc[7] = p7.Location.Y;
        }

        private void p8_Click(object sender, EventArgs e)
        {
            if (port[8] == false)
                cntPort++;
            lblX.Text = p8.Location.X.ToString();
            lblY.Text = p8.Location.Y.ToString();
            port[8] = true;
            xLoc[8] = p8.Location.X;
            yLoc[8] = p8.Location.Y;
        }

        private void p9_Click(object sender, EventArgs e)
        {
            if (port[9] == false)
                cntPort++;
            lblX.Text = p9.Location.X.ToString();
            lblY.Text = p9.Location.Y.ToString();
            port[9] = true;
            xLoc[9] = p9.Location.X;
            yLoc[9] = p9.Location.Y;
        }

        private void p10_Click(object sender, EventArgs e)
        {
            if (port[10] == false)
                cntPort++;
            lblX.Text = p10.Location.X.ToString();
            lblY.Text = p10.Location.Y.ToString();
            port[10] = true;
            xLoc[10] = p10.Location.X;
            yLoc[10] = p10.Location.Y;
        }

        private void p11_Click(object sender, EventArgs e)
        {
            if (port[11] == false)
                cntPort++;
            lblX.Text = p11.Location.X.ToString();
            lblY.Text = p11.Location.Y.ToString();
            port[11] = true;
            xLoc[11] = p11.Location.X;
            yLoc[11] = p11.Location.Y;
        }

        private void p0_Click(object sender, EventArgs e)
        {
            if (port[12] == false)
                cntPort++;
            lblX.Text = p0.Location.X.ToString();
            lblY.Text = p0.Location.Y.ToString();
            port[12] = true;
            xLoc[12] = p0.Location.X;
            yLoc[12] = p0.Location.Y;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cntPort = 0;
            for (int i = 1; i <= 12; ++i)
                port[i] = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; ++i)
            {
                if (port[i] == true)
                {
                    this.porturiTableAdapter.Insert1(numePort[i], xLoc[i], yLoc[i]);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Croaziere' table. You can move, or remove it, as needed.
            //this.croaziereTableAdapter.Fill(this.database1DataSet.Croaziere);
            // TODO: This line of code loads data into the 'database1DataSet.Distanta' table. You can move, or remove it, as needed.
            //  this.distantaTableAdapter.Fill(this.database1DataSet.Distanta);
            // TODO: This line of code loads data into the 'database1DataSet.Porturi' table. You can move, or remove it, as needed.
            //this.porturiTableAdapter.Fill(this.database1DataSet.Porturi);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; ++i)
                for (int j = 1; j <= 12; ++j)
                {
                    if (port[i] == true)
                        this.distantaTableAdapter.InsertDistanta(i, j, numePort[j], distante[i - 1, j - 1]);
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 12; ++i)
            {
                x[i] = 0;
            }
            Distanta = 0;
                Back(1, 3);
                Back(1, 5);
                Back(1, 8);
        }


        private void Write(int k)
        {
            string S = "1";
            string s = "Constanta, ";
            for (int i = 1; i <= k; ++i)
            {
                S = S + x[i].ToString();
                s = s + numePort[x[i]] + ", ";
                if (i > 1)
                    Distanta = Distanta + distante[x[i], x[i - 1]];
            }
            Distanta = Distanta + distante[1, k];
            s = s + "Constanta";
            if (Distanta >= 800)
            {
                if (k == 3 && Distanta <= 1200)
                    this.croaziereTableAdapter.InsertCroaziera(k, s, S, null, null, Distanta * 2, 150);
                if (k == 5 && Distanta <= 2000)
                    this.croaziereTableAdapter.InsertCroaziera(k, s, S, null, null, Distanta * 2, 200);
                if (k == 8 && Distanta <= 3000)
                    this.croaziereTableAdapter.InsertCroaziera(k, s, S, null, null, Distanta * 2, 300);
            }
            Distanta = 0;
        }

        private void Back(int k, int m)
        {

            if (k > m)
            {
                Write(k - 1);
                return;
            }

            for (int i = x[k - 1] + 1; i < 12; ++i)
            {
                if (port[i] == true)
                {
                    x[k] = i;
                    Back(k + 1, m);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void Form3_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
