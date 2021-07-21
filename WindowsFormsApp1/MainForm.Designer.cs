namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeaderBox = new System.Windows.Forms.GroupBox();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MgmtLbl = new System.Windows.Forms.Label();
            this.HotelLbl = new System.Windows.Forms.Label();
            this.BottomBox = new System.Windows.Forms.GroupBox();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.reservationbtn = new ePOSOne.btnProduct.Button_WOC();
            this.ReceptionistPic = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.HeaderBox.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BottomBox.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistPic)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderBox
            // 
            this.HeaderBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.HeaderBox.Controls.Add(this.ControlPanel);
            this.HeaderBox.Controls.Add(this.pictureBox1);
            this.HeaderBox.Controls.Add(this.MgmtLbl);
            this.HeaderBox.Controls.Add(this.HotelLbl);
            this.HeaderBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderBox.Location = new System.Drawing.Point(0, 0);
            this.HeaderBox.Name = "HeaderBox";
            this.HeaderBox.Size = new System.Drawing.Size(800, 118);
            this.HeaderBox.TabIndex = 3;
            this.HeaderBox.TabStop = false;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.ClosePic);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ControlPanel.Location = new System.Drawing.Point(721, 16);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(76, 99);
            this.ControlPanel.TabIndex = 9;
            // 
            // ClosePic
            // 
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(52, 0);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(20, 22);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 10;
            this.ClosePic.TabStop = false;
            this.toolTip1.SetToolTip(this.ClosePic, "Close");
            this.ClosePic.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._80245574_1364008137087468_2222821957101944832_n;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MgmtLbl
            // 
            this.MgmtLbl.AutoSize = true;
            this.MgmtLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MgmtLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MgmtLbl.Location = new System.Drawing.Point(135, 71);
            this.MgmtLbl.Name = "MgmtLbl";
            this.MgmtLbl.Size = new System.Drawing.Size(214, 27);
            this.MgmtLbl.TabIndex = 4;
            this.MgmtLbl.Text = "Menagement System";
            // 
            // HotelLbl
            // 
            this.HotelLbl.AutoSize = true;
            this.HotelLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HotelLbl.Location = new System.Drawing.Point(132, 19);
            this.HotelLbl.Name = "HotelLbl";
            this.HotelLbl.Size = new System.Drawing.Size(134, 52);
            this.HotelLbl.TabIndex = 3;
            this.HotelLbl.Text = "Hotel";
            // 
            // BottomBox
            // 
            this.BottomBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BottomBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.BottomBox.Controls.Add(this.CenterPanel);
            this.BottomBox.Location = new System.Drawing.Point(0, 121);
            this.BottomBox.Name = "BottomBox";
            this.BottomBox.Size = new System.Drawing.Size(800, 332);
            this.BottomBox.TabIndex = 4;
            this.BottomBox.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CenterPanel.Controls.Add(this.reservationbtn);
            this.CenterPanel.Controls.Add(this.ReceptionistPic);
            this.CenterPanel.Location = new System.Drawing.Point(117, 30);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(580, 259);
            this.CenterPanel.TabIndex = 3;
            // 
            // reservationbtn
            // 
            this.reservationbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reservationbtn.BackColor = System.Drawing.Color.Transparent;
            this.reservationbtn.BorderColor = System.Drawing.Color.Transparent;
            this.reservationbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.reservationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationbtn.FlatAppearance.BorderSize = 0;
            this.reservationbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reservationbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reservationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationbtn.Location = new System.Drawing.Point(175, 211);
            this.reservationbtn.Name = "reservationbtn";
            this.reservationbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.reservationbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.reservationbtn.Size = new System.Drawing.Size(180, 33);
            this.reservationbtn.TabIndex = 23;
            this.reservationbtn.Text = "Receptionist";
            this.reservationbtn.TextColor = System.Drawing.Color.White;
            this.reservationbtn.UseVisualStyleBackColor = false;
            this.reservationbtn.Click += new System.EventHandler(this.reservationbtn_Click);
            // 
            // ReceptionistPic
            // 
            this.ReceptionistPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ReceptionistPic.Image = ((System.Drawing.Image)(resources.GetObject("ReceptionistPic.Image")));
            this.ReceptionistPic.Location = new System.Drawing.Point(165, 9);
            this.ReceptionistPic.Name = "ReceptionistPic";
            this.ReceptionistPic.Size = new System.Drawing.Size(206, 182);
            this.ReceptionistPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReceptionistPic.TabIndex = 1;
            this.ReceptionistPic.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.reservationbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BottomBox);
            this.Controls.Add(this.HeaderBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.HeaderBox.ResumeLayout(false);
            this.HeaderBox.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BottomBox.ResumeLayout(false);
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReceptionistPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox HeaderBox;
        private System.Windows.Forms.Label HotelLbl;
        private System.Windows.Forms.Label MgmtLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox BottomBox;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.PictureBox ReceptionistPic;
        private ePOSOne.btnProduct.Button_WOC reservationbtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ClosePic;
    }
}

