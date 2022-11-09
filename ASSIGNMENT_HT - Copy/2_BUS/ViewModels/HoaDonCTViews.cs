using _1_DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class HoaDonCTViews
    {
        public ChiTietSp ChiTietSp { get; set; }
        public HoaDon HoaDon { get; set; }

        public HoaDonChiTiet HoaDonChiTiet { get;set;}
    }
}
