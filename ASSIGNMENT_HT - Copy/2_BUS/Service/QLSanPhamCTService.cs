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
    public class QLSanPhamCTService:IQLSanPhamService
    {
        IDongSpReopository _IDongSpReopository;
        IMauSacRespository _IMauSacRespository;
        INsxRespository _INsxRespository;
        ISanPhamRespository _ISanPhamRespository;
        IChiTietSpReopository _IChiTietSpReopository;
        public QLSanPhamCTService()
        {
            _IDongSpReopository = new DongSpReopository();
            _INsxRespository = new NsxRespository();
            _IMauSacRespository = new MauSacRespository();
            _ISanPhamRespository = new SanPhamRespository();
            _IChiTietSpReopository = new ChiTietSpReopository();
        }

        public string Add(ChiTietSanPhamViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var ChiTietSp = new ChiTietSp()
            {
                IdSp = obj.IdSp,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,
                IdDongSp = obj.IdDongSp,
                IdMauSac   = obj.IdMauSac,
                IdNsx = obj.IdNsx,
                NamBh = obj.NamBh,

            };
            if (_IChiTietSpReopository.Add(ChiTietSp)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }
      
        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var ChiTietSp = new ChiTietSp()
            {
                Id = obj

            };
            if (_IChiTietSpReopository.Delete(ChiTietSp)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<ChiTietSanPhamViews> GetAll()
        {
            List<ChiTietSanPhamViews> lst = new List<ChiTietSanPhamViews>();
            lst =
                (
                from a in _IChiTietSpReopository.GetAll()
                join b in _IMauSacRespository.GetAll() on a.IdMauSac equals b.Id
                join c in _IDongSpReopository.GetAll() on a.IdDongSp equals c.Id
                join d in _INsxRespository.GetAll() on a.IdNsx equals d.Id
                join e in _ISanPhamRespository.GetAll() on a.IdSp equals e.Id
                select new ChiTietSanPhamViews()
                {
                    Id = a.Id,
                    IdSp = a.IdSp,
                    MoTa = a.MoTa,
                    SoLuongTon = a.SoLuongTon,
                    GiaBan = a.GiaBan,
                    GiaNhap = a.GiaNhap,
                    IdDongSp = a.IdDongSp,
                    IdMauSac = a.IdMauSac,
                    IdNsx = a.IdNsx,
                    NamBh = a.NamBh,
                    TenMauSac = b.Ten,
                    TenDongSp = c.Ten,
                    TenNsx=d.Ten,
                    TenSp = e.Ten,
                    
                   
                }
                ).ToList();
            return lst;
        }
       

        public string Update(ChiTietSanPhamViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var ChiTietSp = new ChiTietSp()
            {
                Id = obj.Id,
                IdSp = obj.IdSp,
                MoTa = obj.MoTa,
                SoLuongTon = obj.SoLuongTon,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,
                IdDongSp = obj.IdDongSp,
                IdMauSac = obj.IdMauSac,
                IdNsx = obj.IdNsx,
                NamBh = obj.NamBh,

            };
            if (_IChiTietSpReopository.Update(ChiTietSp)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }

       
    }
}
