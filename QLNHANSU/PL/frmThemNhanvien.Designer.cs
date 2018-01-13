namespace QLNHANSU.PL
{
    partial class frmThemNhanvien
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbLuong = new System.Windows.Forms.ComboBox();
            this.cbPhongban = new System.Windows.Forms.ComboBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtDantoc = new System.Windows.Forms.TextBox();
            this.numNamsinh = new System.Windows.Forms.NumericUpDown();
            this.rdoGioitinh = new System.Windows.Forms.CheckBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnLuong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNamsinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "THÊM NHÂN VIÊN";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDong.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDong.Location = new System.Drawing.Point(189, 388);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(90, 33);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.ForeColor = System.Drawing.SystemColors.Control;
            this.btnThem.Location = new System.Drawing.Point(93, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 33);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbLuong
            // 
            this.cbLuong.FormattingEnabled = true;
            this.cbLuong.Location = new System.Drawing.Point(93, 342);
            this.cbLuong.Name = "cbLuong";
            this.cbLuong.Size = new System.Drawing.Size(120, 21);
            this.cbLuong.TabIndex = 9;
            // 
            // cbPhongban
            // 
            this.cbPhongban.FormattingEnabled = true;
            this.cbPhongban.Location = new System.Drawing.Point(93, 305);
            this.cbPhongban.Name = "cbPhongban";
            this.cbPhongban.Size = new System.Drawing.Size(232, 21);
            this.cbPhongban.TabIndex = 8;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(93, 269);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(232, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(93, 233);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(232, 20);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtDantoc
            // 
            this.txtDantoc.Location = new System.Drawing.Point(93, 197);
            this.txtDantoc.Name = "txtDantoc";
            this.txtDantoc.Size = new System.Drawing.Size(232, 20);
            this.txtDantoc.TabIndex = 5;
            // 
            // numNamsinh
            // 
            this.numNamsinh.Location = new System.Drawing.Point(93, 161);
            this.numNamsinh.Maximum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numNamsinh.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numNamsinh.Name = "numNamsinh";
            this.numNamsinh.Size = new System.Drawing.Size(120, 20);
            this.numNamsinh.TabIndex = 4;
            this.numNamsinh.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // rdoGioitinh
            // 
            this.rdoGioitinh.AutoSize = true;
            this.rdoGioitinh.Location = new System.Drawing.Point(93, 131);
            this.rdoGioitinh.Name = "rdoGioitinh";
            this.rdoGioitinh.Size = new System.Drawing.Size(48, 17);
            this.rdoGioitinh.TabIndex = 3;
            this.rdoGioitinh.Text = "Nam";
            this.rdoGioitinh.UseVisualStyleBackColor = true;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(93, 92);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(232, 20);
            this.txtHoten.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 351);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Lương:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Phòng ban:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "SĐT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Địa chỉ NV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Dân tộc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Năm sinh:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Họ tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(93, 56);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(232, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // btnLuong
            // 
            this.btnLuong.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLuong.Location = new System.Drawing.Point(219, 336);
            this.btnLuong.Name = "btnLuong";
            this.btnLuong.Size = new System.Drawing.Size(120, 29);
            this.btnLuong.TabIndex = 10;
            this.btnLuong.Text = "Xem thông tin lương";
            this.btnLuong.UseVisualStyleBackColor = false;
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);
            // 
            // frmThemNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 431);
            this.Controls.Add(this.btnLuong);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbLuong);
            this.Controls.Add(this.cbPhongban);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtDantoc);
            this.Controls.Add(this.numNamsinh);
            this.Controls.Add(this.rdoGioitinh);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmThemNhanvien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.frmThemNhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNamsinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbLuong;
        private System.Windows.Forms.ComboBox cbPhongban;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtDantoc;
        private System.Windows.Forms.NumericUpDown numNamsinh;
        private System.Windows.Forms.CheckBox rdoGioitinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnLuong;
    }
}