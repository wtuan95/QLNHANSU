namespace QLNHANSU.PL
{
    partial class frmBoSungKhenThuong_KyLuat
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
            this.lblTieude = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTennhanvien = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtxtNoidung = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBosung = new System.Windows.Forms.Button();
            this.btnTrove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.numSotien = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSotien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieude
            // 
            this.lblTieude.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblTieude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieude.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTieude.Location = new System.Drawing.Point(0, 0);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(752, 35);
            this.lblTieude.TabIndex = 2;
            this.lblTieude.Text = "TITLE";
            this.lblTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numSotien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rtxtNoidung);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbNam);
            this.groupBox1.Controls.Add(this.cbThang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtManhanvien);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTennhanvien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 429);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // txtTennhanvien
            // 
            this.txtTennhanvien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTennhanvien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTennhanvien.Location = new System.Drawing.Point(119, 24);
            this.txtTennhanvien.Name = "txtTennhanvien";
            this.txtTennhanvien.Size = new System.Drawing.Size(250, 27);
            this.txtTennhanvien.TabIndex = 1;
            this.txtTennhanvien.TextChanged += new System.EventHandler(this.txtTennhanvien_TextChanged);
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(490, 24);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.ReadOnly = true;
            this.txtManhanvien.Size = new System.Drawing.Size(250, 27);
            this.txtManhanvien.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tháng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Năm";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Location = new System.Drawing.Point(119, 79);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(250, 27);
            this.cbThang.TabIndex = 3;
            // 
            // cbNam
            // 
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(490, 79);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(250, 27);
            this.cbNam.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nội dung";
            // 
            // rtxtNoidung
            // 
            this.rtxtNoidung.Location = new System.Drawing.Point(119, 134);
            this.rtxtNoidung.Name = "rtxtNoidung";
            this.rtxtNoidung.Size = new System.Drawing.Size(621, 152);
            this.rtxtNoidung.TabIndex = 5;
            this.rtxtNoidung.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnTrove);
            this.panel1.Controls.Add(this.btnBosung);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 46);
            this.panel1.TabIndex = 4;
            // 
            // btnBosung
            // 
            this.btnBosung.BackColor = System.Drawing.Color.Navy;
            this.btnBosung.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBosung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBosung.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBosung.Location = new System.Drawing.Point(490, 4);
            this.btnBosung.Name = "btnBosung";
            this.btnBosung.Size = new System.Drawing.Size(118, 36);
            this.btnBosung.TabIndex = 7;
            this.btnBosung.Text = "BỔ SUNG";
            this.btnBosung.UseVisualStyleBackColor = false;
            this.btnBosung.Click += new System.EventHandler(this.btnBosung_Click);
            // 
            // btnTrove
            // 
            this.btnTrove.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnTrove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrove.Location = new System.Drawing.Point(622, 4);
            this.btnTrove.Name = "btnTrove";
            this.btnTrove.Size = new System.Drawing.Size(118, 36);
            this.btnTrove.TabIndex = 8;
            this.btnTrove.Text = "TRỞ VỀ";
            this.btnTrove.UseVisualStyleBackColor = true;
            this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số tiền";
            // 
            // numSotien
            // 
            this.numSotien.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numSotien.Location = new System.Drawing.Point(119, 314);
            this.numSotien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numSotien.Name = "numSotien";
            this.numSotien.Size = new System.Drawing.Size(250, 27);
            this.numSotien.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "VNĐ";
            // 
            // frmBoSungKhenThuong_KyLuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 464);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTieude);
            this.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBoSungKhenThuong_KyLuat";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBoSung";
            this.Load += new System.EventHandler(this.frmBoSungKhenThuong_KyLuat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSotien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTennhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtNoidung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTrove;
        private System.Windows.Forms.Button btnBosung;
        private System.Windows.Forms.NumericUpDown numSotien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}