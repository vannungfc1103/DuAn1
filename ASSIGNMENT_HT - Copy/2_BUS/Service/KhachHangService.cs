using _1_DAL.IRespositories;
using _1_DAL.Respositories;
using _1_DAL.DomainClass;
using _2_BUS.IService;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRespository _IKhachHangRespository;
        public KhachHangService()
        {
            _IKhachHangRespository = new KhachHangRespository();
        }

        public string Add(KhachHangViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var KhachHang = new KhachHang()
            {
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                Ma = obj.Ma,
                DiaChi = obj.DiaChi,
                NgaySinh = obj.NgaySinh,
                ThanhPho =obj.ThanhPho,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                QuocGia = obj.QuocGia,

            };
            if (_IKhachHangRespository.Add(KhachHang)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var KhachHang = new KhachHang()
            {
                Id = obj

            };
            if (_IKhachHangRespository.Delete(KhachHang)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<KhachHangViews> GetAll()
        {
            List<KhachHangViews> lst = new List<KhachHangViews>();
            lst =
                (
                from a in _IKhachHangRespository.GetAll()
                select new KhachHangViews()
                {
                    Id = a.Id,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    Ma = a.Ma,
                    DiaChi = a.DiaChi,
                    NgaySinh = a.NgaySinh,
                    ThanhPho = a.ThanhPho,
                    Sdt = a.Sdt,
                    MatKhau = a.MatKhau,
                    QuocGia = a.QuocGia,
                }
                ).ToList();
            return lst;
        }

      
        public string Update(KhachHangViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var KhachHang = new KhachHang()
            {
                Id = obj.Id,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                Ma = obj.Ma,
                DiaChi = obj.DiaChi,
                NgaySinh = obj.NgaySinh,
                ThanhPho = obj.ThanhPho,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                QuocGia = obj.QuocGia,

            };
            if (_IKhachHangRespository.Update(KhachHang)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
