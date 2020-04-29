using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMDB
{
    public partial class Form1 : Form
    {
        Recommend rec = new Recommend();
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            AddMovie add = new AddMovie();
            add.Visible = true;
            add.Location = new Point(200, 0);
            panel1.Controls.Add(add);
            add.BringToFront();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            rec.Visible = true;
            rec.Location = new Point(70, 100);
            panel1.Controls.Add(rec);
            rec.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void joinLbl_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Visible = true;
            login.Location = new Point(400, 95);
            this.Controls.Add(login);
            login.BringToFront();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            DeleteMovie delete = new DeleteMovie();
            delete.Visible = true;
            delete.Location = new Point(200, 0);
            panel1.Controls.Add(delete);
            delete.BringToFront();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UpdateMovie update = new UpdateMovie();
            update.Visible = true;
            update.Location = new Point(200, 0);
            panel1.Controls.Add(update);
            update.BringToFront();
        }

        private void searchTool_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            search s = new search();
            s.Visible = true;
            s.Location = new Point(70, 0);
            panel1.Controls.Add(s);
            s.BringToFront();
        }
    }
}
