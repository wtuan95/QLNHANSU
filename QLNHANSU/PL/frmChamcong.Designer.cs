namespace QLNHANSU.PL
{
    partial class frmChamcong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamcong));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.lblXemchamcong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numLuong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numSongaylam = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSongaylam)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHẤM CÔNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên nhân viên";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTennhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTennhanvien.Location = new System.Drawing.Point(171, 47);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(145, 26);
            this.txtTennhanvien.TabIndex = 2;
            this.txtTennhanvien.TextChanged += new System.EventHandler(this.txtTennhanvien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Chọn tháng";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(171, 126);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(145, 27);
            this.cbThang.TabIndex = 4;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn năm";
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cbNam.Location = new System.Drawing.Point(171, 170);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(145, 27);
            this.cbNam.TabIndex = 4;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(171, 312);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 36);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblXemchamcong
            // 
            this.lblXemchamcong.AutoSize = true;
            this.lblXemchamcong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblXemchamcong.ForeColor = System.Drawing.Color.Blue;
            this.lblXemchamcong.Location = new System.Drawing.Point(167, 90);
            this.lblXemchamcong.Name = "lblXemchamcong";
            this.lblXemchamcong.Size = new System.Drawing.Size(256, 19);
            this.lblXemchamcong.TabIndex = 6;
            this.lblXemchamcong.Text = "Xem danh sách chấm công của nhân viên";
            this.lblXemchamcong.Click += new System.EventHandler(this.lblXemchamcong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lương nhận";
            // 
            // numLuong
            // 
            this.numLuong.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numLuong.Location = new System.Drawing.Point(171, 257);
            this.numLuong.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numLuong.Name = "numLuong";
            this.numLuong.ReadOnly = true;
            this.numLuong.Size = new System.Drawing.Size(145, 26);
            this.numLuong.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số ngày làm";
            // 
            // numSongaylam
            // 
            this.numSongaylam.Location = new System.Drawing.Point(171, 214);
            this.numSongaylam.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSongaylam.Name = "numSongaylam";
            this.numSongaylam.Size = new System.Drawing.Size(145, 26);
            this.numSongaylam.TabIndex = 8;
            this.numSongaylam.ValueChanged += new System.EventHandler(this.numSongaylam_ValueChanged);
            this.numSongaylam.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numSongaylam_KeyUp);
            // 
            // frmChamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 360);
            this.Controls.Add(this.numSongaylam);
            this.Controls.Add(this.numLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblXemchamcong);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTennhanvien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmChamcong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.frmChamcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSongaylam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label lblXemchamcong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSongaylam;
    }
}