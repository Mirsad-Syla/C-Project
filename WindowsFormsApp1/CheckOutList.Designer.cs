namespace WindowsFormsApp1
{
    partial class CheckOutList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOutList));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.MaxPicture = new System.Windows.Forms.PictureBox();
            this.MinimizePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateAndTimelbl = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.LogOutbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CheckOutListbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.CheckOutbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.CheckInListbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CheckInbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.ReservationListbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reservationsbtn = new ePOSOne.btnProduct.Button_WOC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Filterbtn = new System.Windows.Forms.Button();
            this.ChOListbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.Fromlbl = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GuestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Children = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Food = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.HeaderPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.HeaderPanel.TabIndex = 19;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.RightPanel.Controls.Add(this.ClosePic);
            this.RightPanel.Controls.Add(this.MaxPicture);
            this.RightPanel.Controls.Add(this.MinimizePic);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(717, 0);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(83, 33);
            this.RightPanel.TabIndex = 26;
            // 
            // ClosePic
            // 
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(59, 3);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(20, 22);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 24;
            this.ClosePic.TabStop = false;
            this.toolTip1.SetToolTip(this.ClosePic, "Close");
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click_2);
            // 
            // MaxPicture
            // 
            this.MaxPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MaxPicture.Image = ((System.Drawing.Image)(resources.GetObject("MaxPicture.Image")));
            this.MaxPicture.Location = new System.Drawing.Point(33, 3);
            this.MaxPicture.Name = "MaxPicture";
            this.MaxPicture.Size = new System.Drawing.Size(20, 22);
            this.MaxPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaxPicture.TabIndex = 23;
            this.MaxPicture.TabStop = false;
            this.toolTip2.SetToolTip(this.MaxPicture, "Maximize/Restore");
            this.MaxPicture.Click += new System.EventHandler(this.MaxPicture_Click);
            // 
            // MinimizePic
            // 
            this.MinimizePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizePic.Image = ((System.Drawing.Image)(resources.GetObject("MinimizePic.Image")));
            this.MinimizePic.Location = new System.Drawing.Point(5, 12);
            this.MinimizePic.Name = "MinimizePic";
            this.MinimizePic.Size = new System.Drawing.Size(20, 22);
            this.MinimizePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePic.TabIndex = 22;
            this.MinimizePic.TabStop = false;
            this.toolTip3.SetToolTip(this.MinimizePic, "Minimize");
            this.MinimizePic.Click += new System.EventHandler(this.MinimizePic_Click_1);
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
            // DateAndTimelbl
            // 
            this.DateAndTimelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateAndTimelbl.AutoSize = true;
            this.DateAndTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAndTimelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DateAndTimelbl.Location = new System.Drawing.Point(45, 400);
            this.DateAndTimelbl.Name = "DateAndTimelbl";
            this.DateAndTimelbl.Size = new System.Drawing.Size(35, 13);
            this.DateAndTimelbl.TabIndex = 19;
            this.DateAndTimelbl.Text = "label6";
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NavigationPanel.Controls.Add(this.pictureBox12);
            this.NavigationPanel.Controls.Add(this.LogOutbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox4);
            this.NavigationPanel.Controls.Add(this.CheckOutListbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox15);
            this.NavigationPanel.Controls.Add(this.CheckOutbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox14);
            this.NavigationPanel.Controls.Add(this.CheckInListbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox5);
            this.NavigationPanel.Controls.Add(this.CheckInbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox9);
            this.NavigationPanel.Controls.Add(this.ReservationListbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox3);
            this.NavigationPanel.Controls.Add(this.reservationsbtn);
            this.NavigationPanel.Controls.Add(this.DateAndTimelbl);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 33);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NavigationPanel.Size = new System.Drawing.Size(207, 417);
            this.NavigationPanel.TabIndex = 20;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = global::WindowsFormsApp1.Properties.Resources.Logout;
            this.pictureBox12.Location = new System.Drawing.Point(24, 260);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(22, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 83;
            this.pictureBox12.TabStop = false;
            // 
            // LogOutbtn
            // 
            this.LogOutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutbtn.BackColor = System.Drawing.Color.Transparent;
            this.LogOutbtn.BorderColor = System.Drawing.Color.Transparent;
            this.LogOutbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.LogOutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutbtn.FlatAppearance.BorderSize = 0;
            this.LogOutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogOutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutbtn.Location = new System.Drawing.Point(13, 252);
            this.LogOutbtn.Name = "LogOutbtn";
            this.LogOutbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogOutbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.LogOutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.LogOutbtn.Size = new System.Drawing.Size(180, 33);
            this.LogOutbtn.TabIndex = 82;
            this.LogOutbtn.TabStop = false;
            this.LogOutbtn.Text = "Log out";
            this.LogOutbtn.TextColor = System.Drawing.Color.White;
            this.LogOutbtn.UseVisualStyleBackColor = false;
            this.LogOutbtn.Click += new System.EventHandler(this.LogOutbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.Reservation;
            this.pictureBox4.Location = new System.Drawing.Point(24, 224);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 75;
            this.pictureBox4.TabStop = false;
            // 
            // CheckOutListbtn
            // 
            this.CheckOutListbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckOutListbtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckOutListbtn.BorderColor = System.Drawing.Color.Transparent;
            this.CheckOutListbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckOutListbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutListbtn.FlatAppearance.BorderSize = 0;
            this.CheckOutListbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CheckOutListbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CheckOutListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutListbtn.Location = new System.Drawing.Point(13, 213);
            this.CheckOutListbtn.Name = "CheckOutListbtn";
            this.CheckOutListbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckOutListbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckOutListbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckOutListbtn.Size = new System.Drawing.Size(180, 33);
            this.CheckOutListbtn.TabIndex = 74;
            this.CheckOutListbtn.TabStop = false;
            this.CheckOutListbtn.Text = "Check Out list";
            this.CheckOutListbtn.TextColor = System.Drawing.Color.White;
            this.CheckOutListbtn.UseVisualStyleBackColor = false;
            this.CheckOutListbtn.Click += new System.EventHandler(this.CheckOutListbtn_Click_1);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox15.Image = global::WindowsFormsApp1.Properties.Resources.tick1;
            this.pictureBox15.Location = new System.Drawing.Point(24, 181);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(22, 20);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 73;
            this.pictureBox15.TabStop = false;
            // 
            // CheckOutbtn
            // 
            this.CheckOutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckOutbtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckOutbtn.BorderColor = System.Drawing.Color.Transparent;
            this.CheckOutbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckOutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckOutbtn.FlatAppearance.BorderSize = 0;
            this.CheckOutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CheckOutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CheckOutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckOutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutbtn.Location = new System.Drawing.Point(13, 174);
            this.CheckOutbtn.Name = "CheckOutbtn";
            this.CheckOutbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckOutbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckOutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckOutbtn.Size = new System.Drawing.Size(180, 33);
            this.CheckOutbtn.TabIndex = 72;
            this.CheckOutbtn.TabStop = false;
            this.CheckOutbtn.Text = "Check Out ";
            this.CheckOutbtn.TextColor = System.Drawing.Color.White;
            this.CheckOutbtn.UseVisualStyleBackColor = false;
            this.CheckOutbtn.Click += new System.EventHandler(this.CheckOutbtn_Click_1);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.Image = global::WindowsFormsApp1.Properties.Resources.Reservation;
            this.pictureBox14.Location = new System.Drawing.Point(24, 146);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(22, 20);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 71;
            this.pictureBox14.TabStop = false;
            // 
            // CheckInListbtn
            // 
            this.CheckInListbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckInListbtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckInListbtn.BorderColor = System.Drawing.Color.Transparent;
            this.CheckInListbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckInListbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInListbtn.FlatAppearance.BorderSize = 0;
            this.CheckInListbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CheckInListbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CheckInListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInListbtn.Location = new System.Drawing.Point(13, 135);
            this.CheckInListbtn.Name = "CheckInListbtn";
            this.CheckInListbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckInListbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckInListbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckInListbtn.Size = new System.Drawing.Size(180, 33);
            this.CheckInListbtn.TabIndex = 70;
            this.CheckInListbtn.TabStop = false;
            this.CheckInListbtn.Text = "Check In list";
            this.CheckInListbtn.TextColor = System.Drawing.Color.White;
            this.CheckInListbtn.UseVisualStyleBackColor = false;
            this.CheckInListbtn.Click += new System.EventHandler(this.CheckInListbtn_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.tick1;
            this.pictureBox5.Location = new System.Drawing.Point(24, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 69;
            this.pictureBox5.TabStop = false;
            // 
            // CheckInbtn
            // 
            this.CheckInbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckInbtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckInbtn.BorderColor = System.Drawing.Color.Transparent;
            this.CheckInbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckInbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInbtn.FlatAppearance.BorderSize = 0;
            this.CheckInbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CheckInbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CheckInbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInbtn.Location = new System.Drawing.Point(13, 96);
            this.CheckInbtn.Name = "CheckInbtn";
            this.CheckInbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckInbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckInbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckInbtn.Size = new System.Drawing.Size(180, 33);
            this.CheckInbtn.TabIndex = 68;
            this.CheckInbtn.TabStop = false;
            this.CheckInbtn.Text = "Check In";
            this.CheckInbtn.TextColor = System.Drawing.Color.White;
            this.CheckInbtn.UseVisualStyleBackColor = false;
            this.CheckInbtn.Click += new System.EventHandler(this.CheckInbtn_Click_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.Reservation;
            this.pictureBox9.Location = new System.Drawing.Point(24, 70);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 67;
            this.pictureBox9.TabStop = false;
            // 
            // ReservationListbtn
            // 
            this.ReservationListbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ReservationListbtn.BackColor = System.Drawing.Color.Transparent;
            this.ReservationListbtn.BorderColor = System.Drawing.Color.Transparent;
            this.ReservationListbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ReservationListbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReservationListbtn.FlatAppearance.BorderSize = 0;
            this.ReservationListbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ReservationListbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ReservationListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservationListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationListbtn.Location = new System.Drawing.Point(13, 59);
            this.ReservationListbtn.Name = "ReservationListbtn";
            this.ReservationListbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservationListbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ReservationListbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ReservationListbtn.Size = new System.Drawing.Size(180, 33);
            this.ReservationListbtn.TabIndex = 66;
            this.ReservationListbtn.TabStop = false;
            this.ReservationListbtn.Text = "Reservations list";
            this.ReservationListbtn.TextColor = System.Drawing.Color.White;
            this.ReservationListbtn.UseVisualStyleBackColor = false;
            this.ReservationListbtn.Click += new System.EventHandler(this.ReservationListbtn_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.tick1;
            this.pictureBox3.Location = new System.Drawing.Point(24, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // reservationsbtn
            // 
            this.reservationsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationsbtn.BackColor = System.Drawing.Color.Transparent;
            this.reservationsbtn.BorderColor = System.Drawing.Color.Transparent;
            this.reservationsbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.reservationsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationsbtn.FlatAppearance.BorderSize = 0;
            this.reservationsbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reservationsbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reservationsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsbtn.Location = new System.Drawing.Point(13, 20);
            this.reservationsbtn.Name = "reservationsbtn";
            this.reservationsbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationsbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.reservationsbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.reservationsbtn.Size = new System.Drawing.Size(180, 33);
            this.reservationsbtn.TabIndex = 64;
            this.reservationsbtn.TabStop = false;
            this.reservationsbtn.Text = "Reservations";
            this.reservationsbtn.TextColor = System.Drawing.Color.White;
            this.reservationsbtn.UseVisualStyleBackColor = false;
            this.reservationsbtn.Click += new System.EventHandler(this.reservationsbtn_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Filterbtn);
            this.groupBox2.Controls.Add(this.ChOListbtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FromDate);
            this.groupBox2.Controls.Add(this.Fromlbl);
            this.groupBox2.Controls.Add(this.ToDate);
            this.groupBox2.Location = new System.Drawing.Point(223, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 52);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // Filterbtn
            // 
            this.Filterbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Filterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterbtn.ForeColor = System.Drawing.Color.White;
            this.Filterbtn.Location = new System.Drawing.Point(121, 16);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(90, 28);
            this.Filterbtn.TabIndex = 1;
            this.Filterbtn.Text = "&Filter Data";
            this.Filterbtn.UseVisualStyleBackColor = false;
            this.Filterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            this.Filterbtn.MouseLeave += new System.EventHandler(this.Filterbtn_MouseLeave);
            this.Filterbtn.MouseHover += new System.EventHandler(this.Filterbtn_MouseHover);
            // 
            // ChOListbtn
            // 
            this.ChOListbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ChOListbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChOListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChOListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChOListbtn.ForeColor = System.Drawing.Color.White;
            this.ChOListbtn.Location = new System.Drawing.Point(6, 16);
            this.ChOListbtn.Name = "ChOListbtn";
            this.ChOListbtn.Size = new System.Drawing.Size(109, 28);
            this.ChOListbtn.TabIndex = 0;
            this.ChOListbtn.Text = "&Show List";
            this.ChOListbtn.UseVisualStyleBackColor = false;
            this.ChOListbtn.Click += new System.EventHandler(this.ChOListbtn_Click);
            this.ChOListbtn.MouseLeave += new System.EventHandler(this.ChOListbtn_MouseLeave);
            this.ChOListbtn.MouseHover += new System.EventHandler(this.ChOListbtn_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "To:";
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(271, 17);
            this.FromDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(96, 20);
            this.FromDate.TabIndex = 2;
            this.FromDate.MouseLeave += new System.EventHandler(this.FromDate_MouseLeave);
            this.FromDate.MouseHover += new System.EventHandler(this.FromDate_MouseHover);
            // 
            // Fromlbl
            // 
            this.Fromlbl.AutoSize = true;
            this.Fromlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fromlbl.Location = new System.Drawing.Point(214, 19);
            this.Fromlbl.Name = "Fromlbl";
            this.Fromlbl.Size = new System.Drawing.Size(44, 17);
            this.Fromlbl.TabIndex = 26;
            this.Fromlbl.Text = "From:";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(462, 18);
            this.ToDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(96, 20);
            this.ToDate.TabIndex = 3;
            this.ToDate.MouseLeave += new System.EventHandler(this.ToDate_MouseLeave);
            this.ToDate.MouseHover += new System.EventHandler(this.ToDate_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(223, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 322);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GuestName,
            this.RoomNumber,
            this.Days,
            this.CheckIn,
            this.CheckOut,
            this.RoomType,
            this.Adults,
            this.Children,
            this.Gender,
            this.Food,
            this.Total});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(558, 303);
            this.dataGridView1.TabIndex = 0;
            // 
            // GuestName
            // 
            this.GuestName.HeaderText = "GuestName";
            this.GuestName.Name = "GuestName";
            this.GuestName.ReadOnly = true;
            // 
            // RoomNumber
            // 
            this.RoomNumber.HeaderText = "RoomNumber";
            this.RoomNumber.Name = "RoomNumber";
            this.RoomNumber.ReadOnly = true;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            // 
            // CheckIn
            // 
            this.CheckIn.HeaderText = "CheckIn";
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "CheckOut";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "RoomType";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // Adults
            // 
            this.Adults.HeaderText = "Adults";
            this.Adults.Name = "Adults";
            this.Adults.ReadOnly = true;
            // 
            // Children
            // 
            this.Children.HeaderText = "Children";
            this.Children.Name = "Children";
            this.Children.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Food
            // 
            this.Food.HeaderText = "Food";
            this.Food.Name = "Food";
            this.Food.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(207, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(593, 22);
            this.statusStrip1.TabIndex = 31;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // CheckOutList
            // 
            this.AcceptButton = this.ChOListbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOutList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckOutList";
            this.Load += new System.EventHandler(this.CheckOutList_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.NavigationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DateAndTimelbl;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label Fromlbl;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox MaxPicture;
        private System.Windows.Forms.PictureBox MinimizePic;
        private System.Windows.Forms.PictureBox pictureBox12;
        private ePOSOne.btnProduct.Button_WOC LogOutbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ePOSOne.btnProduct.Button_WOC CheckOutListbtn;
        private System.Windows.Forms.PictureBox pictureBox15;
        private ePOSOne.btnProduct.Button_WOC CheckOutbtn;
        private System.Windows.Forms.PictureBox pictureBox14;
        private ePOSOne.btnProduct.Button_WOC CheckInListbtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ePOSOne.btnProduct.Button_WOC CheckInbtn;
        private System.Windows.Forms.PictureBox pictureBox9;
        private ePOSOne.btnProduct.Button_WOC ReservationListbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ePOSOne.btnProduct.Button_WOC reservationsbtn;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox ClosePic;
        private System.Windows.Forms.Button ChOListbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GuestName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adults;
        private System.Windows.Forms.DataGridViewTextBoxColumn Children;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Food;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button Filterbtn;
    }
}