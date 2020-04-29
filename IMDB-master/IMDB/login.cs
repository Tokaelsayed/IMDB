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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (s_inPanel.Left == 472)
            {
                s_upPanel.Visible = false;
                s_upPanel.Left = 472;

                s_inPanel.Visible = false;
                s_inPanel.Left = 21;
                s_inPanel.Visible = true;
                s_inPanel.Refresh();
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (s_upPanel.Left == 472)
            {
                s_inPanel.Visible = false;
                s_inPanel.Left = 472;
                s_upPanel.Visible = false;
                s_upPanel.Left = 21;
                s_upPanel.Visible = true;
                s_upPanel.Refresh();
            }
        }

        private void signUpDone_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void signInDone_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
