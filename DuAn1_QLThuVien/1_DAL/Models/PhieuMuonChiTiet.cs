using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class PhieuMuonChiTiet
    {
        public Guid  Id { get; set; }
        public Guid? IdPM { get; set; }
        public Guid? IdSach { get; set; }
        public int? SoLuong { get; set; }
        public string? DieuKien { get; set; }
        public string? GhiChu { get; set; }
        public Sach Sach { get; set; }
        public PhieuMuon PhieuMuon { get; set; }

    }
}
