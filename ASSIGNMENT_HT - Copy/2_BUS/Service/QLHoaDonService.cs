//using _1_DAL.DomainClass;
//using _1_DAL.IRespositories;
//using _1_DAL.Respositories;
//using _2_BUS.IService;
//using _2_BUS.ViewModels;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _2_BUS.Service
//{
//    public class QLHoaDonService : IQLHoaDonService
//    {
//        IHoaDonRespository _IHoaDonRespository;
//        IKhachHangRespository _IKhachHangRespository;
//        INhanVienRespository _INhanVienRespository;
//        public QLHoaDonService()
//        {
//            _IHoaDonRespository = new HoaDonRespository();
//            _IKhachHangRespository = new KhachHangRespository();
//            _INhanVienRespository = new NhanVienRespository();
//        }
//        public string Add(HoaDonViews obj)
//        {

//            if (obj == null) return "Thêm không thành công!";
//            var HoaDon  = obj.HoaDon;
//            if (_IHoaDonRespository.Add(HoaDon)) return "Thêm  thành công!";
//            return "Thêm không thành công!";
//        }

//        public string Delete(HoaDonViews obj)
//        {
//            if (obj == null) return "Xóa không thành công!";
//            var HoaDon = obj.HoaDon;
//            if (_IHoaDonRespository.Delete(HoaDon)) return "Xóa  thành công!";
//            return "Xóa không thành công!";
//        }

//        public List<HoaDonViews> GetAll()
//        {
//            List<HoaDonViews> lst = new List<HoaDonViews>();
//            lst =
//                (
//                from a in _IHoaDonRespository.GetAll()
//                join b in _IKhachHangRespository.GetAll() on a.IdKh equals b.Id
//                join c in _INhanVienRespository.GetAll() on a.IdNv equals c.Id
//                select new HoaDonViews()
//                {
//                    HoaDon = a,
//                    KhachHang = b,
//                    NhanVien  = c
//                }
//                ).ToList();
//            return lst;
//        }

//        public HoaDon GetHDByID(Guid ID)
//        {
//            return _IHoaDonRespository.GetById(ID);
//        }


//        public KhachHang GetKHByID(Guid ID)
//        {
//            return _IKhachHangRespository.GetById(ID);
//        }

//        public KhachHang GetKHByName(string name)
//        {
//            return _IKhachHangRespository.GetByName(name);
//        }

//        public NhanVien GetNVByID(Guid ID)
//        {
//            return _INhanVienRespository.GetById(ID);
//        }

//        public NhanVien GetNVByName(string name)
//        {
//            return _INhanVienRespository.GetByname(name);
//        }

//        public string Update(HoaDonViews obj)
//        {
           
//            if (obj == null) return "Sửa không thành công!";
//            var HoaDon = obj.HoaDon;
//            if (_IHoaDonRespository.Update(HoaDon)) return "Sửa  thành công!";
//            return "Sửa không thành công!";
//        }
//    }
//}
