using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class frm_QLNhanVien : Form
    {
        IQLNhanVienService _IQLNhanVienService;
        IChucVuService _IChucVuService;
        ICuaHangService _ICuaHangService;
        Guid _CurrentId;
        public frm_QLNhanVien()
        {
            InitializeComponent();
            _IQLNhanVienService = new QLNhanVienService();
            _IChucVuService = new ChucVuService();
            _ICuaHangService = new CuaHangService();
            LoadToCmb_ChucVu();
            LoadToCmb_CuaHang();
            LoadToCmb_GuiBC();
            LoadToGrid();
        }
        private void LoadToCmb_ChucVu()
        {
            cmb_chucvu.Items.Clear();
            foreach (var item in _IChucVuService.GetAll())
            {
                cmb_chucvu.Items.Add(item.Ten);
            }
        }
        private void LoadToCmb_CuaHang()
        {
            cmb_cuahang.Items.Clear();
            foreach (var item in _ICuaHangService.GetAll())
            {
                cmb_cuahang.Items.Add(item.Ten);
            }
        }
        private void LoadToCmb_GuiBC()
        {
            cmb_nguoiguibc.Items.Clear();
            foreach (var item in _IQLNhanVienService.GetAll())
            {
                cmb_nguoiguibc.Items.Add(item.Ma);
            }
        }
        public void LoadToGrid()
        {
            int stt = 1;
            dgridviews.Rows.Clear();
            dgridviews.ColumnCount = 15;
            dgridviews.Columns[0].Name = "ID";
            dgridviews.Columns[0].Visible = false;
            dgridviews.Columns[1].Name = "STT";
            dgridviews.Columns[2].Name = "Họ";
            dgridviews.Columns[3].Name = "Tên đệm";
            dgridviews.Columns[4].Name = "Tên";
            dgridviews.Columns[5].Name = "Mã Nv";
            dgridviews.Columns[6].Name = "Ngày sinh";
            dgridviews.Columns[7].Name = "Giới tính";
            dgridviews.Columns[8].Name = "Địa chỉ";
            dgridviews.Columns[9].Name = "Mật khẩu";
            dgridviews.Columns[10].Name = "SDT";
            dgridviews.Columns[11].Name = "Chức vụ";
            dgridviews.Columns[12].Name = "Tên cửa hàng";
            dgridviews.Columns[13].Name = "Trạng thái";
            dgridviews.Columns[14].Name = "Người gửi BC";
            foreach (var item in _IQLNhanVienService.GetAll())
            {
                dgridviews.Rows.Add(
                    item.Id,
                    stt++,
                    item.Ho,
                    item.TenDem,
                    item.Ten,
                    item.Ma,
                    item.NgaySinh,
                    item.GioiTinh,
                    item.DiaChi,
                    item.MatKhau,
                    item.Sdt,
                    _IChucVuService.GetAll().FirstOrDefault(c => c.Id == item.IdCv).Ten,
                    _ICuaHangService.GetAll().FirstOrDefault(c => c.Id == item.IdCh).Ten,
                    (item.TrangThai == 0) ? "Không hoạt động" : "Hoạt động",
                    item.IdGuiBc!= null ? _IQLNhanVienService.GetAll().FirstOrDefault(c => c.Id == item.IdGuiBc).Ma : " ");
            }

        }

        private void dgridviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentId = (Guid)dgridviews.CurrentRow.Cells[0].Value;
            tbx_ho.Text = dgridviews.CurrentRow.Cells[2].Value.ToString();
            tbx_tendem.Text = dgridviews.CurrentRow.Cells[3].Value.ToString();
            tbx_ten.Text = dgridviews.CurrentRow.Cells[4].Value.ToString();
            tbx_manv.Text = dgridviews.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaysinh.Text = dgridviews.CurrentRow.Cells[6].Value.ToString();
            var a = dgridviews.CurrentRow.Cells[7].Value.ToString() == "Nam" ? cbx_gt_nam.Checked = true : cbx_gt_nu.Checked = true;
            tbx_diachi.Text = dgridviews.CurrentRow.Cells[8].Value.ToString();
            tbx_matkhau.Text = dgridviews.CurrentRow.Cells[9].Value.ToString();
            tbx_sdt.Text = dgridviews.CurrentRow.Cells[10].Value.ToString();
            cmb_chucvu.Text = dgridviews.CurrentRow.Cells[11].Value.ToString();
            cmb_cuahang.Text = dgridviews.CurrentRow.Cells[12].Value.ToString();
            var b = dgridviews.CurrentRow.Cells[13].Value == "Không hoạt động" ? cbx_khonghoatdong.Checked = true : cbx_hoatdong.Checked = true;
            cmb_nguoiguibc.Text = dgridviews.CurrentRow.Cells[14].Value.ToString();
        }
        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadToGrid();
            tbx_ho.Text = "";
            tbx_tendem.Text = "";
            tbx_ten.Text = "";
            tbx_manv.Text = "";
            dtp_ngaysinh.Text = DateTime.Now.ToString();
            cbx_gt_nam.Checked = false;
            cbx_gt_nu.Checked = false;
            tbx_diachi.Text = "";
            tbx_matkhau.Text = "";
            tbx_sdt.Text = "";
            cmb_chucvu.Text = "";
            cmb_cuahang.Text = "";
            cbx_khonghoatdong.Checked = false;
            cbx_hoatdong.Checked = false;
            cmb_nguoiguibc.Text = "";
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVienViews nvv = new NhanVienViews()
            {
                Ma = tbx_manv.Text,
                Ten = tbx_ten.Text,
                TenDem = tbx_tendem.Text,
                Ho = tbx_ho.Text,
                GioiTinh = cbx_gt_nam.Checked == true ? "Nam" : "Nữ",
                NgaySinh = DateTime.Parse(dtp_ngaysinh.Text),
                DiaChi = tbx_diachi.Text,
                Sdt = tbx_sdt.Text,
                MatKhau = tbx_matkhau.Text,
                IdCh = _ICuaHangService.GetAll().FirstOrDefault(c => c.Ten == cmb_cuahang.Text).Id,
                IdCv = _IChucVuService.GetAll().FirstOrDefault(c => c.Ten == cmb_chucvu.Text).Id,
                //IdGuiBc = _IQLNhanVienService.GetNhanVienByMa(cmb_nguoiguibc.Text).Id,
                IdGuiBc = cmb_nguoiguibc.Text != "" ? _IQLNhanVienService.GetAll().FirstOrDefault(x => x.Ma == cmb_nguoiguibc.Text).Id : null,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLNhanVienService.Add(nvv));
                LoadToCmb_GuiBC();
                btn_lammoi_Click(null, null);
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

            NhanVienViews nvv = new NhanVienViews()
            {
                Id = _CurrentId,
                Ma = tbx_manv.Text,
                Ten = tbx_ten.Text,
                TenDem = tbx_tendem.Text,
                Ho = tbx_ho.Text,
                GioiTinh = cbx_gt_nam.Checked == true ? "Nam" : "Nữ",
                NgaySinh = DateTime.Parse(dtp_ngaysinh.Text),
                DiaChi = tbx_diachi.Text,
                Sdt = tbx_sdt.Text,
                MatKhau = tbx_matkhau.Text,
                IdCh = _ICuaHangService.GetAll().FirstOrDefault(c => c.Ten == cmb_cuahang.Text).Id,
                IdCv = _IChucVuService.GetAll().FirstOrDefault(c => c.Ten == cmb_chucvu.Text).Id,
                IdGuiBc = cmb_nguoiguibc.Text != "" ? _IQLNhanVienService.GetAll().FirstOrDefault(x => x.Ma == cmb_nguoiguibc.Text).Id : null,
                //IdGuiBc = _IQLNhanVienService.GetNhanVienByMa(cmb_nguoiguibc.Text).Id,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLNhanVienService.Update(nvv));
                LoadToCmb_GuiBC();
                btn_lammoi_Click(null, null);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLNhanVienService.Delete(_CurrentId));
                LoadToCmb_GuiBC();
                btn_lammoi_Click(null,null);
            }
        }
        private void cbx_gt_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_gt_nam.Checked)
            {
                cbx_gt_nu.Checked = false;
            }
        }

        private void cbx_gt_nu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_gt_nu.Checked)
            {
                cbx_gt_nam.Checked = false;
            }
        }

        private void cbx_hoatdong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_hoatdong.Checked)
            {
                cbx_khonghoatdong.Checked = false;
            }
        }

        private void cbx_khonghoatdong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_khonghoatdong.Checked)
            {
                cbx_hoatdong.Checked = false;
            }
        }


    }
}
