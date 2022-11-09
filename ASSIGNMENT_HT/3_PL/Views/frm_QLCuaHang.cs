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
    public partial class frm_QLCuaHang : Form
    {
        ICuaHangService _IQLCuaHangService;
        Guid _CurrentId;
        public frm_QLCuaHang()
        {
            InitializeComponent();
            _IQLCuaHangService = new CuaHangService();
            LoadToGrid();
        }
        private void LoadToGrid()
        {
            dgrid_show.ColumnCount = 7;
            dgrid_show.Columns[0].Name = "ID";
            dgrid_show.Columns[0].Visible = false;
            dgrid_show.Columns[1].Name = "STT";
            dgrid_show.Columns[2].Name = "Mã";
            dgrid_show.Columns[3].Name = "Tên";
            dgrid_show.Columns[4].Name = "Địa chỉ";
            dgrid_show.Columns[5].Name = "Thành phố";
            dgrid_show.Columns[6].Name = "Quốc gia";
            int stt = 1;
            dgrid_show.Rows.Clear();
            foreach (var item in _IQLCuaHangService.GetAll())
            {
                dgrid_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            CuaHangViews chv = new CuaHangViews()
            {
                Id = new Guid(),
                Ma = tbx_ma.Text,
                Ten = tbx_ten.Text,
                DiaChi = tbx_diachi.Text,
                ThanhPho = tbx_thanhpho.Text,
                QuocGia = tbx_quocgia.Text
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLCuaHangService.Add(chv));
                LoadToGrid();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            CuaHangViews chv = new CuaHangViews()
            {
                Id = _CurrentId,
                Ma = tbx_ma.Text,
                Ten = tbx_ten.Text,
                DiaChi = tbx_diachi.Text,
                ThanhPho = tbx_thanhpho.Text,
                QuocGia = tbx_quocgia.Text
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLCuaHangService.Update(chv));
                LoadToGrid();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
           
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLCuaHangService.Delete(_CurrentId));
                LoadToGrid();
            }
        }

        private void dgrid_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentId = (Guid)(dgrid_show.CurrentRow.Cells[0].Value);
            tbx_ma.Text = dgrid_show.CurrentRow.Cells[2].Value.ToString();
            tbx_ten.Text = dgrid_show.CurrentRow.Cells[3].Value.ToString();
            tbx_diachi.Text = dgrid_show.CurrentRow.Cells[4].Value.ToString();
            tbx_thanhpho.Text = dgrid_show.CurrentRow.Cells[5].Value.ToString();
            tbx_quocgia.Text = dgrid_show.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
