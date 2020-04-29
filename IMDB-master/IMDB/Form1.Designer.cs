namespace IMDB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchbox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.joinLbl = new System.Windows.Forms.Label();
            this.searchType = new Bunifu.Framework.UI.BunifuDropdown();
            this.updateBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.exitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.addBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchTool = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTool)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.bunifuGradientPanel2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(222, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 597);
            this.panel1.TabIndex = 62;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(104, 107);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(500, 3);
            this.bunifuGradientPanel2.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.ForeColor = System.Drawing.Color.Goldenrod;
            this.panel2.Location = new System.Drawing.Point(22, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 40);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(33, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "This week\'s top TV and movies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(47, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fan favorites";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "What to watch";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchbox.BorderColorFocused = System.Drawing.Color.Lavender;
            this.searchbox.BorderColorIdle = System.Drawing.Color.WhiteSmoke;
            this.searchbox.BorderColorMouseHover = System.Drawing.Color.GhostWhite;
            this.searchbox.BorderThickness = 3;
            this.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.Teal;
            this.searchbox.isPassword = false;
            this.searchbox.Location = new System.Drawing.Point(290, 17);
            this.searchbox.Margin = new System.Windows.Forms.Padding(4);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(510, 37);
            this.searchbox.TabIndex = 67;
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // joinLbl
            // 
            this.joinLbl.AutoSize = true;
            this.joinLbl.BackColor = System.Drawing.Color.Transparent;
            this.joinLbl.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.joinLbl.Location = new System.Drawing.Point(1017, 2);
            this.joinLbl.Name = "joinLbl";
            this.joinLbl.Size = new System.Drawing.Size(156, 51);
            this.joinLbl.TabIndex = 70;
            this.joinLbl.Text = "Join Us";
            this.joinLbl.Click += new System.EventHandler(this.joinLbl_Click);
            // 
            // searchType
            // 
            this.searchType.BackColor = System.Drawing.Color.Goldenrod;
            this.searchType.BorderRadius = 3;
            this.searchType.DisabledColor = System.Drawing.Color.Transparent;
            this.searchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchType.ForeColor = System.Drawing.Color.LightCyan;
            this.searchType.Items = new string[] {
        "Title",
        "Rate above",
        "Rate below",
        "Year"};
            this.searchType.Location = new System.Drawing.Point(690, 16);
            this.searchType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchType.Name = "searchType";
            this.searchType.NomalColor = System.Drawing.Color.Transparent;
            this.searchType.onHoverColor = System.Drawing.Color.LightGray;
            this.searchType.selectedIndex = -1;
            this.searchType.Size = new System.Drawing.Size(157, 39);
            this.searchType.TabIndex = 66;
            // 
            // updateBtn
            // 
            this.updateBtn.Activecolor = System.Drawing.Color.Transparent;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateBtn.BorderRadius = 0;
            this.updateBtn.ButtonText = "Update Movie";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledColor = System.Drawing.Color.Gray;
            this.updateBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updateBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateBtn.Iconimage")));
            this.updateBtn.Iconimage_right = null;
            this.updateBtn.Iconimage_right_Selected = null;
            this.updateBtn.Iconimage_Selected = null;
            this.updateBtn.IconMarginLeft = 0;
            this.updateBtn.IconMarginRight = 0;
            this.updateBtn.IconRightVisible = true;
            this.updateBtn.IconRightZoom = 0D;
            this.updateBtn.IconVisible = true;
            this.updateBtn.IconZoom = 90D;
            this.updateBtn.IsTab = false;
            this.updateBtn.Location = new System.Drawing.Point(-9, 220);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.updateBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.updateBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updateBtn.selected = false;
            this.updateBtn.Size = new System.Drawing.Size(225, 48);
            this.updateBtn.TabIndex = 65;
            this.updateBtn.Text = "Update Movie";
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Textcolor = System.Drawing.Color.White;
            this.updateBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitBtn.BorderRadius = 0;
            this.exitBtn.ButtonText = "";
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.exitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exitBtn.Iconimage = global::IMDB.Properties.Resources.icons8_multiply_filled_50;
            this.exitBtn.Iconimage_right = null;
            this.exitBtn.Iconimage_right_Selected = null;
            this.exitBtn.Iconimage_Selected = null;
            this.exitBtn.IconMarginLeft = 0;
            this.exitBtn.IconMarginRight = 0;
            this.exitBtn.IconRightVisible = true;
            this.exitBtn.IconRightZoom = 0D;
            this.exitBtn.IconVisible = true;
            this.exitBtn.IconZoom = 90D;
            this.exitBtn.IsTab = false;
            this.exitBtn.Location = new System.Drawing.Point(1170, -5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.exitBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.exitBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.exitBtn.selected = false;
            this.exitBtn.Size = new System.Drawing.Size(49, 48);
            this.exitBtn.TabIndex = 71;
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Textcolor = System.Drawing.Color.White;
            this.exitBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Activecolor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteBtn.BorderRadius = 0;
            this.deleteBtn.ButtonText = "Delete Movie";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledColor = System.Drawing.Color.Gray;
            this.deleteBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Iconimage")));
            this.deleteBtn.Iconimage_right = null;
            this.deleteBtn.Iconimage_right_Selected = null;
            this.deleteBtn.Iconimage_Selected = null;
            this.deleteBtn.IconMarginLeft = 0;
            this.deleteBtn.IconMarginRight = 0;
            this.deleteBtn.IconRightVisible = true;
            this.deleteBtn.IconRightZoom = 0D;
            this.deleteBtn.IconVisible = true;
            this.deleteBtn.IconZoom = 90D;
            this.deleteBtn.IsTab = false;
            this.deleteBtn.Location = new System.Drawing.Point(-9, 166);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.deleteBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.deleteBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteBtn.selected = false;
            this.deleteBtn.Size = new System.Drawing.Size(225, 48);
            this.deleteBtn.TabIndex = 64;
            this.deleteBtn.Text = "Delete Movie";
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Textcolor = System.Drawing.Color.White;
            this.deleteBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::IMDB.Properties.Resources.www_imdb_logo__CB443130112_;
            this.pictureBox5.Location = new System.Drawing.Point(3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(230, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // addBtn
            // 
            this.addBtn.Activecolor = System.Drawing.Color.Transparent;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addBtn.BorderRadius = 0;
            this.addBtn.ButtonText = "Add Movie";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DisabledColor = System.Drawing.Color.Gray;
            this.addBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addBtn.Iconimage")));
            this.addBtn.Iconimage_right = null;
            this.addBtn.Iconimage_right_Selected = null;
            this.addBtn.Iconimage_Selected = null;
            this.addBtn.IconMarginLeft = 0;
            this.addBtn.IconMarginRight = 0;
            this.addBtn.IconRightVisible = true;
            this.addBtn.IconRightZoom = 0D;
            this.addBtn.IconVisible = true;
            this.addBtn.IconZoom = 90D;
            this.addBtn.IsTab = false;
            this.addBtn.Location = new System.Drawing.Point(-9, 111);
            this.addBtn.Name = "addBtn";
            this.addBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.addBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.addBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addBtn.selected = false;
            this.addBtn.Size = new System.Drawing.Size(225, 48);
            this.addBtn.TabIndex = 63;
            this.addBtn.Text = "Add Movie";
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.Textcolor = System.Drawing.Color.White;
            this.addBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // searchTool
            // 
            this.searchTool.BackColor = System.Drawing.Color.Transparent;
            this.searchTool.Image = ((System.Drawing.Image)(resources.GetObject("searchTool.Image")));
            this.searchTool.ImageActive = null;
            this.searchTool.Location = new System.Drawing.Point(253, 17);
            this.searchTool.Name = "searchTool";
            this.searchTool.Size = new System.Drawing.Size(40, 37);
            this.searchTool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchTool.TabIndex = 68;
            this.searchTool.TabStop = false;
            this.searchTool.Zoom = 10;
            this.searchTool.Click += new System.EventHandler(this.searchTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1211, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.searchTool);
            this.Controls.Add(this.joinLbl);
            this.Controls.Add(this.searchType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton updateBtn;
        private Bunifu.Framework.UI.BunifuFlatButton exitBtn;
        private Bunifu.Framework.UI.BunifuFlatButton deleteBtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Bunifu.Framework.UI.BunifuFlatButton addBtn;
        public Bunifu.Framework.UI.BunifuMetroTextbox searchbox;
        public Bunifu.Framework.UI.BunifuImageButton searchTool;
        public System.Windows.Forms.Label joinLbl;
        public Bunifu.Framework.UI.BunifuDropdown searchType;
    }
}

