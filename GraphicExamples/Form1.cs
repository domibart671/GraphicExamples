using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)

        {   //my graphics objects
            Graphics g = this.CreateGraphics();
            Pen drawpen = new Pen(Color.Red, 5);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawfont = new Font("Ariel", 16, FontStyle.Bold);
            // clear the screen

            //This is a test//l;kajsdflkjasdlfkj

            // code for all shapes 
            g.DrawLine(drawpen, 0, 0, 100, 100);
            g.DrawRectangle(drawpen, 30, 30, 100, 200);
            g.FillRectangle(drawBrush, 30, 30, 100, 200);
            g.DrawEllipse(drawpen, 30, 30, 100, 200);
           
            // code for all my text
            g.DrawPie(drawpen, 300, 20, 50, 50, -30, 60);
            g.DrawString("Hello\nHow are you?", drawfont, drawBrush, 200, 100);

        }
    }
}
