using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void rysuj_cz_Click(object sender, EventArgs e)
        {
            Point[] points1_1 = { new Point(970, 130), new Point(290, 140), new Point(270, 150) };
            Point[] points1_2 = { new Point(320, 230), new Point(390, 40), new Point(290, 170) };

            SolidBrush sbc = new SolidBrush(Color.DarkSlateGray);
            Graphics gc = panel_trojkat.CreateGraphics();
            gc.FillPolygon(sbc, points1_1);


        }
    }
}
