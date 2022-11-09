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
//    public class QLHoaDonCTService : IQLHoaDonCTService
//    {
//        IHoaDonChiTietRespository _IHoaDonChiTietRespository;
//        IHoaDonRespository _IHoaDonRespository;
//        IChiTietSpReopository _IChiTietSpReopository;
//        public QLHoaDonCTService()
//        {
//            _IHoaDonRespository = new HoaDonRespository();
//            _IChiTietSpReopository = new ChiTietSpReopository();
//            _IHoaDonChiTietRespository = new HoaDonChiTietRespository();
             
//        }
//        public string Add(HoaDonCTViews obj)
//        {
//            if (obj == null) return "Thêm không thành công!";
//            var HoaDonCT = obj.HoaDonChiTiet;
//            if (_IHoaDonChiTietRespository.Add(HoaDonCT)) return "Thêm  thành công!";
//            return "Thêm không thành công!";
//        }

//        public string Delete(HoaDonCTViews obj)
//        {
//            if (obj == null) return "Xóa không thành công!";
//            var HoaDonCT = obj.HoaDonChiTiet;
//            if (_IHoaDonChiTietRespository.Delete(HoaDonCT)) return "Xóa  thành công!";
//            return "Xóa không thành công!";
//        }

//        public List<HoaDonCTViews> GetAll()
//        {
//            List<HoaDonCTViews> lst = new List<HoaDonCTViews>();
//            lst = (
//                from a in _IHoaDonChiTietRespository.GetAll()
//                join b in _IHoaDonRespository.GetAll() on a.IdHoaDon equals b.Id
//                join c in _IChiTietSpReopository.GetAll() on a.IdChiTietSp equals c.Id
//                select new HoaDonCTViews()
//                {
//                    HoaDonChiTiet = a,
//                    HoaDon = b,
//                    ChiTietSp = c
//                }
//                    ).ToList();
//            return lst;
//        }

//        public ChiTietSp GetChiTietSpByID(Guid ID)
//        {
//            return _IChiTietSpReopository.GetById(ID);
//        }

//        public ChiTietSp GetChiTietSpByName(string name)
//        {
//            return _IChiTietSpReopository.GetByName(name);
//        }

//        public HoaDon GetHDByID(Guid ID)
//        {
//            return _IHoaDonRespository.GetById(ID);
//        }



//        public string Update(HoaDonCTViews obj)
//        {
//            if (obj == null) return "Sửa không thành công!";
//            var HoaDonCT = obj.HoaDonChiTiet;
//            if (_IHoaDonChiTietRespository.Update(HoaDonCT)) return "Sửa  thành công!";
//            return "Sửa không thành công!";
//        }
//    }
//}
