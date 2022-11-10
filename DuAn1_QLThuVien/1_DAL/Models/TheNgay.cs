using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class TheNgay
    {
        public Guid Id { get; set; }
        public Guid?  IdNV { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? GhiChu { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
