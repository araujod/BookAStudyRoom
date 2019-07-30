namespace BookStudyRoom
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnHistory = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnBook = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnProfile = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(354, 29);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(213, 42);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Book Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(765, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "HOME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book a Study Room";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(53, 48);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(93, 88);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(746, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(93, 88);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.OrangeRed;
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Controls.Add(this.lblUser);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.bunifuImageButton1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(851, 100);
            this.pnlTop.TabIndex = 1;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnHistory);
            this.bunifuGradientPanel1.Controls.Add(this.btnBook);
            this.bunifuGradientPanel1.Controls.Add(this.btnProfile);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Honeydew;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Lime;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 100);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(157, 541);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHistory.color = System.Drawing.Color.SeaGreen;
            this.btnHistory.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImagePosition = 20;
            this.btnHistory.ImageZoom = 50;
            this.btnHistory.LabelPosition = 50;
            this.btnHistory.LabelText = "View\nHistory";
            this.btnHistory.Location = new System.Drawing.Point(12, 366);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(6);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(129, 142);
            this.btnHistory.TabIndex = 1;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBook.color = System.Drawing.Color.SeaGreen;
            this.btnBook.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBook.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnBook.ForeColor = System.Drawing.Color.White;
            this.btnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.Image")));
            this.btnBook.ImagePosition = 20;
            this.btnBook.ImageZoom = 50;
            this.btnBook.LabelPosition = 50;
            this.btnBook.LabelText = "Book\nRoom";
            this.btnBook.Location = new System.Drawing.Point(12, 36);
            this.btnBook.Margin = new System.Windows.Forms.Padding(6);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(129, 142);
            this.btnBook.TabIndex = 1;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.SeaGreen;
            this.btnProfile.color = System.Drawing.Color.SeaGreen;
            this.btnProfile.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImagePosition = 20;
            this.btnProfile.ImageZoom = 50;
            this.btnProfile.LabelPosition = 50;
            this.btnProfile.LabelText = "Edit\nProfile";
            this.btnProfile.Location = new System.Drawing.Point(12, 201);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(129, 142);
            this.btnProfile.TabIndex = 1;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(157, 100);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(694, 541);
            this.pnlContent.TabIndex = 3;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 641);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnlTop;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton btnHistory;
        private Bunifu.Framework.UI.BunifuTileButton btnBook;
        private Bunifu.Framework.UI.BunifuTileButton btnProfile;
        private System.Windows.Forms.Panel pnlContent;
    }
}