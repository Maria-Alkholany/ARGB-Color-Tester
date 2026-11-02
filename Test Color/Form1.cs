using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChangeColor()
        {
            int alpha = tbA.Value;
            int red = tbR.Value;
            int green = tbG.Value;
            int blue = tbB.Value;

            txtA.Text = tbA.Value.ToString();
            txtR.Text = tbR.Value.ToString();
            txtG.Text = tbG.Value.ToString();
            txtB.Text = tbB.Value.ToString();

            picTest.BackColor = Color.FromArgb(alpha, red, green, blue);
        }

        private void TbA_Scroll(object sender, EventArgs e)
        {
            ChangeColor();
        }

        private void TbR_Scroll(object sender, EventArgs e)
        {
            ChangeColor();

        }

        private void TbG_Scroll(object sender, EventArgs e)
        {
            ChangeColor();

        }

        private void TbB_Scroll(object sender, EventArgs e)
        {
            ChangeColor();

        }
    }
}
