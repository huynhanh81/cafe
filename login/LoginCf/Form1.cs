using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace LoginCf
{
    public partial class Login : Form
    {
        string connectionString =System.Configuration.ConfigurationManager.ConnectionStrings["TaiKhoan"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string DN = txtTK.Text;
            string MK = txtMK.Text;
            string sql = string.Format("SELECT * FROM TaiKhoan WHERE tenDN = '" + DN + "' AND matKhau = '" + MK + "'");
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                if (DN == "admin")
                {
                    Test t = new Test();
                    t.Show();
                    this.Hide();
                    MessageBox.Show("xin chào admin");
                }
                else
                {
                    Test t = new Test();
                    t.Show();
                    this.Hide();
                    MessageBox.Show("xin chào nhân viên");
                }
            }
            else
            {
                txtTK.Clear();
                txtMK.Clear();
                MessageBox.Show("Thông tin đăng nhập không chính xác");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btnDN.Enabled = false;
        }

        private bool KiemTra()
        {
            bool kt = false;
            foreach (Control x in this.Controls)
                if (x is TextBox)
                {
                    if (x.Text == "")
                    {
                        kt = true;
                        break;
                    }

                }
            return kt;

        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {
            if(KiemTra())
            {
                btnDN.Enabled = false;
            }
            else
            {
                btnDN.Enabled = true;
            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if(KiemTra())
            {
                btnDN.Enabled = false;
            }
            else
            {
                btnDN.Enabled = true;
            }
        }
    }
}
