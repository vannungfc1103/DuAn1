using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class Sach
    {
        public Guid Id { get; set; }
        public string? TL { get; set; }
        public string? TG { get; set; }
        public string? NXB { get; set; }
        public string? Name { get; set; }
        public int? SoLuong { get; set; }
        public int? GiaTien { get; set; }
        public string? GhiChu { get; set; }


    }
}
