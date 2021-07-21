namespace WindowsFormsApp1
{
    partial class LoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            this.hotelPict = new System.Windows.Forms.PictureBox();
            this.HotelLbl = new System.Windows.Forms.Label();
            this.Mgmtlbl = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClosePic = new System.Windows.Forms.PictureBox();
            this.MinimizePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hotelPict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePic)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelPict
            // 
            this.hotelPict.Image = global::WindowsFormsApp1.Properties.Resources._80245574_1364008137087468_2222821957101944832_n;
            this.hotelPict.Location = new System.Drawing.Point(156, 31);
            this.hotelPict.Name = "hotelPict";
            this.hotelPict.Size = new System.Drawing.Size(186, 156);
            this.hotelPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotelPict.TabIndex = 36;
            this.hotelPict.TabStop = false;
            // 
            // HotelLbl
            // 
            this.HotelLbl.AutoSize = true;
            this.HotelLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.HotelLbl.Font = new System.Drawing.Font("Microsoft YaHei", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelLbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HotelLbl.Location = new System.Drawing.Point(147, 199);
            this.HotelLbl.Name = "HotelLbl";
            this.HotelLbl.Size = new System.Drawing.Size(134, 52);
            this.HotelLbl.TabIndex = 37;
            this.HotelLbl.Text = "Hotel";
            // 
            // Mgmtlbl
            // 
            this.Mgmtlbl.AutoSize = true;
            this.Mgmtlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.Mgmtlbl.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mgmtlbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Mgmtlbl.Location = new System.Drawing.Point(161, 245);
            this.Mgmtlbl.Name = "Mgmtlbl";
            this.Mgmtlbl.Size = new System.Drawing.Size(272, 31);
            this.Mgmtlbl.TabIndex = 38;
            this.Mgmtlbl.Text = "Menagement System";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(535, 394);
            this.shapeContainer1.TabIndex = 39;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.White;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.rectangleShape2.BorderWidth = 3;
            this.rectangleShape2.CornerRadius = 3;
            this.rectangleShape2.FillColor = System.Drawing.SystemColors.Control;
            this.rectangleShape2.Location = new System.Drawing.Point(132, 292);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(9, 6);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.CornerRadius = 8;
            this.rectangleShape1.Location = new System.Drawing.Point(127, 287);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(266, 16);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClosePic
            // 
            this.ClosePic.Image = ((System.Drawing.Image)(resources.GetObject("ClosePic.Image")));
            this.ClosePic.Location = new System.Drawing.Point(512, 3);
            this.ClosePic.Name = "ClosePic";
            this.ClosePic.Size = new System.Drawing.Size(20, 22);
            this.ClosePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClosePic.TabIndex = 41;
            this.ClosePic.TabStop = false;
            this.ClosePic.Click += new System.EventHandler(this.ClosePic_Click);
            // 
            // MinimizePic
            // 
            this.MinimizePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizePic.Image = ((System.Drawing.Image)(resources.GetObject("MinimizePic.Image")));
            this.MinimizePic.Location = new System.Drawing.Point(489, 9);
            this.MinimizePic.Name = "MinimizePic";
            this.MinimizePic.Size = new System.Drawing.Size(20, 22);
            this.MinimizePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePic.TabIndex = 40;
            this.MinimizePic.TabStop = false;
            this.MinimizePic.Click += new System.EventHandler(this.MinimizePic_Click);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(57)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(535, 394);
            this.Controls.Add(this.ClosePic);
            this.Controls.Add(this.MinimizePic);
            this.Controls.Add(this.HotelLbl);
            this.Controls.Add(this.Mgmtlbl);
            this.Controls.Add(this.hotelPict);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadForm";
            ((System.ComponentModel.ISupportInitialize)(this.hotelPict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hotelPict;
        private System.Windows.Forms.Label HotelLbl;
        private System.Windows.Forms.Label Mgmtlbl;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ClosePic;
        private System.Windows.Forms.PictureBox MinimizePic;
    }
}