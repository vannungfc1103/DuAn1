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
    public partial class frm_QLMauSac : Form
    {
        IMauSacService _IQLMauSacService;
        Guid _CurrentId;
        public frm_QLMauSac()
        {
            InitializeComponent();
            _IQLMauSacService = new MauSacService();
            LoadToGrid();
        }
        private void LoadToGrid()
        {
            dgrid_show.ColumnCount = 4;
            dgrid_show.Columns[0].Name = "ID";
            dgrid_show.Columns[0].Visible = false;
            dgrid_show.Columns[1].Name = "STT";
            dgrid_show.Columns[2].Name = "Mã";
            dgrid_show.Columns[3].Name = "Tên";
            int stt = 1;
            dgrid_show.Rows.Clear();
            foreach (var item in _IQLMauSacService.GetAll())
            {
                dgrid_show.Rows.Add(item.Id, stt++, item.Ma, item.Ten);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MauSacViews msv = new MauSacViews()
            {
                Ma = tbx_ma.Text,
                Ten = tbx_ten.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLMauSacService.Add(msv));
                LoadToGrid();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            MauSacViews msv = new MauSacViews()
            {
                Id =_CurrentId,
                Ma = tbx_ma.Text,
                Ten = tbx_ten.Text,
            };
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Sửa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLMauSacService.Update(msv));
                LoadToGrid();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
          
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn Xóa không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dg == DialogResult.Yes)
            {
                MessageBox.Show(_IQLMauSacService.Delete(_CurrentId));
                LoadToGrid();
            }
        }

        private void dgrid_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _CurrentId = (Guid)(dgrid_show.CurrentRow.Cells[0].Value);
            tbx_ma.Text = dgrid_show.CurrentRow.Cells[2].Value.ToString();
            tbx_ten.Text = dgrid_show.CurrentRow.Cells[3].Value.ToString();
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbx_ma_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tbx_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
