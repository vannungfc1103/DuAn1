namespace _3_PL.Views
{
    partial class frm_CTSP
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
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_giamin = new System.Windows.Forms.TextBox();
            this.tbx_giamax = new System.Windows.Forms.TextBox();
            this.btn_loc = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_tensp
            // 
            this.cmb_tensp.FormattingEnabled = true;
            this.cmb_tensp.Location = new System.Drawing.Point(238, 12);
            this.cmb_tensp.Name = "cmb_tensp";
            this.cmb_tensp.Size = new System.Drawing.Size(411, 28);
            this.cmb_tensp.TabIndex = 34;
            // 
            // dgrid_show
            // 
            this.dgrid_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_show.Location = new System.Drawing.Point(112, 451);
            this.dgrid_show.Name = "dgrid_show";
            this.dgrid_show.RowHeadersWidth = 51;
            this.dgrid_show.RowTemplate.Height = 29;
            this.dgrid_show.Size = new System.Drawing.Size(1041, 340);
            this.dgrid_show.TabIndex = 33;
            this.dgrid_show.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_show_CellClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(763, 165);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(226, 72);
            this.btn_xoa.TabIndex = 32;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(763, 87);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(226, 72);
            this.btn_sua.TabIndex = 31;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(763, 9);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(226, 72);
            this.btn_them.TabIndex = 30;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_giatriton
            // 
            this.tbx_giatriton.Location = new System.Drawing.Point(240, 302);
            this.tbx_giatriton.Name = "tbx_giatriton";
            this.tbx_giatriton.Size = new System.Drawing.Size(412, 27);
            this.tbx_giatriton.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Giá trị tồn";
            // 
            // tbx_giaban
            // 
            this.tbx_giaban.Location = new System.Drawing.Point(240, 241);
            this.tbx_giaban.Name = "tbx_giaban";
            this.tbx_giaban.Size = new System.Drawing.Size(412, 27);
            this.tbx_giaban.TabIndex = 27;
            this.tbx_giaban.TextChanged += new System.EventHandler(this.tbx_giaban_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Giá bán";
            // 
            // tbx_gianhap
            // 
            this.tbx_gianhap.Location = new System.Drawing.Point(240, 187);
            this.tbx_gianhap.Name = "tbx_gianhap";
            this.tbx_gianhap.Size = new System.Drawing.Size(412, 27);
            this.tbx_gianhap.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(124, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Giá nhập";
            // 
            // tbx_soluongton
            // 
            this.tbx_soluongton.Location = new System.Drawing.Point(240, 126);
            this.tbx_soluongton.Name = "tbx_soluongton";
            this.tbx_soluongton.Size = new System.Drawing.Size(412, 27);
            this.tbx_soluongton.TabIndex = 23;
            this.tbx_soluongton.TextChanged += new System.EventHandler(this.tbx_soluongton_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Số lượng tồn";
            // 
            // tbx_mota
            // 
            this.tbx_mota.Location = new System.Drawing.Point(240, 65);
            this.tbx_mota.Name = "tbx_mota";
            this.tbx_mota.Size = new System.Drawing.Size(412, 27);
            this.tbx_mota.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mô tả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên sp";
            // 
            // tbx_search
            // 
            this.tbx_search.Location = new System.Drawing.Point(240, 418);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(412, 27);
            this.tbx_search.TabIndex = 36;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Search";
            // 
            // tbx_giamin
            // 
            this.tbx_giamin.Location = new System.Drawing.Point(854, 415);
            this.tbx_giamin.Name = "tbx_giamin";
            this.tbx_giamin.Size = new System.Drawing.Size(79, 27);
            this.tbx_giamin.TabIndex = 37;
            // 
            // tbx_giamax
            // 
            this.tbx_giamax.Location = new System.Drawing.Point(991, 415);
            this.tbx_giamax.Name = "tbx_giamax";
            this.tbx_giamax.Size = new System.Drawing.Size(79, 27);
            this.tbx_giamax.TabIndex = 38;
            // 
            // btn_loc
            // 
            this.btn_loc.Location = new System.Drawing.Point(1116, 417);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(94, 29);
            this.btn_loc.TabIndex = 39;
            this.btn_loc.Text = "Lọc";
            this.btn_loc.UseVisualStyleBackColor = true;
            this.btn_loc.Click += new System.EventHandler(this.btn_loc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(854, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Giá Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1005, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Giá Max";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(763, 241);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(226, 72);
            this.btn_load.TabIndex = 42;
            this.btn_load.Text = "Làm mới";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // frm_CTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 796);
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
            this.Name = "frm_CTSP";
            this.Text = "frm_CTSP";
            this.Load += new System.EventHandler(this.frm_CTSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_giamin;
        private System.Windows.Forms.TextBox tbx_giamax;
        private System.Windows.Forms.Button btn_loc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_load;
    }
}