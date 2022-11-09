using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using _1_DAL.Respositories;
using _2_BUS.IService;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class CuaHangService:ICuaHangService
    {
        ICuaHangReopository _ICuaHangReopository;
        public CuaHangService()
        {
            _ICuaHangReopository = new CuaHangReopository();
        }

        public string Add(CuaHangViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var CuaHang = new CuaHang()
            {
                Ten = obj.Ten,
                Ma = obj.Ma,
                DiaChi = obj.DiaChi,
                QuocGia = obj.QuocGia,
                ThanhPho = obj.ThanhPho,
            };
            if (_ICuaHangReopository.Add(CuaHang)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var CuaHang = new CuaHang()
            {
                Id = obj,
            };
            if (_ICuaHangReopository.Delete(CuaHang)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<CuaHangViews> GetAll()
        {
            List<CuaHangViews> lst = new List<CuaHangViews>();
            lst =
                (
                from a in _ICuaHangReopository.GetAll()
                select new CuaHangViews()
                {
                    Id = a.Id,
                    Ten = a.Ten,
                    Ma = a.Ma,
                    DiaChi = a.DiaChi,
                    QuocGia = a.QuocGia,
                    ThanhPho = a.ThanhPho,
                }
                ).ToList();
            return lst;
        }

      

        public string Update(CuaHangViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var CuaHang = new CuaHang()
            {
                Id = obj.Id,
                Ten = obj.Ten,
                Ma = obj.Ma,
                DiaChi = obj.DiaChi,
                QuocGia = obj.QuocGia,
                ThanhPho = obj.ThanhPho,
            };
            if (_ICuaHangReopository.Update(CuaHang)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
