using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class PhieuMuon
    {
        public Guid Id { get; set; }
        public Guid? IdTheTV { get; set; }
        public Guid? IdNV { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public string?  GhiChu { get; set; }
        public virtual TheThanhVien TheThanhVien { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
