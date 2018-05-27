namespace QLNHANSU.PL
{
    partial class frmXemchamcong
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
            this.dgChamcong = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCapThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaTraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoanCham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamcong)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(776, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "XEM CHẤM CÔNG CỦA NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgChamcong
            // 
            this.dgChamcong.AllowUserToAddRows = false;
            this.dgChamcong.AllowUserToDeleteRows = false;
            this.dgChamcong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamcong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Thang,
            this.Nam,
            this.SoNgayLam,
            this.PhuCapThang,
            this.DaTraTruoc,
            this.HeSoLuong,
            this.LuongNhan,
            this.NgayCham,
            this.TaiKhoanCham});
            this.dgChamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgChamcong.Location = new System.Drawing.Point(0, 35);
            this.dgChamcong.Name = "dgChamcong";
            this.dgChamcong.ReadOnly = true;
            this.dgChamcong.Size = new System.Drawing.Size(776, 377);
            this.dgChamcong.TabIndex = 2;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // Thang
            // 
            this.Thang.DataPropertyName = "Thang";
            this.Thang.HeaderText = "Tháng";
            this.Thang.Name = "Thang";
            this.Thang.ReadOnly = true;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.Name = "Nam";
            this.Nam.ReadOnly = true;
            // 
            // SoNgayLam
            // 
            this.SoNgayLam.DataPropertyName = "SoNgayLam";
            this.SoNgayLam.HeaderText = "Số ngày làm";
            this.SoNgayLam.Name = "SoNgayLam";
            this.SoNgayLam.ReadOnly = true;
            // 
            // PhuCapThang
            // 
            this.PhuCapThang.DataPropertyName = "PhuCapThang";
            this.PhuCapThang.HeaderText = "Phụ cấp tháng";
            this.PhuCapThang.Name = "PhuCapThang";
            this.PhuCapThang.ReadOnly = true;
            // 
            // DaTraTruoc
            // 
            this.DaTraTruoc.DataPropertyName = "DaTraTruoc";
            this.DaTraTruoc.HeaderText = "Đã trả trước";
            this.DaTraTruoc.Name = "DaTraTruoc";
            this.DaTraTruoc.ReadOnly = true;
            // 
            // HeSoLuong
            // 
            this.HeSoLuong.DataPropertyName = "HeSoLuong";
            this.HeSoLuong.HeaderText = "Hệ số lương";
            this.HeSoLuong.Name = "HeSoLuong";
            this.HeSoLuong.ReadOnly = true;
            // 
            // LuongNhan
            // 
            this.LuongNhan.DataPropertyName = "LuongNhan";
            this.LuongNhan.HeaderText = "Lương nhận";
            this.LuongNhan.Name = "LuongNhan";
            this.LuongNhan.ReadOnly = true;
            // 
            // NgayCham
            // 
            this.NgayCham.DataPropertyName = "NgayCham";
            this.NgayCham.HeaderText = "Ngày chấm";
            this.NgayCham.Name = "NgayCham";
            this.NgayCham.ReadOnly = true;
            // 
            // TaiKhoanCham
            // 
            this.TaiKhoanCham.DataPropertyName = "TaiKhoanCham";
            this.TaiKhoanCham.HeaderText = "Tài khoản chấm";
            this.TaiKhoanCham.Name = "TaiKhoanCham";
            this.TaiKhoanCham.ReadOnly = true;
            // 
            // frmXemchamcong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 412);
            this.Controls.Add(this.dgChamcong);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemchamcong";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chấm công của nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgChamcong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgChamcong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCapThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaTraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCham;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoanCham;
    }
}