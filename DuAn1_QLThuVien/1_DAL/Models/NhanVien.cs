using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public Guid? IdCV { get; set; }
        public string? Name { get; set; }
        public string? DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SDT { get; set; }
        public virtual ChucVu ChucVu { get; set; }
    }
}
