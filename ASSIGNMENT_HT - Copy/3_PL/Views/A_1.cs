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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class A_1 : Form
    {
        List<CTSP_Views> _lst;
        Guid _CurrentID;
        ICTSP_Service _ICTSP_Service;
        ISanPhamService _ISanPhamService;
        public A_1()
        {
            InitializeComponent();
            _lst = new List<CTSP_Views>();
            _ICTSP_Service = new CTSP_Service();
            _ISanPhamService = new SanPhamService();
            LoadToCmb();
            _lst = _ICTSP_Service.GetAll();
            LoadToGrid(_lst);
        }
        public void LoadToGrid(List<CTSP_Views> lst)
        {
            dgrid_show.Rows.Clear();
            dgrid_show.ColumnCount = 8;
            dgrid_show.Columns[0].Name = "ID";
            dgrid_show.Columns[0].Visible = false;
            dgrid_show.Columns[1].Name = "ID SP";
            dgrid_show.Columns[2].Name = "Tên SP";
            dgrid_show.Columns[3].Name = "Mô tả";
            dgrid_show.Columns[4].Name = "Số lượng tồn";
            dgrid_show.Columns[5].Name = "Giá nhập";
            dgrid_show.Columns[6].Name = "Giá bán";
            dgrid_show.Columns[7].Name = "Giá trị tồn";
            foreach (var item in lst)
            {
                dgrid_show.Rows.Add(item.Id,item.IdSp,item.TenSp,item.MoTa,item.SoLuongTon,item.GiaNhap,item.GiaBan,item.GiaTriTon);
            }
        }
        public void LoadToCmb()
        {
            cmb_tensp.Items.Clear();
            foreach (var item in _ISanPhamService.GetAll())
            {
                cmb_tensp.Items.Add(item.Ten);
            }
        }

        private void dgrid_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentID = Guid.Parse(dgrid_show.CurrentRow.Cells[0].Value.ToString());
            cmb_tensp.Text = dgrid_show.CurrentRow.Cells[2].Value.ToString();
            tbx_mota.Text = dgrid_show.CurrentRow.Cells[3].Value.ToString();
            tbx_soluongton.Text = dgrid_show.CurrentRow.Cells[4].Value.ToString();
            tbx_gianhap.Text = dgrid_show.CurrentRow.Cells[5].Value.ToString();
            tbx_giaban.Text = dgrid_show.CurrentRow.Cells[6].Value.ToString();
            tbx_giatriton.Text = dgrid_show.CurrentRow.Cells[7].Value.ToString();
            
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            _lst = _ICTSP_Service.GetAll();
            LoadToGrid(_lst);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var a = _ISanPhamService.GetAll().FirstOrDefault(c => c.Ten== cmb_tensp.Text);
            if (a==null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!","Thông báo");
            }
            else
            {
                CTSP_Views c = new CTSP_Views()
                {
                    IdSp = a.Id,
                    MoTa = tbx_mota.Text,
                    SoLuongTon = int.Parse(tbx_soluongton.Text),
                    GiaNhap = decimal.Parse(tbx_gianhap.Text),
                    GiaBan = decimal.Parse(tbx_giaban.Text),
                    GiaTriTon = decimal.Parse(tbx_giatriton.Text),
                };
                DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn thêm không?","THÔNG BÁO",MessageBoxButtons.YesNo);
                if (d==DialogResult.Yes)
                {
                    MessageBox.Show(_ICTSP_Service.Add(c));
                    btn_load_Click(null,null);
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var a = _ISanPhamService.GetAll().FirstOrDefault(c => c.Ten == cmb_tensp.Text);
            if (a == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!", "Thông báo");
            }
            else
            {
                CTSP_Views c = new CTSP_Views()
                {
                    Id = _CurrentID,
                    IdSp = a.Id,
                    MoTa = tbx_mota.Text,
                    SoLuongTon = int.Parse(tbx_soluongton.Text),
                    GiaNhap = decimal.Parse(tbx_gianhap.Text),
                    GiaBan = decimal.Parse(tbx_giaban.Text),
                    GiaTriTon = decimal.Parse(tbx_giatriton.Text),
                };
                DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    MessageBox.Show(_ICTSP_Service.Update(c));
                    btn_load_Click(null, null);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "THÔNG BÁO", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                MessageBox.Show(_ICTSP_Service.Delete(_CurrentID));
                btn_load_Click(null, null);
            }
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            var x = _ICTSP_Service.GetAll().Where(c=>c.TenSp.ToLower().Contains(tbx_search.Text.ToLower()));
            LoadToGrid(x.ToList());
        }

        private void btn_loc_Click(object sender, EventArgs e)
        {

            string regex = @"[0-9]";
            if (tbx_giamin.Text==""&&tbx_giamax.Text=="")
            {
                MessageBox.Show("hãy nhập giá min và giá max");

            }
            else if (tbx_giamin.Text=="")
            {
                MessageBox.Show("hãy nhập giá min");
            }
            else if (tbx_giamax.Text == "")
            {
                MessageBox.Show("hãy nhập giá max");
            }
            else if (!Regex.IsMatch(tbx_giamin.Text,regex))
            {
                MessageBox.Show("hãy nhập 1 số");
            }
            else if (!Regex.IsMatch(tbx_giamax.Text, regex))
            {
                MessageBox.Show("hãy nhập 1 số");
            }else if (decimal.Parse(tbx_giamin.Text) < 0)
            {
                MessageBox.Show("hãy nhập 1 số >0");
            }
            else if (decimal.Parse(tbx_giamax.Text) < 0)
            {
                MessageBox.Show("hãy nhập 1 số >0");
            }
            else
            {
                var x = _ICTSP_Service.GetAll().Where(c => c.GiaBan >= decimal.Parse(tbx_giamin.Text) && c.GiaBan <= decimal.Parse(tbx_giamax.Text)).ToList();
                LoadToGrid(x);
            }
        }

        private void tbx_soluongton_TextChanged(object sender, EventArgs e)
        {
            bool rgChu = Regex.IsMatch(tbx_soluongton.Text, @"[a-zA-Z]");
            bool rgSo = Regex.IsMatch(tbx_soluongton.Text, @"[0-9]");
            try
            {

                if (tbx_soluongton.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ");
                }
                else if (rgChu)
                {
                    MessageBox.Show("Vui lòng nhập 1 số");
                }
                else if (rgChu && rgSo)
                {
                    MessageBox.Show("Vui lòng nhập 1 số");
                }

                else if (int.Parse(tbx_soluongton.Text) < 0)
                {
                    MessageBox.Show("Vui lòng nhập 1 số>0");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng nhập 1 số>0");
            }
        }

        private void tbx_gianhap_TextChanged(object sender, EventArgs e)
        {

            bool rgChu = Regex.IsMatch(tbx_gianhap.Text, @"[a-zA-Z]");
            bool rgSo = Regex.IsMatch(tbx_gianhap.Text, @"[0-9]");
            try
            {

                if (tbx_gianhap.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập ");
                }
                else if (rgChu)
                {
                    MessageBox.Show("Vui lòng nhập 1 số");
                }
                else if (rgChu && rgSo)
                {
                    MessageBox.Show("Vui lòng nhập 1 số");
                }
                else if (int.Parse(tbx_gianhap.Text) < 0)
                {
                    MessageBox.Show("Vui lòng nhập 1 số>0");
                }
                else if (decimal.Parse(tbx_gianhap.Text) > decimal.Parse(tbx_giaban.Text))
                {
                    MessageBox.Show("Giá nhập phải < giá bán");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng nhập ");
            }
        }

        private void tbx_giaban_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (decimal.Parse(tbx_gianhap.Text) > decimal.Parse(tbx_giaban.Text))
                {
                    MessageBox.Show("Giá nhập phải < giá bán");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Vui lòng nhập ");
            }
        }
    }
}
