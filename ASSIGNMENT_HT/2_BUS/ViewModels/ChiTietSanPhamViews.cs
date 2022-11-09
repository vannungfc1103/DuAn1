using _1_DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class ChiTietSanPhamViews
    {
        public Guid Id { get; set; }
        public Guid? IdSp { get; set; }
        public string? TenSp { get; set; }
        public Guid? IdNsx { get; set; }
        public string? TenNsx { get; set; }
        public Guid? IdMauSac { get; set; }

        public string? TenMauSac { get; set; }
        public Guid? IdDongSp { get; set; }

        public string? TenDongSp { get; set; }
        public int? NamBh { get; set; }
        
        public string? MoTa { get; set; }
        public int? SoLuongTon { get; set; }
        
        public decimal? GiaNhap { get; set; }
        
        public decimal? GiaBan { get; set; }
    }
}
