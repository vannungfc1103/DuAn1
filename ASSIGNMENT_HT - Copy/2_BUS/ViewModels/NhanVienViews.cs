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
    public class NhanVienViews
    {
        public Guid Id { get; set; }

        public string? Ma { get; set; }
        
        public string? Ten { get; set; }
        
        public string? TenDem { get; set; }
        
        public string? Ho { get; set; }
        
        public string? GioiTinh { get; set; }
        
        public DateTime? NgaySinh { get; set; }
        
        public string? DiaChi { get; set; }
        
        public string? Sdt { get; set; }
        public string? MatKhau { get; set; }
        
        public Guid? IdCh { get; set; }
        public string? TenCH { get; set; }
        public Guid? IdCv { get; set; }
        public string? TenCV { get; set; }
        public Guid? IdGuiBc { get; set; }
        public int? TrangThai { get; set; }
    }
}
