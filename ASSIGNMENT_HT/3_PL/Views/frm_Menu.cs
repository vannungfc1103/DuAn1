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
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
            anMenu();
            openForm(new frm_anh());
        }
        private void anMenu()
        {
            panel_trangchu.Visible = false;
            panel_sanpham.Visible = false;
            panel_quanli.Visible = false;
        }
        private void HienMenu()
        {
            if (panel_trangchu.Visible == true)
            {
                panel_trangchu.Visible = false;
            }
            if (panel_sanpham.Visible == true)
            {
                panel_sanpham.Visible = false;
            }
            if (panel_quanli.Visible == true)
            {
                panel_quanli.Visible = false;
            }
        }
        private void showmMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HienMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openForm(Form form)
        {
            if (activeForm != null)
            activeForm.Close();
            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel_showform.Controls.Add(form);
            panel_showform.Tag = form;
            form.Show();
        }

        private void btn_menu_trangchu_Click(object sender, EventArgs e)
        {
            showmMenu(panel_trangchu);
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLKhachHang());
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLHoaDon());
        }

        private void btn_hoadonchitiet_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLHoaDonCT());
        }

        private void btn_menu_sanpham_Click(object sender, EventArgs e)
        {
            showmMenu(panel_sanpham);
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLMauSac());
        }

        private void btn_nhasanxuat_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLNsx());
        }

        private void btn_dongsp_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLDongSp());
        }

        private void btn_menu_quanli_Click(object sender, EventArgs e)
        {
            showmMenu(panel_quanli);
        }

        private void btn_chucvu_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLChucVu());
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLNhanVien());

        }

        private void btn_cuahang_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLCuaHang());
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            HienMenu();
            openForm(new frm_QLSanPham());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            openForm(new frm_anh());
        }
    }
}
