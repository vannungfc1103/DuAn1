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
using System.Xml.Linq;


namespace _2_BUS.Service
{

    public class QLNhanVienService:IQLNhanVienService
    {
        INhanVienRespository _INhanVienRespository;
        IChucVuReopository _IChucVuReopository;
        ICuaHangReopository _ICuaHangReopository;
        public QLNhanVienService()
        {
            _INhanVienRespository = new NhanVienRespository();
            _IChucVuReopository = new ChucVuReopository();
            _ICuaHangReopository = new CuaHangReopository();
        }

        public string Add(NhanVienViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var NhanVien = new NhanVien()
            {
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                Ma = obj.Ma,
                DiaChi = obj.DiaChi,
                NgaySinh = obj.NgaySinh,
                GioiTinh = obj.GioiTinh,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                TrangThai = obj.TrangThai,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdGuiBc = obj.IdGuiBc,

            };
            if (_INhanVienRespository.Add(NhanVien)) return "Thêm thành công!";
            return "Thêm không thành công";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var NhanVien = new NhanVien()
            {
                Id = obj
            };
            if (_INhanVienRespository.Delete(NhanVien)) return "Xóa thành công!";
            return "Xóa không thành công";
        }

        public List<NhanVienViews> GetAll()
        {
            List<NhanVienViews> lst = new List<NhanVienViews>();
            lst =
                (
                from a in _INhanVienRespository.GetAll()
                join b in _ICuaHangReopository.GetAll() on a.IdCh equals b.Id
                join c in _IChucVuReopository.GetAll() on a.IdCv equals c.Id

                select new NhanVienViews()
                {
                    Id = a.Id,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    Ma = a.Ma,
                    DiaChi = a.DiaChi,
                    NgaySinh = a.NgaySinh,
                    GioiTinh = a.GioiTinh,
                    IdCh = a.IdCh,
                    IdCv = a.IdCv,
                    TrangThai = a.TrangThai,
                    Sdt = a.Sdt,
                    MatKhau = a.MatKhau,
                    TenCH = b.Ten,
                    TenCV = c.Ten,
                    IdGuiBc = a.IdGuiBc
                }
                ).ToList();
            return lst;
        }
     

        public string Update(NhanVienViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var NhanVien = new NhanVien()
            {
                Id = obj.Id,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                Ho = obj.Ho,
                Ma = obj.Ma,
                DiaChi = obj.DiaChi,
                NgaySinh = obj.NgaySinh,
                GioiTinh = obj.GioiTinh,
                IdCh = obj.IdCh,
                IdCv = obj.IdCv,
                TrangThai = obj.TrangThai,
                Sdt = obj.Sdt,
                MatKhau = obj.MatKhau,
                IdGuiBc = obj.IdGuiBc,

            };
            if (_INhanVienRespository.Update(NhanVien)) return "Sửa thành công!";
            return "Sửa không thành công";
        }
    }
}
