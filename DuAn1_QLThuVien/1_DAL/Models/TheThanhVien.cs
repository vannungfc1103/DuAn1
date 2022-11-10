using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class TheThanhVien
    {
        public Guid Id { get; set; }
        public string? TenThanhVien { get; set; }
        public DateTime? NgayDangKi { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string? SDT { get; set; }
        public string? DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? GhiChu { get; set; }

    }
}
