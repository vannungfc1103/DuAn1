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
using System.Windows.Media;

namespace _3_PL.Views
{
    public partial class frm_QLKhachHang : Form
    {
        IKhachHangService _IQLKhachHangService;
        Guid _CurrentId;
        public frm_QLKhachHang()
        {
            InitializeComponent();
            _IQLKhachHangService = new KhachHangService();
            LoadToGrid();
        }
        private void LoadToGrid()
        {
            int stt = 1;
            dgridviews.Rows.Clear();
            dgridviews.ColumnCount = 12;
            dgridviews.Columns[0].Name = "ID";
            dgridviews.Columns[0].Visible = false;
            dgridviews.Columns[1].Name = "STT";
            dgridviews.Columns[2].Name = "Họ";
            dgridviews.Columns[3].Name = "Tên đệm";
            dgridviews.Columns[4].Name = "Tên";
            dgridviews.Columns[5].Name = "Mã KH";
            dgridviews.Columns[6].Name = "Ngày sinh";
            dgridviews.Columns[7].Name = "SDT";
            dgridviews.Columns[8].Name = "Địa chỉ";
            dgridviews.Columns[9].Name = "Thành Phố";
            dgridviews.Columns[10].Name = "Quốc gia";
            dgridviews.Columns[11].Name = "Mật khẩu";
            foreach (var item in _IQLKhachHangService.GetAll())
            {
                dgridviews.Rows.Add(
                    item.Id,
                    stt++,
                    item.Ho,
                    item.TenDem,
                    item.Ten,
                    item.Ma,
                    item.NgaySinh,
                    item.Sdt,
                    item.DiaChi,
                    item.ThanhPho,
                    item.QuocGia,
                    item.MatKhau
                    );
            }
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            LoadToGrid();
            tbx_ten.Text = "";
            tbx_tendem.Text = "";
            tbx_ho.Text = "";
            tbx_makh.Text = "";
            dtp_ngaysinh.Value = DateTime.Now;
            tbx_sdt.Text = "";
            tbx_diachi.Text = "";
            tbx_thanhpho.Text = "";
            tbx_quocgia.Text = "";
            tbx_matkhau.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            KhachHangViews khv = new KhachHangViews()
            {
                Id = new Guid(),
                Ten = tbx_ten.Text,
                TenDem = tbx_tendem.Text,
                Ho = tbx_ho.Text,
                Ma = tbx_makh.Text,
                NgaySinh = dtp_ngaysinh.Value,
                Sdt = tbx_sdt.Text,
                DiaChi = tbx_diachi.Text,
                ThanhPho = tbx_thanhpho.Text,
                QuocGia = tbx_quocgia.Text,
                MatKhau = tbx_matkhau.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLKhachHangService.Add(khv));
                LoadToGrid();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            KhachHangViews khv = new KhachHangViews()
            {
                Id = _CurrentId,
                Ten = tbx_ten.Text,
                TenDem = tbx_tendem.Text,
                Ho = tbx_ho.Text,
                Ma = tbx_makh.Text,
                NgaySinh = dtp_ngaysinh.Value,
                Sdt = tbx_sdt.Text,
                DiaChi = tbx_diachi.Text,
                ThanhPho = tbx_thanhpho.Text,
                QuocGia = tbx_quocgia.Text,
                MatKhau = tbx_matkhau.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLKhachHangService.Update(khv));
                LoadToGrid();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
         
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLKhachHangService.Delete(_CurrentId));
                LoadToGrid();
            }
        }

        private void dgridviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentId = (Guid)(dgridviews.CurrentRow.Cells[0].Value);
            tbx_ten.Text = dgridviews.CurrentRow.Cells[4].Value.ToString();
            tbx_tendem.Text = dgridviews.CurrentRow.Cells[3].Value.ToString();
            tbx_ho.Text = dgridviews.CurrentRow.Cells[2].Value.ToString();
            tbx_makh.Text = dgridviews.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaysinh.Text = dgridviews.CurrentRow.Cells[6].Value.ToString();
            tbx_sdt.Text = dgridviews.CurrentRow.Cells[7].Value.ToString();
            tbx_diachi.Text = dgridviews.CurrentRow.Cells[8].Value.ToString();
            tbx_thanhpho.Text = dgridviews.CurrentRow.Cells[9].Value.ToString();
            tbx_quocgia.Text = dgridviews.CurrentRow.Cells[10].Value.ToString();
            tbx_matkhau.Text = dgridviews.CurrentRow.Cells[11].Value.ToString();
        }
    }
}
