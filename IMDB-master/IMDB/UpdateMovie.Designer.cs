﻿namespace IMDB
{
    partial class UpdateMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateMovie));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chooseName = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.YearTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TypeTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.rateTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.directorTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cancelBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.updateBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.movieImage = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(113, 1);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(206, 33);
            this.bunifuCustomLabel1.TabIndex = 119;
            this.bunifuCustomLabel1.Text = "Update Movie";
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
            this.chooseName.Location = new System.Drawing.Point(286, 197);
            this.chooseName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chooseName.Name = "chooseName";
            this.chooseName.NomalColor = System.Drawing.Color.White;
            this.chooseName.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(170)))), ((int)(((byte)(0)))));
            this.chooseName.selectedIndex = -1;
            this.chooseName.Size = new System.Drawing.Size(208, 35);
            this.chooseName.TabIndex = 118;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(21, 87);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(195, 31);
            this.bunifuCustomLabel7.TabIndex = 117;
            this.bunifuCustomLabel7.Text = "Change Poster";
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
            this.YearTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTxt.ForeColor = System.Drawing.Color.Black;
            this.YearTxt.HintForeColor = System.Drawing.Color.Empty;
            this.YearTxt.HintText = "";
            this.YearTxt.isPassword = false;
            this.YearTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.YearTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.YearTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.YearTxt.LineThickness = 3;
            this.YearTxt.Location = new System.Drawing.Point(288, 441);
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
            // TypeTxt
            // 
            this.TypeTxt.BackColor = System.Drawing.Color.White;
            this.TypeTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TypeTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTxt.ForeColor = System.Drawing.Color.Black;
            this.TypeTxt.HintForeColor = System.Drawing.Color.Empty;
            this.TypeTxt.HintText = "";
            this.TypeTxt.isPassword = false;
            this.TypeTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.TypeTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.TypeTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TypeTxt.LineThickness = 3;
            this.TypeTxt.Location = new System.Drawing.Point(286, 317);
            this.TypeTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TypeTxt.Name = "TypeTxt";
            this.TypeTxt.Size = new System.Drawing.Size(208, 42);
            this.TypeTxt.TabIndex = 113;
            this.TypeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.rateTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateTxt.ForeColor = System.Drawing.Color.Black;
            this.rateTxt.HintForeColor = System.Drawing.Color.Empty;
            this.rateTxt.HintText = "";
            this.rateTxt.isPassword = false;
            this.rateTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.rateTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.rateTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.rateTxt.LineThickness = 3;
            this.rateTxt.Location = new System.Drawing.Point(288, 380);
            this.rateTxt.Margin = new System.Windows.Forms.Padding(4);
            this.rateTxt.Name = "rateTxt";
            this.rateTxt.Size = new System.Drawing.Size(204, 40);
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
            // directorTxt
            // 
            this.directorTxt.BackColor = System.Drawing.Color.White;
            this.directorTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.directorTxt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.directorTxt.ForeColor = System.Drawing.Color.Black;
            this.directorTxt.HintForeColor = System.Drawing.Color.Empty;
            this.directorTxt.HintText = "";
            this.directorTxt.isPassword = false;
            this.directorTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.directorTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.directorTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.directorTxt.LineThickness = 3;
            this.directorTxt.Location = new System.Drawing.Point(286, 253);
            this.directorTxt.Margin = new System.Windows.Forms.Padding(4);
            this.directorTxt.Name = "directorTxt";
            this.directorTxt.Size = new System.Drawing.Size(208, 43);
            this.directorTxt.TabIndex = 109;
            this.directorTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            // updateBtn
            // 
            this.updateBtn.ActiveBorderThickness = 1;
            this.updateBtn.ActiveCornerRadius = 1;
            this.updateBtn.ActiveFillColor = System.Drawing.Color.Goldenrod;
            this.updateBtn.ActiveForecolor = System.Drawing.Color.White;
            this.updateBtn.ActiveLineColor = System.Drawing.Color.Goldenrod;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.BackgroundImage")));
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.IdleBorderThickness = 1;
            this.updateBtn.IdleCornerRadius = 1;
            this.updateBtn.IdleFillColor = System.Drawing.Color.Goldenrod;
            this.updateBtn.IdleForecolor = System.Drawing.Color.White;
            this.updateBtn.IdleLineColor = System.Drawing.Color.Goldenrod;
            this.updateBtn.Location = new System.Drawing.Point(75, 494);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(5);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(172, 51);
            this.updateBtn.TabIndex = 120;
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movieImage
            // 
            this.movieImage.BackColor = System.Drawing.Color.Transparent;
            this.movieImage.Image = ((System.Drawing.Image)(resources.GetObject("movieImage.Image")));
            this.movieImage.ImageActive = null;
            this.movieImage.Location = new System.Drawing.Point(286, 36);
            this.movieImage.Name = "movieImage";
            this.movieImage.Size = new System.Drawing.Size(210, 146);
            this.movieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.movieImage.TabIndex = 107;
            this.movieImage.TabStop = false;
            this.movieImage.Zoom = 10;
            // 
            // UpdateMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.chooseName);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.YearTxt);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.TypeTxt);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.rateTxt);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.directorTxt);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.movieImage);
            this.Name = "UpdateMovie";
            this.Size = new System.Drawing.Size(517, 554);
            ((System.ComponentModel.ISupportInitialize)(this.movieImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 cancelBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 updateBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown chooseName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox YearTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TypeTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox rateTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuMaterialTextbox directorTxt;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton movieImage;
    }
}
