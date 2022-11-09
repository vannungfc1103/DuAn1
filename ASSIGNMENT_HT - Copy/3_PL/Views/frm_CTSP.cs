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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class frm_CTSP : Form
    {
        ICTSP_Service _ICTSP_Service;
        ISanPhamService _ISanPhamService;
        Guid _ID;
        List<CTSP_Views> _lst;

        public frm_CTSP()
        {
            InitializeComponent();
            _ICTSP_Service = new CTSP_Service();
            _ISanPhamService = new SanPhamService();
            _lst = new List<CTSP_Views>();
            _lst = _ICTSP_Service.GetAll();
            LoadToGrid(_lst);

            LoadToCmb();
        }
        private void LoadToCmb()
        {
            cmb_tensp.Items.Clear();
            foreach (var item in _ICTSP_Service.GetAll())
            {
                cmb_tensp.Items.Add(item.TenSp);
            }
        }
        private void LoadToGrid(List<CTSP_Views> lst)
        {
            dgrid_show.Rows.Clear();
            dgrid_show.ColumnCount = 8;
            dgrid_show.Columns[0].Name = "ID";
            dgrid_show.Columns[0].Visible = false;
            dgrid_show.Columns[1].Name = "Tên sp";
            dgrid_show.Columns[2].Name = "IDSP  ";
            dgrid_show.Columns[3].Name = "Mô tả";
            dgrid_show.Columns[4].Name = "Số lượng tồn ";
            dgrid_show.Columns[5].Name = "Giá nhập";
            dgrid_show.Columns[6].Name = "Giá bán";
            dgrid_show.Columns[7].Name = "Giá trị tồn";
            foreach (var item in lst)
            {
                dgrid_show.Rows.Add(item.Id, item.TenSp, item.IdSp, item.MoTa,item.SoLuongTon,item.GiaNhap,item.GiaBan,item.GiaTriTon);
            }
        }

        private void dgrid_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _ID = Guid.Parse(dgrid_show.CurrentRow.Cells[0].Value.ToString());
            cmb_tensp.Text = dgrid_show.CurrentRow.Cells[1].Value.ToString();
            tbx_mota.Text = dgrid_show.CurrentRow.Cells[3].Value.ToString();
            tbx_soluongton.Text = dgrid_show.CurrentRow.Cells[4].Value.ToString();
            tbx_gianhap.Text = dgrid_show.CurrentRow.Cells[5].Value.ToString();
            tbx_giaban.Text = dgrid_show.CurrentRow.Cells[6].Value.ToString();
            tbx_giatriton.Text = dgrid_show.CurrentRow.Cells[7].Value.ToString();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            var ac = _ISanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmb_tensp.Text);
            if (ac==null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else
            {
                CTSP_Views c = new CTSP_Views()
                {
                    IdSp = ac.Id,
                    MoTa = tbx_mota.Text,
                    SoLuongTon = int.Parse(tbx_soluongton.Text),
                    GiaNhap = decimal.Parse(tbx_gianhap.Text),
                    GiaBan = decimal.Parse(tbx_giaban.Text),
                    GiaTriTon = decimal.Parse(tbx_giatriton.Text),
                };
                DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không?","Thông báo",MessageBoxButtons.YesNo);
                if (dg==DialogResult.Yes)
                {
                    MessageBox.Show(_ICTSP_Service.Add(c));
                    btn_load_Click(null,null);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var ac = _ISanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmb_tensp.Text);
            if (ac==null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else
            {
                CTSP_Views c = new CTSP_Views()
                {
                    Id = _ID,
                    IdSp = ac.Id,
                    MoTa = tbx_mota.Text,
                    SoLuongTon = int.Parse(tbx_soluongton.Text),
                    GiaNhap = decimal.Parse(tbx_gianhap.Text),
                    GiaBan = decimal.Parse(tbx_giaban.Text),
                    GiaTriTon = decimal.Parse(tbx_giatriton.Text),
                };
                DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ICTSP_Service.Update(c));
                    btn_load_Click(null, null);

                }
            }
           
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (_ID == Guid.Empty)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
            }
            else
            {

                DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    MessageBox.Show(_ICTSP_Service.Delete(_ID));
                    btn_load_Click(null, null);
                }

            }

        }

        private void frm_CTSP_Load(object sender, EventArgs e)
        {
           

        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            var lst = _ICTSP_Service.GetAll().Where(c => c.TenSp.ToLower().Contains(tbx_search.Text.ToLower())).ToList();
            if (lst==null)
            {
                MessageBox.Show("Không tìm thấy kết quả");
            }
            LoadToGrid(lst);
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {

            if (tbx_giamin.Text ==""&&tbx_giamax.Text=="")
            {
                MessageBox.Show("Không được để trống giá giá min và max");
            }
            else if (tbx_giamin.Text == "" || tbx_giamax.Text == "")
            {
                MessageBox.Show("Không được để trống giá giá min hoặc max");
            }
            else if (Convert.ToDecimal(tbx_giamin.Text) >= Convert.ToDecimal(tbx_giamax.Text))
            {
                MessageBox.Show("Giá min phải nhỏ hơn giá max");
            }
            else 
            {
                var x = _ICTSP_Service.GetAll().Where(c => c.GiaBan >= Convert.ToDecimal(tbx_giamin.Text) && c.GiaBan <= Convert.ToDecimal(tbx_giamax.Text)).ToList();
                if (x==null)
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả");
                    LoadToGrid(x);
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            _lst = _ICTSP_Service.GetAll();
            LoadToGrid(_lst);
        }

        private void tbx_soluongton_TextChanged(object sender, EventArgs e)
        {
            bool chu = Regex.IsMatch(tbx_soluongton.Text, @"[a-zA-Z]");
            bool so = Regex.IsMatch(tbx_soluongton.Text, @"[0-9]");
            if (chu)
            {
                MessageBox.Show("Số lượng tồn phải là 1 số");
            }
            else if (chu&&so)
            {
                MessageBox.Show("Số lượng tồn phải là 1 số");

            }else if (Convert.ToInt32(tbx_soluongton.Text) < 0)
            {
                MessageBox.Show("Số lượng tồn phải >=0");
            }

        }

        private void tbx_giaban_TextChanged(object sender, EventArgs e)
        {
            if (decimal.Parse(tbx_gianhap.Text)> decimal.Parse(tbx_giaban.Text))
            {

                MessageBox.Show("Giá nhập phải > giá bán");
            }
        }
    }
}
