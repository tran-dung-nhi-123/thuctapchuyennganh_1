using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCN.Forms
{
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            txtMakhachhang.Enabled = false;
            btnLuu.Enabled = false;
                btnBoqua.Enabled = false;
                load_data();
        }
        DataTable tblkh;
        private void load_data()
        {
            string sql;
            sql = "select makh,tenkh,diachi,dienthoai from tblkhachhang";
            tblkh = Class.Function.Getdatatotable(sql);
            dgridKhachhang.DataSource = tblkh;
            dgridKhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgridKhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgridKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgridKhachhang.Columns[3].HeaderText = "Điện thoại";
            dgridKhachhang.AllowUserToAddRows = false;
            dgridKhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }


        private void dgridKhachhang_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Dang o che do them moi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Khong co du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtMakhachhang.Text = dgridKhachhang.CurrentRow.Cells["makh"].Value.ToString();
            txtTenkhachhang.Text = dgridKhachhang.CurrentRow.Cells["tenkh"].Value.ToString();
            txtDiachi.Text = dgridKhachhang.CurrentRow.Cells["diachi"].Value.ToString();
            mskDienthoai.Text = dgridKhachhang.CurrentRow.Cells["dienthoai"].Value.ToString();
            btnSua.Enabled = false;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnBoqua.Enabled = true;
            txtMakhachhang.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            resetvalue();
        }
        private void resetvalue()
        {
            txtMakhachhang.Text = "";
            txtTenkhachhang.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Ban phai nhap ma khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMakhachhang.Focus();
                return;
            }
            if (txtTenkhachhang.Text == "")
            {
                MessageBox.Show("Ban phai nhap ten khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenkhachhang.Focus();
                return;
            }
            if (txtDiachi.Text == "")
            {
                MessageBox.Show("Ban phai nhap dia chi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "  /  /")
            {
                MessageBox.Show("Ban phai nhap dia chi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskDienthoai.Focus();
                return;
            }
            //ktra trung ma
            string sql;
            sql = "select makh from tblkhachhang where makh = N'" + txtMakhachhang.Text.Trim() + "'";
            if (Class.Function.checkkey(sql))
            {
                MessageBox.Show("Ma khach hang nay da co", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMakhachhang.Focus();
                txtMakhachhang.Text = "";
            }
            sql = "insert into tblkhachhang(makh,tenkh,diachi,dienthoai) values (N'" + txtMakhachhang.Text + "',N'" + txtTenkhachhang.Text + "',N'" + txtDiachi.Text + "','" + mskDienthoai.Text + "')";
            Class.Function.runsql(sql);
            load_data();
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            txtMakhachhang.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Khong con du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi nao", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap ten khach hang", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenkhachhang.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ban phai nhap dia chi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )    -")
            {
                MessageBox.Show("Ban phai nhap dien thoai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskDienthoai.Focus();
                return;
            }
            sql = "Update tblkhachhang set tenkh=N'" + txtTenkhachhang.Text.Trim().ToString() + "',diachi=N'" + txtDiachi.Text.Trim().ToString() + "',dienthoai=N'" + mskDienthoai.Text.ToString() +"' where makh=N'" + txtMakhachhang.Text + "'";
            Class.Function.runsql(sql);
            load_data();
            resetvalue();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblkh.Rows.Count == 0)
            {
                MessageBox.Show("Khong con du lieu", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtMakhachhang.Text == "")
            {
                MessageBox.Show("Ban chua chon ban ghi nao", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Ban co chac chan xoa khong?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) ;
            {
                sql = "delete tblkhachhang when makh =N'" + txtMakhachhang.Text + "'";
                Class.Function.runsql(sql);
                load_data();
                resetvalue();
            }
        }
    }
}
