namespace WindowsFormsApp1
{
    partial class LOG_IN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOG_IN));
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hotelPict = new System.Windows.Forms.PictureBox();
            this.LRPanel = new System.Windows.Forms.Panel();
            this.pswTxt = new System.Windows.Forms.TextBox();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PswLbl = new System.Windows.Forms.LinkLabel();
            this.UserPicture = new System.Windows.Forms.PictureBox();
            this.HotelLbl = new System.Windows.Forms.Label();
            this.Mgmtlbl = new System.Windows.Forms.Label();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LogInBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ControlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPict)).BeginInit();
            this.LRPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LogInBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(0, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 21);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.toolTip3.SetToolTip(this.pictureBox5, "Minimize");
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // ClosePic
            // 
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(54, 0);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(20, 22);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 25;
            this.ClosePic.TabStop = false;
            this.toolTip1.SetToolTip(this.ClosePic, "Close");
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 22);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox3, "Maximize/Restore");
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Controls.Add(this.ClosePic);
            this.ControlPanel.Controls.Add(this.pictureBox3);
            this.ControlPanel.Controls.Add(this.pictureBox5);
            this.ControlPanel.Location = new System.Drawing.Point(478, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(76, 450);
            this.ControlPanel.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.ControlPanel);
            this.panel1.Controls.Add(this.bottomPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(246, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(554, 450);
            this.panel1.TabIndex = 4;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.panel2);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(0, 0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(554, 450);
            this.bottomPanel.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.Controls.Add(this.hotelPict);
            this.panel2.Controls.Add(this.LRPanel);
            this.panel2.Controls.Add(this.HotelLbl);
            this.panel2.Controls.Add(this.Mgmtlbl);
            this.panel2.Location = new System.Drawing.Point(6, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(466, 434);
            this.panel2.TabIndex = 34;
            // 
            // hotelPict
            // 
            this.hotelPict.Image = global::WindowsFormsApp1.Properties.Resources._80245574_1364008137087468_2222821957101944832_n;
            this.hotelPict.Location = new System.Drawing.Point(12, 24);
            this.hotelPict.Name = "hotelPict";
            this.hotelPict.Size = new System.Drawing.Size(107, 64);
            this.hotelPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotelPict.TabIndex = 35;
            this.hotelPict.TabStop = false;
            // 
            // LRPanel
            // 
            this.LRPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LRPanel.Controls.Add(this.pswTxt);
            this.LRPanel.Controls.Add(this.userTxt);
            this.LRPanel.Controls.Add(this.Loginbtn);
            this.LRPanel.Controls.Add(this.pictureBox2);
            this.LRPanel.Controls.Add(this.PswLbl);
            this.LRPanel.Controls.Add(this.UserPicture);
            this.LRPanel.Location = new System.Drawing.Point(45, 171);
            this.LRPanel.Name = "LRPanel";
            this.LRPanel.Size = new System.Drawing.Size(358, 216);
            this.LRPanel.TabIndex = 33;
            // 
            // pswTxt
            // 
            this.pswTxt.Location = new System.Drawing.Point(74, 76);
            this.pswTxt.Name = "pswTxt";
            this.pswTxt.PasswordChar = '*';
            this.pswTxt.Size = new System.Drawing.Size(220, 20);
            this.pswTxt.TabIndex = 1;
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(74, 35);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(220, 20);
            this.userTxt.TabIndex = 0;
            // 
            // Loginbtn
            // 
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginbtn.Location = new System.Drawing.Point(74, 118);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(220, 34);
            this.Loginbtn.TabIndex = 2;
            this.Loginbtn.Text = "&Login";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.key;
            this.pictureBox2.Location = new System.Drawing.Point(40, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // PswLbl
            // 
            this.PswLbl.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.PswLbl.AutoSize = true;
            this.PswLbl.DisabledLinkColor = System.Drawing.Color.White;
            this.PswLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PswLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PswLbl.LinkColor = System.Drawing.Color.White;
            this.PswLbl.Location = new System.Drawing.Point(119, 177);
            this.PswLbl.Name = "PswLbl";
            this.PswLbl.Size = new System.Drawing.Size(147, 18);
            this.PswLbl.TabIndex = 3;
            this.PswLbl.TabStop = true;
            this.PswLbl.Text = "Forgot Password?";
            this.PswLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PswLbl_LinkClicked);
            // 
            // UserPicture
            // 
            this.UserPicture.Image = global::WindowsFormsApp1.Properties.Resources.user;
            this.UserPicture.Location = new System.Drawing.Point(40, 35);
            this.UserPicture.Name = "UserPicture";
            this.UserPicture.Size = new System.Drawing.Size(28, 23);
            this.UserPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicture.TabIndex = 28;
            this.UserPicture.TabStop = false;
            // 
            // HotelLbl
            // 
            this.HotelLbl.AutoSize = true;
            this.HotelLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.HotelLbl.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HotelLbl.Location = new System.Drawing.Point(122, 29);
            this.HotelLbl.Name = "HotelLbl";
            this.HotelLbl.Size = new System.Drawing.Size(106, 42);
            this.HotelLbl.TabIndex = 33;
            this.HotelLbl.Text = "Hotel";
            // 
            // Mgmtlbl
            // 
            this.Mgmtlbl.AutoSize = true;
            this.Mgmtlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Mgmtlbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mgmtlbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Mgmtlbl.Location = new System.Drawing.Point(125, 71);
            this.Mgmtlbl.Name = "Mgmtlbl";
            this.Mgmtlbl.Size = new System.Drawing.Size(180, 22);
            this.Mgmtlbl.TabIndex = 34;
            this.Mgmtlbl.Text = "Menagement System";
            // 
            // LoginLbl
            // 
            this.LoginLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoginLbl.BackColor = System.Drawing.Color.Transparent;
            this.LoginLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LoginLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.LoginLbl.Location = new System.Drawing.Point(10, 377);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(216, 24);
            this.LoginLbl.TabIndex = 1;
            this.LoginLbl.Text = "Login to your Account";
            this.LoginLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.person1;
            this.pictureBox1.Location = new System.Drawing.Point(32, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LogInBox
            // 
            this.LogInBox.BackColor = System.Drawing.Color.White;
            this.LogInBox.Controls.Add(this.LoginLbl);
            this.LogInBox.Controls.Add(this.pictureBox1);
            this.LogInBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogInBox.Location = new System.Drawing.Point(0, 0);
            this.LogInBox.Name = "LogInBox";
            this.LogInBox.Size = new System.Drawing.Size(246, 450);
            this.LogInBox.TabIndex = 3;
            this.LogInBox.TabStop = false;
            // 
            // LOG_IN
            // 
            this.AcceptButton = this.Loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogInBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOG_IN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOG_IN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPict)).EndInit();
            this.LRPanel.ResumeLayout(false);
            this.LRPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LogInBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ClosePic;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox LogInBox;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox hotelPict;
        private System.Windows.Forms.Panel LRPanel;
        private System.Windows.Forms.TextBox pswTxt;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel PswLbl;
        private System.Windows.Forms.PictureBox UserPicture;
        private System.Windows.Forms.Label HotelLbl;
        private System.Windows.Forms.Label Mgmtlbl;
    }
}