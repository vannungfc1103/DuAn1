using _2_BUS.IService;
using _2_BUS.Service;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class frm_QLSanPham : Form
    {
        QLSanPhamCTService _QLSanPhamService;
        SanPhamService _SanPhamService;
        MauSacService _MauSacService;
        DongSpService _DongSpService;
        NsxService _NsxService;
        Guid _CurrentID;
        List<ChiTietSanPhamViews> _lst;
        public frm_QLSanPham()
        {
            InitializeComponent();
            _QLSanPhamService = new QLSanPhamCTService();
            _SanPhamService = new SanPhamService();
            _MauSacService = new MauSacService();
            _DongSpService = new DongSpService();
            _NsxService = new NsxService();
            _lst = new List<ChiTietSanPhamViews>();
            _lst = _QLSanPhamService.GetAll();
            LoadToCmb_TenSp();
            LoadToCmb_MauSac();
            LoadToCmb_DongSp();
            LoadToCmb_Nsx();
            LoadToGridViews(_lst);
        }
        private void LoadToCmb_TenSp()
        {
            foreach (var item in _SanPhamService.GetAll())
            {
                cmb_tensp.Items.Add(item.Ten);
            }
        }
        private void LoadToCmb_MauSac()
        {
            foreach (var item in _MauSacService.GetAll())
            {
                cmb_mausac.Items.Add(item.Ten);
            }
        }
        private void LoadToCmb_DongSp()
        {
            foreach (var item in _DongSpService.GetAll())
            {
                cmb_dongsp.Items.Add(item.Ten);
            }
        }
        private void LoadToCmb_Nsx()
        {
            foreach (var item in _NsxService.GetAll())
            {
                cmb_tennsx.Items.Add(item.Ten);
            }
        }
        private void LoadToGridViews(List<ChiTietSanPhamViews> lst)
        {
            int stt = 1;
            dgridviews.Rows.Clear();
            dgridviews.ColumnCount = 11;
            dgridviews.Columns[0].Name = "ID";
            dgridviews.Columns[0].Visible = false;
            dgridviews.Columns[1].Name = "STT";
            dgridviews.Columns[2].Name = "Tên Sp";
            dgridviews.Columns[3].Name = "Màu Sp";
            dgridviews.Columns[4].Name = "Dòng Sp";
            dgridviews.Columns[5].Name = "Nsx";
            dgridviews.Columns[6].Name = "Năm BH";
            dgridviews.Columns[7].Name = "Mô tả";
            dgridviews.Columns[8].Name = "SL tồn";
            dgridviews.Columns[9].Name = "Giá nhập";
            dgridviews.Columns[10].Name = "Giá bán";
            foreach (var item in lst)
            {
                dgridviews.Rows.Add(item.Id, stt++, item.TenSp, item.TenMauSac, item.TenDongSp, item.TenNsx, item.NamBh,item.MoTa, item.SoLuongTon, item.GiaNhap, item.GiaBan);
            }
        }
        
        private void tbx_timkiem_TextChanged(object sender, EventArgs e)
        {
            //var x = _QLSanPhamService.GetAll(tbx_timkiem.Text);
            //LoadToGridSearch(x);
        }

        private void dgridviews_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentID = (Guid)dgridviews.CurrentRow.Cells[0].Value;
            cmb_tensp.Text = dgridviews.CurrentRow.Cells[2].Value.ToString();
            cmb_mausac.Text = dgridviews.CurrentRow.Cells[3].Value.ToString();
            cmb_dongsp.Text = dgridviews.CurrentRow.Cells[4].Value.ToString();
            cmb_tennsx.Text = dgridviews.CurrentRow.Cells[5].Value.ToString();
            tbx_nambh.Text = dgridviews.CurrentRow.Cells[6].Value.ToString();
            tbx_mota.Text = dgridviews.CurrentRow.Cells[7].Value.ToString();
            tbx_soluongton.Text = dgridviews.CurrentRow.Cells[8].Value.ToString();
            tbx_gianhap.Text = dgridviews.CurrentRow.Cells[9].Value.ToString();
            tbx_giaban.Text = dgridviews.CurrentRow.Cells[10].Value.ToString();
        }

        private void btn_lammoi_Click(object sender, EventArgs e)
        {
            cmb_tensp.Text = "";
            cmb_mausac.Text = "";
            cmb_dongsp.Text = "";
            cmb_tennsx.Text = "";
            tbx_nambh.Text = "";
            tbx_mota.Text = "";
            tbx_soluongton.Text = "";
            tbx_gianhap.Text = "";
            tbx_giaban.Text = "";
            _lst = _QLSanPhamService.GetAll();
            LoadToGridViews(_lst);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var SanPham = _SanPhamService.GetAll().FirstOrDefault(c=>c.Ten == cmb_tensp.Text).Id;
            var MauSac = _MauSacService.GetAll().FirstOrDefault(c=>c.Ten == cmb_mausac.Text).Id;
            var DongSp = _DongSpService.GetAll().FirstOrDefault(c=>c.Ten == cmb_dongsp.Text).Id;
            var Nsx = _NsxService.GetAll().FirstOrDefault(c=>c.Ten == cmb_tennsx.Text).Id;
            ChiTietSanPhamViews spv = new ChiTietSanPhamViews()
            {
                IdSp = SanPham,
                IdMauSac = MauSac,
                IdDongSp = DongSp,
                IdNsx = Nsx,
                NamBh = int.Parse(tbx_nambh.Text),
                MoTa = tbx_mota.Text,
                SoLuongTon = int.Parse(tbx_soluongton.Text),
                GiaBan = int.Parse(tbx_giaban.Text),
                GiaNhap = int.Parse(tbx_gianhap.Text)
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_QLSanPhamService.Add(spv));
            }
            btn_lammoi_Click(null,null);
            
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var SanPham = _SanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmb_tensp.Text).Id;
            var MauSac = _MauSacService.GetAll().FirstOrDefault(c => c.Ten == cmb_mausac.Text).Id;
            var DongSp = _DongSpService.GetAll().FirstOrDefault(c => c.Ten == cmb_dongsp.Text).Id;
            var Nsx = _NsxService.GetAll().FirstOrDefault(c => c.Ten == cmb_tennsx.Text).Id;
            ChiTietSanPhamViews spv = new ChiTietSanPhamViews()
            {
                Id = _CurrentID,

                IdSp = SanPham,
                IdMauSac = MauSac,
                IdDongSp = DongSp,
                IdNsx = Nsx,
                NamBh = int.Parse(tbx_nambh.Text),
                MoTa = tbx_mota.Text,
                SoLuongTon = int.Parse(tbx_soluongton.Text),
                GiaBan = int.Parse(tbx_giaban.Text),
                GiaNhap = int.Parse(tbx_gianhap.Text)
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_QLSanPhamService.Update(spv));
            }
            btn_lammoi_Click(null, null);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {

                MessageBox.Show(_QLSanPhamService.Delete(_CurrentID));
            }
            btn_lammoi_Click(null, null);
        }



        private void tbx_soluongton_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
