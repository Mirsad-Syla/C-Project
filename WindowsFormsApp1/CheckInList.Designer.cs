namespace WindowsFormsApp1
{
    partial class CheckInList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckInList));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.MaxPicture = new System.Windows.Forms.PictureBox();
            this.MinimizePic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.DateTimelbl = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.Logoutbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.Checkoutlistbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.checkoutbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.CheckInlistbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.CheckInbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reservationlistbtn = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.reservationsbtn = new ePOSOne.btnProduct.Button_WOC();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Filterbtn = new System.Windows.Forms.Button();
            this.ChListbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.HeaderPanel.TabIndex = 17;
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
            this.RightPanel.TabIndex = 24;
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
            this.MinimizePic.Location = new System.Drawing.Point(7, 12);
            this.MinimizePic.Name = "MinimizePic";
            this.MinimizePic.Size = new System.Drawing.Size(24, 21);
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
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.NavigationPanel.Controls.Add(this.DateTimelbl);
            this.NavigationPanel.Controls.Add(this.pictureBox12);
            this.NavigationPanel.Controls.Add(this.Logoutbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox7);
            this.NavigationPanel.Controls.Add(this.Checkoutlistbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox9);
            this.NavigationPanel.Controls.Add(this.checkoutbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox6);
            this.NavigationPanel.Controls.Add(this.CheckInlistbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox5);
            this.NavigationPanel.Controls.Add(this.CheckInbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox3);
            this.NavigationPanel.Controls.Add(this.reservationlistbtn);
            this.NavigationPanel.Controls.Add(this.pictureBox8);
            this.NavigationPanel.Controls.Add(this.reservationsbtn);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 33);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NavigationPanel.Size = new System.Drawing.Size(204, 417);
            this.NavigationPanel.TabIndex = 18;
            // 
            // DateTimelbl
            // 
            this.DateTimelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimelbl.AutoSize = true;
            this.DateTimelbl.Location = new System.Drawing.Point(45, 400);
            this.DateTimelbl.Name = "DateTimelbl";
            this.DateTimelbl.Size = new System.Drawing.Size(35, 13);
            this.DateTimelbl.TabIndex = 82;
            this.DateTimelbl.Text = "label4";
            this.DateTimelbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = global::WindowsFormsApp1.Properties.Resources.Logout;
            this.pictureBox12.Location = new System.Drawing.Point(24, 260);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(22, 20);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 81;
            this.pictureBox12.TabStop = false;
            // 
            // Logoutbtn
            // 
            this.Logoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Logoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoutbtn.FlatAppearance.BorderSize = 0;
            this.Logoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Logoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logoutbtn.Location = new System.Drawing.Point(13, 252);
            this.Logoutbtn.Name = "Logoutbtn";
            this.Logoutbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logoutbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Logoutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Logoutbtn.Size = new System.Drawing.Size(180, 33);
            this.Logoutbtn.TabIndex = 80;
            this.Logoutbtn.TabStop = false;
            this.Logoutbtn.Text = "Log out";
            this.Logoutbtn.TextColor = System.Drawing.Color.White;
            this.Logoutbtn.UseVisualStyleBackColor = false;
            this.Logoutbtn.Click += new System.EventHandler(this.Logoutbtn_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::WindowsFormsApp1.Properties.Resources.Reservation;
            this.pictureBox7.Location = new System.Drawing.Point(24, 224);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 20);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 73;
            this.pictureBox7.TabStop = false;
            // 
            // Checkoutlistbtn
            // 
            this.Checkoutlistbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Checkoutlistbtn.BackColor = System.Drawing.Color.Transparent;
            this.Checkoutlistbtn.BorderColor = System.Drawing.Color.Transparent;
            this.Checkoutlistbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Checkoutlistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkoutlistbtn.FlatAppearance.BorderSize = 0;
            this.Checkoutlistbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Checkoutlistbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Checkoutlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Checkoutlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Checkoutlistbtn.Location = new System.Drawing.Point(13, 213);
            this.Checkoutlistbtn.Name = "Checkoutlistbtn";
            this.Checkoutlistbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Checkoutlistbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Checkoutlistbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.Checkoutlistbtn.Size = new System.Drawing.Size(180, 33);
            this.Checkoutlistbtn.TabIndex = 72;
            this.Checkoutlistbtn.TabStop = false;
            this.Checkoutlistbtn.Text = "Check Out list";
            this.Checkoutlistbtn.TextColor = System.Drawing.Color.White;
            this.Checkoutlistbtn.UseVisualStyleBackColor = false;
            this.Checkoutlistbtn.Click += new System.EventHandler(this.Checkoutlistbtn_Click_1);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = global::WindowsFormsApp1.Properties.Resources.tick1;
            this.pictureBox9.Location = new System.Drawing.Point(24, 181);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(22, 20);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 71;
            this.pictureBox9.TabStop = false;
            // 
            // checkoutbtn
            // 
            this.checkoutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkoutbtn.BackColor = System.Drawing.Color.Transparent;
            this.checkoutbtn.BorderColor = System.Drawing.Color.Transparent;
            this.checkoutbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.checkoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkoutbtn.FlatAppearance.BorderSize = 0;
            this.checkoutbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkoutbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkoutbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutbtn.Location = new System.Drawing.Point(13, 174);
            this.checkoutbtn.Name = "checkoutbtn";
            this.checkoutbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkoutbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.checkoutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.checkoutbtn.Size = new System.Drawing.Size(180, 33);
            this.checkoutbtn.TabIndex = 70;
            this.checkoutbtn.TabStop = false;
            this.checkoutbtn.Text = "Check Out";
            this.checkoutbtn.TextColor = System.Drawing.Color.White;
            this.checkoutbtn.UseVisualStyleBackColor = false;
            this.checkoutbtn.Click += new System.EventHandler(this.checkoutbtn_Click_1);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Image = global::WindowsFormsApp1.Properties.Resources.Reservation;
            this.pictureBox6.Location = new System.Drawing.Point(24, 146);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(22, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 69;
            this.pictureBox6.TabStop = false;
            // 
            // CheckInlistbtn
            // 
            this.CheckInlistbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckInlistbtn.BackColor = System.Drawing.Color.Transparent;
            this.CheckInlistbtn.BorderColor = System.Drawing.Color.Transparent;
            this.CheckInlistbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckInlistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckInlistbtn.FlatAppearance.BorderSize = 0;
            this.CheckInlistbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CheckInlistbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CheckInlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckInlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInlistbtn.Location = new System.Drawing.Point(13, 135);
            this.CheckInlistbtn.Name = "CheckInlistbtn";
            this.CheckInlistbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckInlistbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.CheckInlistbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CheckInlistbtn.Size = new System.Drawing.Size(180, 33);
            this.CheckInlistbtn.TabIndex = 68;
            this.CheckInlistbtn.TabStop = false;
            this.CheckInlistbtn.Text = "Check In list";
            this.CheckInlistbtn.TextColor = System.Drawing.Color.White;
            this.CheckInlistbtn.UseVisualStyleBackColor = false;
            this.CheckInlistbtn.Click += new System.EventHandler(this.CheckInlistbtn_Click_1);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::WindowsFormsApp1.Properties.Resources.tick1;
            this.pictureBox5.Location = new System.Drawing.Point(24, 102);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(22, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 67;
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
            this.CheckInbtn.TabIndex = 66;
            this.CheckInbtn.TabStop = false;
            this.CheckInbtn.Text = "Check In";
            this.CheckInbtn.TextColor = System.Drawing.Color.White;
            this.CheckInbtn.UseVisualStyleBackColor = false;
            this.CheckInbtn.Click += new System.EventHandler(this.CheckInbtn_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.Reservation;
            this.pictureBox3.Location = new System.Drawing.Point(24, 70);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 65;
            this.pictureBox3.TabStop = false;
            // 
            // reservationlistbtn
            // 
            this.reservationlistbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationlistbtn.BackColor = System.Drawing.Color.Transparent;
            this.reservationlistbtn.BorderColor = System.Drawing.Color.Transparent;
            this.reservationlistbtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.reservationlistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservationlistbtn.FlatAppearance.BorderSize = 0;
            this.reservationlistbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.reservationlistbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.reservationlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationlistbtn.Location = new System.Drawing.Point(13, 59);
            this.reservationlistbtn.Name = "reservationlistbtn";
            this.reservationlistbtn.OnHoverBorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reservationlistbtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.reservationlistbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.reservationlistbtn.Size = new System.Drawing.Size(180, 33);
            this.reservationlistbtn.TabIndex = 64;
            this.reservationlistbtn.TabStop = false;
            this.reservationlistbtn.Text = "Reservations list";
            this.reservationlistbtn.TextColor = System.Drawing.Color.White;
            this.reservationlistbtn.UseVisualStyleBackColor = false;
            this.reservationlistbtn.Click += new System.EventHandler(this.reservationlistbtn_Click_1);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = global::WindowsFormsApp1.Properties.Resources.tick1;
            this.pictureBox8.Location = new System.Drawing.Point(24, 26);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 20);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 63;
            this.pictureBox8.TabStop = false;
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
            this.reservationsbtn.TabIndex = 62;
            this.reservationsbtn.TabStop = false;
            this.reservationsbtn.Text = "Reservations";
            this.reservationsbtn.TextColor = System.Drawing.Color.White;
            this.reservationsbtn.UseVisualStyleBackColor = false;
            this.reservationsbtn.Click += new System.EventHandler(this.reservationsbtn_Click_1);
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
            this.groupBox1.Location = new System.Drawing.Point(222, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 322);
            this.groupBox1.TabIndex = 28;
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
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.Filterbtn);
            this.groupBox2.Controls.Add(this.ChListbtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FromDate);
            this.groupBox2.Controls.Add(this.Fromlbl);
            this.groupBox2.Controls.Add(this.ToDate);
            this.groupBox2.Location = new System.Drawing.Point(221, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 52);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // Filterbtn
            // 
            this.Filterbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Filterbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filterbtn.ForeColor = System.Drawing.Color.White;
            this.Filterbtn.Location = new System.Drawing.Point(121, 14);
            this.Filterbtn.Name = "Filterbtn";
            this.Filterbtn.Size = new System.Drawing.Size(90, 28);
            this.Filterbtn.TabIndex = 1;
            this.Filterbtn.Text = "&Filter Data";
            this.Filterbtn.UseVisualStyleBackColor = false;
            this.Filterbtn.Click += new System.EventHandler(this.Filterbtn_Click);
            this.Filterbtn.MouseLeave += new System.EventHandler(this.Filterbtn_MouseLeave);
            this.Filterbtn.MouseHover += new System.EventHandler(this.Filterbtn_MouseHover);
            // 
            // ChListbtn
            // 
            this.ChListbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ChListbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChListbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChListbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChListbtn.ForeColor = System.Drawing.Color.White;
            this.ChListbtn.Location = new System.Drawing.Point(6, 14);
            this.ChListbtn.Name = "ChListbtn";
            this.ChListbtn.Size = new System.Drawing.Size(109, 28);
            this.ChListbtn.TabIndex = 0;
            this.ChListbtn.Text = "&Show List";
            this.ChListbtn.UseVisualStyleBackColor = false;
            this.ChListbtn.Click += new System.EventHandler(this.ChListbtn_Click);
            this.ChListbtn.MouseLeave += new System.EventHandler(this.ChListbtn_MouseLeave);
            this.ChListbtn.MouseHover += new System.EventHandler(this.ChListbtn_MouseHover);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(204, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // CheckInList
            // 
            this.AcceptButton = this.ChListbtn;
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
            this.Name = "CheckInList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckInList";
            this.Load += new System.EventHandler(this.CheckInList_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.Label Fromlbl;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.PictureBox MaxPicture;
        private System.Windows.Forms.PictureBox MinimizePic;
        private System.Windows.Forms.PictureBox pictureBox12;
        private ePOSOne.btnProduct.Button_WOC Logoutbtn;
        private System.Windows.Forms.PictureBox pictureBox7;
        private ePOSOne.btnProduct.Button_WOC Checkoutlistbtn;
        private System.Windows.Forms.PictureBox pictureBox9;
        private ePOSOne.btnProduct.Button_WOC checkoutbtn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ePOSOne.btnProduct.Button_WOC CheckInlistbtn;
        private System.Windows.Forms.PictureBox pictureBox5;
        private ePOSOne.btnProduct.Button_WOC CheckInbtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ePOSOne.btnProduct.Button_WOC reservationlistbtn;
        private System.Windows.Forms.PictureBox pictureBox8;
        private ePOSOne.btnProduct.Button_WOC reservationsbtn;
        private System.Windows.Forms.Label DateTimelbl;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.PictureBox ClosePic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ChListbtn;
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