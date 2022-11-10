using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class PhieuTra
    {
        public Guid Id { get; set; }
        public Guid? IdPM { get; set; }
        public DateTime? NgayTra { get; set; }
        public string?  GhiChu { get; set; }
        public PhieuMuon PhieuMuon { get; set; }
    }
}
