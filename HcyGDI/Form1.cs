using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HcyGDI
{
    public partial class Form1 : Form
    {
        private Delegate updateUI;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Graphics g = this.button2.CreateGraphics();

            //画一个椭圆

            g.DrawEllipse(Pens.Red, 50, 50, 50, 50);

            SolidBrush mySolidBrush = new SolidBrush(Color.Red);
            g.FillEllipse(mySolidBrush, 0, 0, 60, 40);
            g.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //画一个椭圆

            g.DrawEllipse(Pens.Red, 100, 100, 50, 50);//

            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            //画一个椭圆

            g.DrawEllipse(Pens.Red, 0, 60, 60, 60);
            g.Dispose();
            GDI_1();
        }

        private void GDI_1() {

            this.Invoke(new Action(delegate
            {
                int i = 60;
                while (i < this.Width)
                {

                    Graphics g = this.CreateGraphics();
                    SolidBrush mySolidBrush = new SolidBrush(Color.Red);
                    g.FillEllipse(mySolidBrush, i, i, i, i);
                    g.Dispose();
                    i++;
                    Thread.Sleep(60);

                }
                MessageBox.Show("over!");
            }));
        }

        private void GDI_2() {
            this.Invoke(new Action(delegate
            {
                int x = 60;
                int y = 60;
                while (x < this.Width)
                {

                    Graphics g = this.CreateGraphics();
                    SolidBrush mySolidBrush = new SolidBrush(Color.Red);

                
                    Pen pen = new Pen(Color.Brown);
                    g.DrawLine(pen, 0, 0, x, y);
                    g.Dispose();

                    if (x == 100) {
                        y--;
                    }

                    x++;
                    if (x < 100)
                    { y++; }
                    Thread.Sleep(60);
                }
               
            }));
        }

    
    }

 
}
