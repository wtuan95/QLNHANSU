using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
namespace QLNHANSU.PL
{
    public partial class frmKetNoi : Form
    {
        SqlConnection con = null;
        string chuoiketnoi = null;
        public frmKetNoi()
        {
            InitializeComponent();
        }

        private void cboAuthentication_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUserName.Enabled = lblPasswrod.Enabled = txtPassword.Enabled = txtUserName.Enabled = (cboAuthentication.SelectedIndex == 1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKetNoi_Load(object sender, EventArgs e)
        {
            cboAuthentication.SelectedIndex = 0;
        }

        private void txtFilename_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFilename.Text = dialog.FileName;
            }
        }

        private void btnTestconnect_Click(object sender, EventArgs e)
        {
            try
            {
                // string chuoiketnoi = "Data Source=DELL-PC;Initial Catalog=QLBanSach;Integrated Security=True"
                if (cboAuthentication.SelectedIndex == 0)
                {
                    chuoiketnoi = @"Data Source = " + txtServerName.Text + ";Integrated Security = True;";
                    con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    MessageBox.Show("Kết nối CSDL thành công");
                    label2.Visible = txtFilename.Visible = btnRunscript.Visible =  true;
                }
                else
                {
                    chuoiketnoi = @"Data Source = " + txtServerName.Text + ";Integrated Security = True; user ID = " + txtUserName.Text + "; Password=" + txtPassword.Text + ";";
                    con = new SqlConnection(chuoiketnoi);
                    con.Open();
                    MessageBox.Show("Kết nối CSDL thành công");
                    label2.Visible = txtFilename.Visible = btnRunscript.Visible =  true;
                }
            }
            catch 
            {
                if(con.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Kết nối thất bại. Bạn hãy kiểm tra xem tên server name đã đúng chưa hoặc service MS SQL Server đã được start chưa.");
                    label2.Visible = txtFilename.Visible = false;
                    return;
                }
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRunscript_Click(object sender, EventArgs e)
        {
            if(txtFilename.Text == string.Empty)
            {
                return;
            }
            try
            {
                string script = File.ReadAllText(txtFilename.Text);

                SqlConnection conn = new SqlConnection(chuoiketnoi);

                
                

                Server server = new Server(new ServerConnection(conn));

                server.ConnectionContext.ExecuteNonQuery(script);

                MessageBox.Show("Tạo CSDL thành công vào server name " + txtServerName.Text);
                chuoiketnoi += "Database=QLNHANSU;";
                using (StreamWriter w = new StreamWriter(Environment.CurrentDirectory + "/../../Files/chuoiketnoi.txt"))
                {
                    w.Write(chuoiketnoi);
                }
                this.Close();
                
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
    }
}
