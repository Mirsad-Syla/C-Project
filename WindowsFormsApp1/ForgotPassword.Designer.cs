namespace WindowsFormsApp1
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            this.FillPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordlbl = new System.Windows.Forms.Label();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.CityAnswertxt = new System.Windows.Forms.TextBox();
            this.MovieAnswertxt = new System.Windows.Forms.TextBox();
            this.Submitbtn = new System.Windows.Forms.Button();
            this.SecondQuestionlbl = new System.Windows.Forms.Label();
            this.FirstQuestionlbl = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FillPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FillPanel
            // 
            this.FillPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FillPanel.Controls.Add(this.panel1);
            this.FillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FillPanel.Location = new System.Drawing.Point(0, 33);
            this.FillPanel.Name = "FillPanel";
            this.FillPanel.Size = new System.Drawing.Size(800, 395);
            this.FillPanel.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.passwordtxt);
            this.panel1.Controls.Add(this.usernametxt);
            this.panel1.Controls.Add(this.Passwordlbl);
            this.panel1.Controls.Add(this.Usernamelbl);
            this.panel1.Controls.Add(this.CityAnswertxt);
            this.panel1.Controls.Add(this.MovieAnswertxt);
            this.panel1.Controls.Add(this.Submitbtn);
            this.panel1.Controls.Add(this.SecondQuestionlbl);
            this.panel1.Controls.Add(this.FirstQuestionlbl);
            this.panel1.Location = new System.Drawing.Point(181, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 326);
            this.panel1.TabIndex = 0;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Enabled = false;
            this.passwordtxt.Location = new System.Drawing.Point(243, 164);
            this.passwordtxt.Multiline = true;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(109, 27);
            this.passwordtxt.TabIndex = 10;
            // 
            // usernametxt
            // 
            this.usernametxt.Enabled = false;
            this.usernametxt.Location = new System.Drawing.Point(243, 74);
            this.usernametxt.Multiline = true;
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(109, 27);
            this.usernametxt.TabIndex = 9;
            // 
            // Passwordlbl
            // 
            this.Passwordlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Passwordlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordlbl.Location = new System.Drawing.Point(250, 141);
            this.Passwordlbl.Name = "Passwordlbl";
            this.Passwordlbl.Size = new System.Drawing.Size(84, 20);
            this.Passwordlbl.TabIndex = 8;
            this.Passwordlbl.Text = "Password:";
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Usernamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(250, 51);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(86, 20);
            this.Usernamelbl.TabIndex = 7;
            this.Usernamelbl.Text = "Username:";
            // 
            // CityAnswertxt
            // 
            this.CityAnswertxt.Location = new System.Drawing.Point(37, 164);
            this.CityAnswertxt.Multiline = true;
            this.CityAnswertxt.Name = "CityAnswertxt";
            this.CityAnswertxt.Size = new System.Drawing.Size(162, 27);
            this.CityAnswertxt.TabIndex = 6;
            this.CityAnswertxt.MouseLeave += new System.EventHandler(this.CityAnswertxt_MouseLeave);
            this.CityAnswertxt.MouseHover += new System.EventHandler(this.CityAnswertxt_MouseHover);
            // 
            // MovieAnswertxt
            // 
            this.MovieAnswertxt.Location = new System.Drawing.Point(37, 74);
            this.MovieAnswertxt.Multiline = true;
            this.MovieAnswertxt.Name = "MovieAnswertxt";
            this.MovieAnswertxt.Size = new System.Drawing.Size(162, 27);
            this.MovieAnswertxt.TabIndex = 5;
            this.MovieAnswertxt.MouseLeave += new System.EventHandler(this.MovieAnswertxt_MouseLeave_1);
            this.MovieAnswertxt.MouseHover += new System.EventHandler(this.MovieAnswertxt_MouseHover_1);
            // 
            // Submitbtn
            // 
            this.Submitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbtn.Location = new System.Drawing.Point(53, 223);
            this.Submitbtn.Name = "Submitbtn";
            this.Submitbtn.Size = new System.Drawing.Size(146, 40);
            this.Submitbtn.TabIndex = 4;
            this.Submitbtn.Text = "&Submit";
            this.Submitbtn.UseVisualStyleBackColor = true;
            this.Submitbtn.Click += new System.EventHandler(this.Submitbtn_Click);
            this.Submitbtn.MouseLeave += new System.EventHandler(this.Submitbtn_MouseLeave);
            this.Submitbtn.MouseHover += new System.EventHandler(this.Submitbtn_MouseHover);
            // 
            // SecondQuestionlbl
            // 
            this.SecondQuestionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondQuestionlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondQuestionlbl.Location = new System.Drawing.Point(21, 141);
            this.SecondQuestionlbl.Name = "SecondQuestionlbl";
            this.SecondQuestionlbl.Size = new System.Drawing.Size(205, 20);
            this.SecondQuestionlbl.TabIndex = 1;
            this.SecondQuestionlbl.Text = "In what city were you born?";
            // 
            // FirstQuestionlbl
            // 
            this.FirstQuestionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstQuestionlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstQuestionlbl.Location = new System.Drawing.Point(19, 51);
            this.FirstQuestionlbl.Name = "FirstQuestionlbl";
            this.FirstQuestionlbl.Size = new System.Drawing.Size(205, 20);
            this.FirstQuestionlbl.TabIndex = 0;
            this.FirstQuestionlbl.Text = "What is your favorite movie?";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(102, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOTEL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(161, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._80245574_1364008137087468_2222821957101944832_n;
            this.pictureBox1.Location = new System.Drawing.Point(13, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.RightPanel.Controls.Add(this.ClosePic);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(717, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(83, 33);
            this.RightPanel.TabIndex = 28;
            // 
            // ClosePic
            // 
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(59, 3);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(20, 22);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 25;
            this.ClosePic.TabStop = false;
            this.toolTip1.SetToolTip(this.ClosePic, "Close");
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.HeaderPanel.Controls.Add(this.RightPanel);
            this.HeaderPanel.Controls.Add(this.pictureBox1);
            this.HeaderPanel.Controls.Add(this.label2);
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(800, 33);
            this.HeaderPanel.TabIndex = 24;
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.Submitbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FillPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.FillPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FillPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox ClosePic;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Submitbtn;
        private System.Windows.Forms.Label SecondQuestionlbl;
        private System.Windows.Forms.Label FirstQuestionlbl;
        private System.Windows.Forms.TextBox CityAnswertxt;
        private System.Windows.Forms.TextBox MovieAnswertxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label Passwordlbl;
        private System.Windows.Forms.Label Usernamelbl;
    }
}