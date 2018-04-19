using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH
{
    public partial class Form1 : Form
    {
        //string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=
        //E:\hk2nam3\CNDotNet\Phần 1 - WinForm\Slide WinForm + BTH\BTH\BTH\Database1.mdf;Integrated Security=True";
        string connectionString=System.Configuration.ConfigurationManager.ConnectionStrings["DSNV"].ConnectionString;

        int thaoTac = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            txthoten.ReadOnly = true;
            txtDT.ReadOnly = true;
            txtCMND.ReadOnly = true;
            
            LayDanhSachNhanVien();
            LayThongTin();

            btnDongy.Enabled = false;
            btnBoqua.Enabled = false;
        }

        private void LayDanhSachNhanVien()
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "SELECT * FROM DSNV";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            DataSet ds = new DataSet();

            da.Fill(ds, "NhanVien");
            dgvNhanVien.DataSource = ds.Tables["Nhanvien"];
        }

        private void LayThongTin()
        {
            if(dgvNhanVien.SelectedRows.Count >0)
            {
                DataGridViewRow row = dgvNhanVien.SelectedRows[0];

                string ma = row.Cells[0].Value.ToString();
                string hoten = row.Cells[1].Value.ToString();
                string cmnd = row.Cells[3].Value.ToString();
                string sdt = row.Cells[4].Value.ToString();
                string bophan = row.Cells[5].Value.ToString();
                string khuvuc = row.Cells[6].Value.ToString();
                string gt = row.Cells[3].Value.ToString();

                txtMa.Text = ma;
                txthoten.Text = hoten;
                txtDT.Text = sdt;
                txtCMND.Text = cmnd;
                cmbBophan.Text = bophan;
                cmbKhuvuc.Text = khuvuc;
                if (gt == chNam.Text)
                    chNam.Checked = true;
                else
                    chNu.Checked = true;
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgvNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
            string hoten = dgvNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
            string cmnd = dgvNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
            string sdt = dgvNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
            string bophan = dgvNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
            string khuvuc = dgvNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
            string gt = dgvNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString();

            txtMa.Text = ma;
            txthoten.Text = hoten;
            txtDT.Text = sdt;
            txtCMND.Text = cmnd;
            cmbBophan.Text = bophan;
            cmbKhuvuc.Text = khuvuc;
            if (gt ==chNam.Text)
            {
                chNam.Checked = true;
                chNu.Checked = false;
            }
               
            else
            {
                chNu.Checked = true;
                chNam.Checked = false;
            }
                
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = false;
            txthoten.ReadOnly = false;
            txtCMND.ReadOnly = false;
            txtDT.ReadOnly = false;

            txtMa.Text = "";
            txthoten.Text = "";
            txtCMND.Text = "";
            txtDT.Text = "";
            chNam.Checked = true;
            chNu.Checked = false;
            cmbBophan.Text = "";
            cmbKhuvuc.Text = "";

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnDongy.Enabled = true;
            btnBoqua.Enabled = true;

            thaoTac = 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMa.ReadOnly = true;
            chNam.Checked = true;
            chNu.Checked = false;
            txthoten.ReadOnly = false;
            txtCMND.ReadOnly = false;
            txtDT.ReadOnly = false;

            txthoten.Text = "";
            txtCMND.Text = "";
            txtDT.Text = "";
            cmbBophan.Text = "";
            cmbKhuvuc.Text = "";

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnDongy.Enabled = true;
            btnBoqua.Enabled = true;

            thaoTac = 2;
        }

        private void chNam_CheckedChanged(object sender, EventArgs e)
        {
            if(chNam.Checked==true)
            {
                chNu.Checked = false;
            }
            
        }

        private void chNu_CheckedChanged(object sender, EventArgs e)
        {
            if (chNu.Checked == true)
                chNam.Checked = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnThem.Enabled = false;

            string ma = txtMa.Text;
            if (MessageBox.Show("Ban muon xoa", "Thong bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Xoa(ma);
                LayDanhSachNhanVien();
                LayThongTin();

                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
            }
        }

        private void Xoa(string stt)
        {
            string query = "DELETE FROM DSNV WHERE Ma=@ma";

            using(SqlConnection con=new SqlConnection(connectionString))
            {
                using(SqlCommand cmd= new SqlCommand(query,con))
                {
                    cmd.Parameters.Add("@ma", SqlDbType.NVarChar);
                    cmd.Parameters["@ma"].Value = stt;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Xảy ra lỗi\n" + ex.ToString());
                    }
                }
            }

        }

        private void them(string ma,string hoten,string gt,string cmnd,string sdt,string bophan,string khuvuc)
        {
            string query =string.Format( "INSERT INTO DSNV VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
                ma,hoten,gt,cmnd,sdt,bophan,khuvuc);

            using(SqlConnection con=new SqlConnection(connectionString))
            {
                using(SqlCommand cmd=new SqlCommand(query,con))
                {
                    /*cmd.Parameters.Add("@ma", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@ht", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@sdt", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@gt", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@khuvuc", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@bophan", SqlDbType.NVarChar);

                    cmd.Parameters["@ma"].Value = ma;
                    cmd.Parameters["@ht"].Value = hoten;
                    cmd.Parameters["@cmnd"].Value = cmnd;
                    cmd.Parameters["@sdt"].Value = sdt;
                    cmd.Parameters["@gt"].Value = gt;
                    cmd.Parameters["@khuvuc"].Value = khuvuc;
                    cmd.Parameters["@bophan"].Value = bophan;*/

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Xay ra loi\n" + ex.ToString());
                    }
                }
            }
        }


        private void Sua(string ma, string hoten, string gt, string sdt, string cmnd, string khuvuc, string bophan)
        {
            string query = "UPDATE DSNV SET HoTen=@hoten,GioiTinh=@gt,SoCMND=@cmnd,SoDT=@sdt,KhuVuc=@khuvuc,BoPhan=@bophan WHERE Ma=@ma";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@ma", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@hoten", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@cmnd", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@sdt", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@gt", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@khuvuc", SqlDbType.NVarChar);
                    cmd.Parameters.Add("@bophan", SqlDbType.NVarChar);

                    cmd.Parameters["@ma"].Value = ma;
                    cmd.Parameters["@hoten"].Value = hoten;
                    cmd.Parameters["@cmnd"].Value = cmnd;
                    cmd.Parameters["@sdt"].Value = sdt;
                    cmd.Parameters["@gt"].Value = gt;
                    cmd.Parameters["@khuvuc"].Value = khuvuc;
                    cmd.Parameters["@bophan"].Value = bophan;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Xay ra loi\n" + ex.ToString());
                    }
                }
            }
        }

        private void btnDongy_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnDongy.Enabled = false;
            btnBoqua.Enabled = false;

            string ma = txtMa.Text;
            string hoten = txthoten.Text;
            string cmnd = txtCMND.Text;
            string sdt = txtDT.Text;
            string gt = "";

            if(chNam.Checked==true)
            {
                gt = chNam.Text;
            }

            else
            {
                gt = chNu.Text;
            }

            string khuvuc = cmbKhuvuc.SelectedItem.ToString();
            string bophan = cmbBophan.SelectedItem.ToString();


            if(thaoTac==1)
            {
                them(ma, hoten, gt,cmnd,sdt,bophan,khuvuc);

                LayDanhSachNhanVien();
                LayThongTin();
            }

            if(thaoTac==2)
            {
                Sua(ma, hoten, gt, sdt, cmnd, khuvuc, bophan);

                LayDanhSachNhanVien();
                LayThongTin();
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            btnDongy.Enabled = false;
            btnBoqua.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;

            LayDanhSachNhanVien();
            LayThongTin();
        }



    }
}
