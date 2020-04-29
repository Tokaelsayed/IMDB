using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB
{
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_MouseEnter(object sender, EventArgs e)
        {
            if(reviewTxt.Text== "write your review...")
            {
                reviewTxt.Text = "";
                reviewTxt.ForeColor = Color.Black;
            }
        }

        private void bunifuCustomTextbox1_MouseLeave(object sender, EventArgs e)
        {
            if (reviewTxt.Text == "")
            {
                reviewTxt.Text = "write your review...";
                reviewTxt.ForeColor = Color.DarkGray;
            }
        }
    }
}
