using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe__Desktop_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255);
            Pen whitePen = new Pen(white, 10);
            whitePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            whitePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(whitePen, 300, 250, 950, 250);
            e.Graphics.DrawLine(whitePen, 300, 400, 950, 400);
            e.Graphics.DrawLine(whitePen, 300, 100, 950, 550);
            e.Graphics.DrawLine(whitePen, 450, 100, 450, 700);
        }
    }
}
