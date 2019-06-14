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
    public partial class czworokat : Form
    {


        public czworokat()
        {
            InitializeComponent();
        }

        private void czworokat_Load(object sender, EventArgs e)
        {

        }

        private void rysuj_cz_Click(object sender, EventArgs e)
        {
            int ac = Convert.ToInt32(this.boka_cz.Text);
            int bc = Convert.ToInt32(this.bokb_cz.Text);

            pole_cz.Visible = true;
            int pole = ac * bc;
            pole_cz.Text = "" + pole;

            obwod_cz.Visible = true;
            int obwod = 2*ac + 2*bc;
            obwod_cz.Text = "" + obwod;


            SolidBrush sbc = new SolidBrush(Color.DarkSlateGray);
            Graphics gc = panel_czworokat.CreateGraphics();
            gc.FillRectangle(sbc, 5, 5, ac*15, bc*15);
        }

        private void czysc_cz_Click(object sender, EventArgs e)
        {
            Graphics cl = panel_czworokat.CreateGraphics();
            cl.Clear(Color.White);

            pole_cz.Visible = false;
            obwod_cz.Visible = false;

            boka_cz.Text = "";
            bokb_cz.Text = "";
        }
    }
}
