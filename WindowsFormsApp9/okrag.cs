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
    public partial class okrag : Form
    {
        public okrag()
        {
            InitializeComponent();
        }

        private void promien_TextChanged(object sender, EventArgs e)
        {

        }

        private void rysuj_o_Click(object sender, EventArgs e)
        {
            float r = Convert.ToInt32(this.promien.Text);

           
                       
            pole_o.Visible = true;            
            double pole = r * r;
            pole_o.Text = "" + pole + " π";

            obwod_cz.Visible = true;
            double obwod = 2 * r;
            obwod_cz.Text = "" + obwod + " π";


            SolidBrush sbc = new SolidBrush(Color.DarkSlateGray);
            Graphics gc = panel_okrag.CreateGraphics();
            gc.FillEllipse(sbc, 5, 5, r*10, r*10);
           
        }

        private void czysc_o_Click(object sender, EventArgs e)
        {
            Graphics cl = panel_okrag.CreateGraphics();
            cl.Clear(Color.White);

            pole_o.Visible = false;
            obwod_o.Visible = false;

            promien.Text = "";
            
        }
    }
}
