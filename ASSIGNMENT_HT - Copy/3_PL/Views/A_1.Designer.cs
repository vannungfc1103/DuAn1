namespace _3_PL.Views
{
    partial class A_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_load = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_loc = new System.Windows.Forms.Button();
            this.tbx_giamax = new System.Windows.Forms.TextBox();
            this.tbx_giamin = new System.Windows.Forms.TextBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_tensp = new System.Windows.Forms.ComboBox();
            this.dgrid_show = new System.Windows.Forms.DataGridView();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tbx_giatriton = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_giaban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_gianhap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_soluongton = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_mota = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(689, 260);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(223, 48);
            this.btn_load.TabIndex = 66;
            this.btn_load.Text = "Làm mới";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(790, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 65;
            this.label9.Text = "Giá Max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "Giá Min";
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(901, 385);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(94, 29);
            this.btn_loc.TabIndex = 63;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // tbx_giamax
            // 
            this.tbx_giamax.Location = new System.Drawing.Point(776, 383);
            this.tbx_giamax.Name = "tbx_giamax";
            this.tbx_giamax.Size = new System.Drawing.Size(79, 27);
            this.tbx_giamax.TabIndex = 62;
            // 
            // tbx_giamin
            // 
            this.tbx_giamin.Location = new System.Drawing.Point(639, 383);
            this.tbx_giamin.Name = "tbx_giamin";
            this.tbx_giamin.Size = new System.Drawing.Size(79, 27);
            this.tbx_giamin.TabIndex = 61;
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(169, 385);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(412, 27);
            this.tbx_search.TabIndex = 60;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "Search";
            // 
            // cmb_tensp
            // 
            this.cmb_tensp.FormattingEnabled = true;
            this.cmb_tensp.Location = new System.Drawing.Point(164, 31);
            this.cmb_tensp.Name = "cmb_tensp";
            this.cmb_tensp.Size = new System.Drawing.Size(411, 28);
            this.cmb_tensp.TabIndex = 58;
            // 
            // dgrid_show
            // 
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(41, 418);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(976, 289);
            this.dgrid_show.TabIndex = 57;
            this.dgrid_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(689, 192);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(223, 48);
            this.btn_xoa.TabIndex = 56;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(689, 130);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(223, 48);
            this.btn_sua.TabIndex = 55;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(689, 73);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(223, 48);
            this.btn_them.TabIndex = 54;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_giatriton
            // 
            this.tbx_giatriton.Location = new System.Drawing.Point(166, 321);
            this.tbx_giatriton.Name = "tbx_giatriton";
            this.tbx_giatriton.Size = new System.Drawing.Size(412, 27);
            this.tbx_giatriton.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Giá trị tồn";
            // 
            // tbx_giaban
            // 
            this.tbx_giaban.Location = new System.Drawing.Point(166, 260);
            this.tbx_giaban.Name = "tbx_giaban";
            this.tbx_giaban.Size = new System.Drawing.Size(412, 27);
            this.tbx_giaban.TabIndex = 51;
            this.tbx_giaban.TextChanged += new System.EventHandler(this.tbx_giaban_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Giá bán";
            // 
            // tbx_gianhap
            // 
            this.tbx_gianhap.Location = new System.Drawing.Point(166, 206);
            this.tbx_gianhap.Name = "tbx_gianhap";
            this.tbx_gianhap.Size = new System.Drawing.Size(412, 27);
            this.tbx_gianhap.TabIndex = 49;
            this.tbx_gianhap.TextChanged += new System.EventHandler(this.tbx_gianhap_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Giá nhập";
            // 
            // tbx_soluongton
            // 
            this.tbx_soluongton.Location = new System.Drawing.Point(166, 145);
            this.tbx_soluongton.Name = "tbx_soluongton";
            this.tbx_soluongton.Size = new System.Drawing.Size(412, 27);
            this.tbx_soluongton.TabIndex = 47;
            this.tbx_soluongton.TextChanged += new System.EventHandler(this.tbx_soluongton_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Số lượng tồn";
            // 
            // tbx_mota
            // 
            this.tbx_mota.Location = new System.Drawing.Point(166, 84);
            this.tbx_mota.Name = "tbx_mota";
            this.tbx_mota.Size = new System.Drawing.Size(412, 27);
            this.tbx_mota.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên sp";
            // 
            // A_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 714);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_loc);
            this.Controls.Add(this.tbx_giamax);
            this.Controls.Add(this.tbx_giamin);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_tensp);
            this.Controls.Add(this.dgrid_show);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tbx_giatriton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_giaban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_gianhap);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_soluongton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_mota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "A_1";
            this.Text = "A_1";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.TextBox tbx_giamax;
        private System.Windows.Forms.TextBox tbx_giamin;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_tensp;
        private System.Windows.Forms.DataGridView dgrid_show;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tbx_giatriton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_giaban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_gianhap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_soluongton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_mota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}