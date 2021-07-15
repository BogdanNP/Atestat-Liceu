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
    public partial class Form6 : Form
    {
        String Porturi;
        Form2 form2 = new Form2();
        int N;
        Point[] punct = new Point[13];
        public Form6()
        {
            InitializeComponent();
        }

        public void Puncte()
        {
            int i = 0;
            String[] porturi = Porturi.Split(' ');
            foreach(var port in porturi)
            {
                switch(port)
                {

                    case "Constanta,":
                        punct[i++] = new Point(p0.Location.X+16, p0.Location.Y+16);
                        break;
                    case "Varna,":
                        punct[i++] = new Point(p1.Location.X+16, p1.Location.Y+16);
                        break;
                    case "Burgas,":
                        punct[i++] = new Point(p2.Location.X+16, p2.Location.Y+16);
                        break;
                    case "Istambul,":
                        punct[i++] = new Point(p3.Location.X+16, p3.Location.Y);
                        break;
                    case "Zonguladak,":
                        punct[i++] = new Point(p4.Location.X, p4.Location.Y);
                        break;
                    case "Samsun,":
                        punct[i++] = new Point(p5.Location.X, p5.Location.Y);
                        break;
                    case "Batumi,":
                        punct[i++] = new Point(p6.Location.X, p6.Location.Y);
                        break;
                    case "Sochi,":
                        punct[i++] = new Point(p7.Location.X, p7.Location.Y+16);
                        break;
                    case "Novorossiysk,":
                        punct[i++] = new Point(p8.Location.X, p8.Location.Y+16);
                        break;
                    case "Yalta,":
                        punct[i++] = new Point(p9.Location.X+16, p9.Location.Y+16);
                        break;
                    case "Sevastopol,":
                        punct[i++] = new Point(p10.Location.X, p10.Location.Y+16);
                        break;
                    case "Odessa,":
                        punct[i++] = new Point(p11.Location.X+16, p11.Location.Y+16);
                        break;
                }

            }
            N = i;
        }

        public void Retine(String P)
        {
            Porturi = P;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //label1.Text = Porturi;
            Puncte();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Blue, 5);
            for (int j = 1; j < N; ++j)
                e.Graphics.DrawLine(pen, punct[j], punct[j-1]);
            e.Graphics.DrawLine(pen, punct[N - 1], punct[0]);
        }

        private void Form6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            form2.Visible = true;
            this.Close();
        }
    }
}
