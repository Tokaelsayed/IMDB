namespace IMDB
{
    partial class DeleteMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteMovie));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chooseName = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.YearTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Director = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rateTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TypeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(159, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(197, 33);
            this.bunifuCustomLabel1.TabIndex = 119;
            this.bunifuCustomLabel1.Text = "Delete Movie";
            // 
            // chooseName
            // 
            this.chooseName.BackColor = System.Drawing.Color.White;
            this.chooseName.BorderRadius = 3;
            this.chooseName.DisabledColor = System.Drawing.Color.White;
            this.chooseName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseName.ForeColor = System.Drawing.Color.Black;
            this.chooseName.Items = new string[] {
        "Drame",
        "Action",
        "Horror",
        "Comedy",
        "Fantasy",
        "Aadventure",
        "Romance"};
            this.chooseName.Location = new System.Drawing.Point(288, 204);
            this.chooseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseName.Name = "chooseName";
            this.chooseName.NomalColor = System.Drawing.Color.White;
            this.chooseName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.chooseName.selectedIndex = -1;
            this.chooseName.Size = new System.Drawing.Size(208, 35);
            this.chooseName.TabIndex = 118;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(21, 445);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(178, 31);
            this.bunifuCustomLabel5.TabIndex = 116;
            this.bunifuCustomLabel5.Text = "Release Year";
            // 
            // YearTxt
            // 
            this.YearTxt.BackColor = System.Drawing.Color.White;
            this.YearTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YearTxt.Enabled = false;
            this.YearTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTxt.ForeColor = System.Drawing.Color.Black;
            this.YearTxt.HintForeColor = System.Drawing.Color.Empty;
            this.YearTxt.HintText = "";
            this.YearTxt.isPassword = false;
            this.YearTxt.LineFocusedColor = System.Drawing.Color.Black;
            this.YearTxt.LineIdleColor = System.Drawing.Color.White;
            this.YearTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.YearTxt.LineThickness = 3;
            this.YearTxt.Location = new System.Drawing.Point(288, 444);
            this.YearTxt.Margin = new System.Windows.Forms.Padding(4);
            this.YearTxt.Name = "YearTxt";
            this.YearTxt.Size = new System.Drawing.Size(204, 41);
            this.YearTxt.TabIndex = 115;
            this.YearTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 259);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(189, 31);
            this.bunifuCustomLabel2.TabIndex = 114;
            this.bunifuCustomLabel2.Text = "Movie Director";
            // 
            // Director
            // 
            this.Director.BackColor = System.Drawing.Color.White;
            this.Director.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Director.Enabled = false;
            this.Director.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Director.ForeColor = System.Drawing.Color.Black;
            this.Director.HintForeColor = System.Drawing.Color.Empty;
            this.Director.HintText = "";
            this.Director.isPassword = false;
            this.Director.LineFocusedColor = System.Drawing.Color.Black;
            this.Director.LineIdleColor = System.Drawing.Color.White;
            this.Director.LineMouseHoverColor = System.Drawing.Color.White;
            this.Director.LineThickness = 3;
            this.Director.Location = new System.Drawing.Point(288, 261);
            this.Director.Margin = new System.Windows.Forms.Padding(4);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(208, 42);
            this.Director.TabIndex = 113;
            this.Director.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(21, 383);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(151, 31);
            this.bunifuCustomLabel3.TabIndex = 112;
            this.bunifuCustomLabel3.Text = "Movie Rate";
            // 
            // rateTxt
            // 
            this.rateTxt.BackColor = System.Drawing.Color.White;
            this.rateTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rateTxt.Enabled = false;
            this.rateTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTxt.ForeColor = System.Drawing.Color.Black;
            this.rateTxt.HintForeColor = System.Drawing.Color.Empty;
            this.rateTxt.HintText = "";
            this.rateTxt.isPassword = false;
            this.rateTxt.LineFocusedColor = System.Drawing.Color.Black;
            this.rateTxt.LineIdleColor = System.Drawing.Color.White;
            this.rateTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.rateTxt.LineThickness = 3;
            this.rateTxt.Location = new System.Drawing.Point(288, 382);
            this.rateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(208, 43);
            this.rateTxt.TabIndex = 111;
            this.rateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(21, 197);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(165, 31);
            this.bunifuCustomLabel6.TabIndex = 110;
            this.bunifuCustomLabel6.Text = "Movie Name";
            // 
            // TypeTxt
            // 
            this.TypeTxt.BackColor = System.Drawing.Color.White;
            this.TypeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeTxt.Enabled = false;
            this.TypeTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTxt.ForeColor = System.Drawing.Color.Black;
            this.TypeTxt.HintForeColor = System.Drawing.Color.Empty;
            this.TypeTxt.HintText = "";
            this.TypeTxt.isPassword = false;
            this.TypeTxt.LineFocusedColor = System.Drawing.Color.Black;
            this.TypeTxt.LineIdleColor = System.Drawing.Color.White;
            this.TypeTxt.LineMouseHoverColor = System.Drawing.Color.White;
            this.TypeTxt.LineThickness = 3;
            this.TypeTxt.Location = new System.Drawing.Point(288, 321);
            this.TypeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(208, 43);
            this.TypeTxt.TabIndex = 109;
            this.TypeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(21, 321);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(154, 31);
            this.bunifuCustomLabel4.TabIndex = 108;
            this.bunifuCustomLabel4.Text = "Movie Type";
            // 
            // cancelBtn
            // 
            this.cancelBtn.ActiveBorderThickness = 1;
            this.cancelBtn.ActiveCornerRadius = 1;
            this.cancelBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.ActiveForecolor = System.Drawing.Color.White;
            this.cancelBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelBtn.BackgroundImage")));
            this.cancelBtn.ButtonText = "Cancel";
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.IdleBorderThickness = 1;
            this.cancelBtn.IdleCornerRadius = 1;
            this.cancelBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.IdleForecolor = System.Drawing.Color.White;
            this.cancelBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.cancelBtn.Location = new System.Drawing.Point(267, 494);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(171, 51);
            this.cancelBtn.TabIndex = 121;
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteBtn
            // 
            this.deleteBtn.ActiveBorderThickness = 1;
            this.deleteBtn.ActiveCornerRadius = 1;
            this.deleteBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.ActiveForecolor = System.Drawing.Color.White;
            this.deleteBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.IdleBorderThickness = 1;
            this.deleteBtn.IdleCornerRadius = 1;
            this.deleteBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.IdleForecolor = System.Drawing.Color.White;
            this.deleteBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.deleteBtn.Location = new System.Drawing.Point(75, 494);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(172, 51);
            this.deleteBtn.TabIndex = 120;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(99, 38);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(318, 151);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton4.TabIndex = 107;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // DeleteMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.chooseName);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.TypeTxt);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuImageButton4);
            this.Name = "DeleteMovie";
            this.Size = new System.Drawing.Size(517, 554);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown chooseName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox YearTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Director;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rateTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TypeTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
    }
}
