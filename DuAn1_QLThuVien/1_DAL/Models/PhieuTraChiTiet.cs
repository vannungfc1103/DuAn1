using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class PhieuTraChiTiet
    {
        public Guid Id { get; set; }
        public Guid? IdPT { get; set; }
        public Guid? IdSach { get; set; }
        public int? SoLuong { get; set; }
        public int? TinhTrang { get; set; }
        public string? GhiChu { get; set; }
        public Sach Sach { get; set; }
        public PhieuTra PhieuTra { get; set; }

    }
}
