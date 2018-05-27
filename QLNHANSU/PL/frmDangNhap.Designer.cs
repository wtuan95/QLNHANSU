namespace QLNHANSU.PL
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.grpNhom = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picDangnhap = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.txtdangnhap = new System.Windows.Forms.TextBox();
            this.lblNhapmatkhau = new System.Windows.Forms.Label();
            this.lblNhaptendangnhap = new System.Windows.Forms.Label();
            this.lblDangnhaphethong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpNhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangnhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpNhom
            // 
            this.grpNhom.Controls.Add(this.label1);
            this.grpNhom.Controls.Add(this.picDangnhap);
            this.grpNhom.Controls.Add(this.textBox3);
            this.grpNhom.Controls.Add(this.label6);
            this.grpNhom.Controls.Add(this.label5);
            this.grpNhom.Controls.Add(this.label4);
            this.grpNhom.Controls.Add(this.txtmatkhau);
            this.grpNhom.Controls.Add(this.txtdangnhap);
            this.grpNhom.Controls.Add(this.lblNhapmatkhau);
            this.grpNhom.Controls.Add(this.lblNhaptendangnhap);
            this.grpNhom.Controls.Add(this.lblDangnhaphethong);
            this.grpNhom.Controls.Add(this.pictureBox1);
            this.grpNhom.Location = new System.Drawing.Point(7, 8);
            this.grpNhom.Name = "grpNhom";
            this.grpNhom.Size = new System.Drawing.Size(745, 305);
            this.grpNhom.TabIndex = 1;
            this.grpNhom.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(236, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chưa có database? Ấn vào đây để tạo";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picDangnhap
            // 
            this.picDangnhap.BackColor = System.Drawing.Color.White;
            this.picDangnhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDangnhap.BackgroundImage")));
            this.picDangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDangnhap.Location = new System.Drawing.Point(576, 222);
            this.picDangnhap.Name = "picDangnhap";
            this.picDangnhap.Size = new System.Drawing.Size(151, 52);
            this.picDangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDangnhap.TabIndex = 10;
            this.picDangnhap.TabStop = false;
            this.picDangnhap.Click += new System.EventHandler(this.picDangnhap_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Maroon;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(236, 179);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(485, 10);
            this.textBox3.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(236, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(680, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(680, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "(*)";
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.ForeColor = System.Drawing.Color.Blue;
            this.txtmatkhau.Location = new System.Drawing.Point(407, 135);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.PasswordChar = '•';
            this.txtmatkhau.Size = new System.Drawing.Size(267, 20);
            this.txtmatkhau.TabIndex = 5;
            this.txtmatkhau.Text = "admin";
            this.txtmatkhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmatkhau_KeyPress);
            // 
            // txtdangnhap
            // 
            this.txtdangnhap.ForeColor = System.Drawing.Color.Blue;
            this.txtdangnhap.Location = new System.Drawing.Point(407, 83);
            this.txtdangnhap.Name = "txtdangnhap";
            this.txtdangnhap.Size = new System.Drawing.Size(267, 20);
            this.txtdangnhap.TabIndex = 4;
            this.txtdangnhap.Text = "admin";
            this.txtdangnhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdangnhap_KeyPress);
            // 
            // lblNhapmatkhau
            // 
            this.lblNhapmatkhau.AutoSize = true;
            this.lblNhapmatkhau.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapmatkhau.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNhapmatkhau.Location = new System.Drawing.Point(232, 140);
            this.lblNhapmatkhau.Name = "lblNhapmatkhau";
            this.lblNhapmatkhau.Size = new System.Drawing.Size(122, 21);
            this.lblNhapmatkhau.TabIndex = 3;
            this.lblNhapmatkhau.Text = "Nhập mật khẩu";
            // 
            // lblNhaptendangnhap
            // 
            this.lblNhaptendangnhap.AutoSize = true;
            this.lblNhaptendangnhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaptendangnhap.ForeColor = System.Drawing.Color.Firebrick;
            this.lblNhaptendangnhap.Location = new System.Drawing.Point(232, 88);
            this.lblNhaptendangnhap.Name = "lblNhaptendangnhap";
            this.lblNhaptendangnhap.Size = new System.Drawing.Size(159, 21);
            this.lblNhaptendangnhap.TabIndex = 2;
            this.lblNhaptendangnhap.Text = "Nhập tên đăng nhập";
            // 
            // lblDangnhaphethong
            // 
            this.lblDangnhaphethong.AutoSize = true;
            this.lblDangnhaphethong.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangnhaphethong.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDangnhaphethong.Location = new System.Drawing.Point(325, 22);
            this.lblDangnhaphethong.Name = "lblDangnhaphethong";
            this.lblDangnhaphethong.Size = new System.Drawing.Size(293, 36);
            this.lblDangnhaphethong.TabIndex = 1;
            this.lblDangnhaphethong.Text = "Đăng nhập hệ thống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 320);
            this.Controls.Add(this.grpNhom);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.grpNhom.ResumeLayout(false);
            this.grpNhom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangnhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhom;
        private System.Windows.Forms.PictureBox picDangnhap;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtdangnhap;
        private System.Windows.Forms.Label lblNhapmatkhau;
        private System.Windows.Forms.Label lblNhaptendangnhap;
        private System.Windows.Forms.Label lblDangnhaphethong;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}