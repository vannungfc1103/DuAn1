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
    public partial class frm_QLHoaDon : Form
    {
        IQLNhanVienService _IQLNhanVienService;
        IKhachHangService _IQLKhachHangService;
        IQLHoaDonService _IQLHoaDonService;
        Guid _CurrentId;
        public frm_QLHoaDon()
        {

            InitializeComponent();
            _IQLNhanVienService = new QLNhanVienService();
            _IQLKhachHangService = new KhachHangService();
            //_IQLHoaDonService = new QLHoaDonService();
            LoadToCmb_NhanVien();
            LoadToCmb_KhachHang();
            LoadToGrid();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void LoadToCmb_NhanVien()
        {
            cmb_tennv.Items.Clear();
            foreach (var item in _IQLNhanVienService.GetAll())
            {
                cmb_tennv.Items.Add(item.Ten);
            }
        }
        private void LoadToCmb_KhachHang()
        {
            cmb_tenkh.Items.Clear();
            foreach (var item in _IQLKhachHangService.GetAll())
            {
                cmb_tenkh.Items.Add(item.Ten);
            }
        }
        private void LoadToGrid()
        {
            //int stt = 1;
            //dgridviews.ColumnCount = 13;
            //dgridviews.Columns[0].Name = "ID";
            //dgridviews.Columns[0].Visible = false;
            //dgridviews.Columns[1].Name = "STT";
            //dgridviews.Columns[2].Name = "Tên KH";
            //dgridviews.Columns[3].Name = "Tên Nv";
            //dgridviews.Columns[4].Name = "Mã HD";
            //dgridviews.Columns[5].Name = "Ngày tạo";
            //dgridviews.Columns[6].Name = "Ngày thanh toán";
            //dgridviews.Columns[7].Name = "Ngày ship";
            //dgridviews.Columns[8].Name = "Ngày nhận";
            //dgridviews.Columns[9].Name = "Tình trạng";
            //dgridviews.Columns[10].Name = "Người nhận";
            //dgridviews.Columns[11].Name = "Địa chỉ";
            //dgridviews.Columns[12].Name = "SDT";
            //dgridviews.Rows.Clear();
            //foreach (var item in _IQLHoaDonService.GetAll())
            //{
            //    dgridviews.Rows.Add(
            //                        item.HoaDon.Id,
            //                        stt++,
            //                        _IQLKhachHangService.GetNameById((Guid)item.HoaDon.IdKh),
            //                        _IQLNhanVienService.GetNhanVienByID((Guid)item.HoaDon.IdNv).Ten,
            //                        item.HoaDon.Ma,
            //                        item.HoaDon.NgayTao,
            //                        item.HoaDon.NgayThanhToan,
            //                        item.HoaDon.NgayShip,
            //                        item.HoaDon.NgayNhan,
            //                        item.HoaDon.TinhTrang == 0 ? "Chưa nhận" : "Đã Nhận",
            //                        item.HoaDon.TenNguoiNhan,
            //                        item.HoaDon.DiaChi,
            //                        item.HoaDon.Sdt
            //        );
            //}
        }

        private void dgridviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentId = (Guid)dgridviews.CurrentRow.Cells[0].Value;
            cmb_tenkh.Text = dgridviews.CurrentRow.Cells[2].Value.ToString();
            cmb_tennv.Text = dgridviews.CurrentRow.Cells[3].Value.ToString();
            tbx_mahd.Text = dgridviews.CurrentRow.Cells[4].Value.ToString();
            dtp_ngaytao.Text = dgridviews.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaythanhtoan.Text = dgridviews.CurrentRow.Cells[6].Value.ToString();
            dtp_ngayship.Text = dgridviews.CurrentRow.Cells[7].Value.ToString();
            dtp_ngaynhan.Text = dgridviews.CurrentRow.Cells[8].Value.ToString();
            var a = dgridviews.CurrentRow.Cells[9].Value.ToString() == "Chưa nhận" ? cbx_chuanhan.Checked = true : cbx_danhan.Checked = true;
            tbx_tennguoinhan.Text = dgridviews.CurrentRow.Cells[10].Value.ToString();
            tbx_diachi.Text = dgridviews.CurrentRow.Cells[11].Value.ToString();
            tbx_sdt.Text = dgridviews.CurrentRow.Cells[12].Value.ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            cmb_tenkh.Text = "";
            cmb_tennv.Text = "";
            tbx_mahd.Text = "";
            dtp_ngaytao.Value = DateTime.Now;
            dtp_ngaythanhtoan.Value = DateTime.Now;
            dtp_ngayship.Value = DateTime.Now;
            dtp_ngaynhan.Value = DateTime.Now;
            cbx_chuanhan.Checked = false;
            cbx_danhan.Checked = false;
            tbx_tennguoinhan.Text = "";
            tbx_diachi.Text = "";
            tbx_sdt.Text = "";
            LoadToGrid();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            //HoaDonViews hdv = new HoaDonViews();
            //hdv.HoaDon = new _1_DAL.DomainClass.HoaDon()
            //{
            //    IdKh = _IQLKhachHangService.GetIdByName(cmb_tenkh.Text),
            //    IdNv = _IQLNhanVienService.GetNhanVienByName(cmb_tennv.Text).Id,
            //    Ma = tbx_mahd.Text,
            //    NgayTao = dtp_ngaytao.Value,
            //    NgayThanhToan = dtp_ngaythanhtoan.Value,
            //    NgayShip = dtp_ngayship.Value,
            //    NgayNhan = dtp_ngaynhan.Value,
            //    TinhTrang = cbx_chuanhan.Checked ? 0 : 1,
            //    TenNguoiNhan = tbx_tennguoinhan.Text,
            //    DiaChi = tbx_diachi.Text,
            //    Sdt = tbx_sdt.Text,
            //};
            //DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dg == DialogResult.Yes)
            //{
            //    MessageBox.Show(_IQLHoaDonService.Add(hdv));
            //    btn_lammoi_Click(null, null);
            //}
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //HoaDonViews hdv = new HoaDonViews();
            //hdv.HoaDon = new _1_DAL.DomainClass.HoaDon()
            //{
            //    Id = _CurrentId,
            //    IdKh = _IQLKhachHangService.GetIdByName(cmb_tenkh.Text),
            //    IdNv = _IQLNhanVienService.GetNhanVienByName(cmb_tennv.Text).Id,
            //    Ma = tbx_mahd.Text,
            //    NgayTao = dtp_ngaytao.Value,
            //    NgayThanhToan = dtp_ngaythanhtoan.Value,
            //    NgayShip = dtp_ngayship.Value,
            //    NgayNhan = dtp_ngaynhan.Value,
            //    TinhTrang = cbx_chuanhan.Checked ? 0 : 1,
            //    TenNguoiNhan = tbx_tennguoinhan.Text,
            //    DiaChi = tbx_diachi.Text,
            //    Sdt = tbx_sdt.Text,
            //};
            //DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dg == DialogResult.Yes)
            //{
            //    MessageBox.Show(_IQLHoaDonService.Update(hdv));
            //    btn_lammoi_Click(null, null);
            //}
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //HoaDonViews hdv = new HoaDonViews();
            //hdv.HoaDon = new _1_DAL.DomainClass.HoaDon()
            //{
            //    Id = _CurrentId,

            //};
            //DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            //if (dg == DialogResult.Yes)
            //{
            //    MessageBox.Show(_IQLHoaDonService.Delete(hdv));
            //    btn_lammoi_Click(null, null);
            //}
        }

        private void cbx_dagiao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_danhan.Checked)
            {
                cbx_chuanhan.Checked = false;
            }
        }

        private void cbx_chuagiao_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_chuanhan.Checked)
            {
                cbx_danhan.Checked = false;
            }
        }
    }
}
