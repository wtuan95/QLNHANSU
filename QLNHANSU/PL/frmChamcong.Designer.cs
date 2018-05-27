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
            this.label6 = new System.Windows.Forms.Label();
            this.numSongaylam = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLuongcoban = new System.Windows.Forms.TextBox();
            this.numPhucapthang = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.numDatratruoc = new System.Windows.Forms.NumericUpDown();
            this.txtLuongNhan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numHesoluong = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTienkhenthuong = new System.Windows.Forms.TextBox();
            this.txtTienkyluat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSongaylam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhucapthang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatratruoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHesoluong)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(635, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHẤM CÔNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên nhân viên";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTennhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTennhanvien.Location = new System.Drawing.Point(157, 47);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(145, 26);
            this.txtTennhanvien.TabIndex = 1;
            this.txtTennhanvien.TextChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 152);
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
            this.cbThang.Location = new System.Drawing.Point(157, 145);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(145, 27);
            this.cbThang.TabIndex = 5;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 151);
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
            this.cbNam.Location = new System.Drawing.Point(445, 144);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(145, 27);
            this.cbNam.TabIndex = 6;
            this.cbNam.SelectedIndexChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLuu.Location = new System.Drawing.Point(157, 402);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(145, 38);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lblXemchamcong
            // 
            this.lblXemchamcong.AutoSize = true;
            this.lblXemchamcong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblXemchamcong.ForeColor = System.Drawing.Color.Blue;
            this.lblXemchamcong.Location = new System.Drawing.Point(355, 54);
            this.lblXemchamcong.Name = "lblXemchamcong";
            this.lblXemchamcong.Size = new System.Drawing.Size(256, 19);
            this.lblXemchamcong.TabIndex = 2;
            this.lblXemchamcong.Text = "Xem danh sách chấm công của nhân viên";
            this.lblXemchamcong.Click += new System.EventHandler(this.lblXemchamcong_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(61, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lương nhận";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số ngày làm";
            // 
            // numSongaylam
            // 
            this.numSongaylam.Location = new System.Drawing.Point(157, 195);
            this.numSongaylam.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numSongaylam.Name = "numSongaylam";
            this.numSongaylam.Size = new System.Drawing.Size(145, 26);
            this.numSongaylam.TabIndex = 7;
            this.numSongaylam.ValueChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lương cơ bản";
            // 
            // txtLuongcoban
            // 
            this.txtLuongcoban.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLuongcoban.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLuongcoban.Location = new System.Drawing.Point(445, 95);
            this.txtLuongcoban.Name = "txtLuongcoban";
            this.txtLuongcoban.ReadOnly = true;
            this.txtLuongcoban.Size = new System.Drawing.Size(145, 26);
            this.txtLuongcoban.TabIndex = 3;
            // 
            // numPhucapthang
            // 
            this.numPhucapthang.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numPhucapthang.Location = new System.Drawing.Point(445, 194);
            this.numPhucapthang.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numPhucapthang.Name = "numPhucapthang";
            this.numPhucapthang.Size = new System.Drawing.Size(145, 26);
            this.numPhucapthang.TabIndex = 8;
            this.numPhucapthang.ValueChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 200);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "Phụ cấp tháng";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.Control;
            this.btnDong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDong.Location = new System.Drawing.Point(333, 402);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(145, 38);
            this.btnDong.TabIndex = 15;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Đã trả trước";
            // 
            // numDatratruoc
            // 
            this.numDatratruoc.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDatratruoc.Location = new System.Drawing.Point(157, 244);
            this.numDatratruoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDatratruoc.Name = "numDatratruoc";
            this.numDatratruoc.Size = new System.Drawing.Size(145, 26);
            this.numDatratruoc.TabIndex = 9;
            this.numDatratruoc.ValueChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // txtLuongNhan
            // 
            this.txtLuongNhan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLuongNhan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtLuongNhan.Location = new System.Drawing.Point(157, 349);
            this.txtLuongNhan.Name = "txtLuongNhan";
            this.txtLuongNhan.ReadOnly = true;
            this.txtLuongNhan.Size = new System.Drawing.Size(321, 26);
            this.txtLuongNhan.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(356, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hệ số lương";
            // 
            // numHesoluong
            // 
            this.numHesoluong.DecimalPlaces = 1;
            this.numHesoluong.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numHesoluong.Location = new System.Drawing.Point(445, 243);
            this.numHesoluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHesoluong.Name = "numHesoluong";
            this.numHesoluong.Size = new System.Drawing.Size(145, 26);
            this.numHesoluong.TabIndex = 10;
            this.numHesoluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHesoluong.ValueChanged += new System.EventHandler(this.valueNumChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(484, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "VNĐ";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtManhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtManhanvien.Location = new System.Drawing.Point(157, 96);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.ReadOnly = true;
            this.txtManhanvien.Size = new System.Drawing.Size(145, 26);
            this.txtManhanvien.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mã nhân viên";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Tiền khen thưởng";
            // 
            // txtTienkhenthuong
            // 
            this.txtTienkhenthuong.Location = new System.Drawing.Point(157, 293);
            this.txtTienkhenthuong.Name = "txtTienkhenthuong";
            this.txtTienkhenthuong.ReadOnly = true;
            this.txtTienkhenthuong.Size = new System.Drawing.Size(145, 26);
            this.txtTienkhenthuong.TabIndex = 11;
            // 
            // txtTienkyluat
            // 
            this.txtTienkyluat.Location = new System.Drawing.Point(445, 292);
            this.txtTienkyluat.Name = "txtTienkyluat";
            this.txtTienkyluat.ReadOnly = true;
            this.txtTienkyluat.Size = new System.Drawing.Size(145, 26);
            this.txtTienkyluat.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 27;
            this.label14.Text = "Tiền kỷ luật";
            // 
            // frmChamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(635, 451);
            this.Controls.Add(this.txtTienkyluat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTienkhenthuong);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numHesoluong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLuongNhan);
            this.Controls.Add(this.numDatratruoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.numPhucapthang);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLuongcoban);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numSongaylam);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmChamcong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công";
            this.Load += new System.EventHandler(this.frmChamcong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSongaylam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPhucapthang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDatratruoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHesoluong)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSongaylam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLuongcoban;
        private System.Windows.Forms.NumericUpDown numPhucapthang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numDatratruoc;
        private System.Windows.Forms.TextBox txtLuongNhan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numHesoluong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTienkhenthuong;
        private System.Windows.Forms.TextBox txtTienkyluat;
        private System.Windows.Forms.Label label14;
    }
}