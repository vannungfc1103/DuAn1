using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using _1_DAL.Respositories;
using _2_BUS.IService;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2_BUS.Service
{
    public class ChucVuService : IChucVuService
    {
        IChucVuReopository _IChucVuReopository;
        public ChucVuService()
        {
            _IChucVuReopository = new ChucVuReopository();
        }

        public string Add(ChucVuViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var ChucVu = new ChucVu()
            {
                Ten = obj.Ten,
                Ma = obj.Ma,
            };
            if (_IChucVuReopository.Add(ChucVu)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var ChucVu = new ChucVu()
            {
                Id = obj,
            };
            if (_IChucVuReopository.Delete(ChucVu)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<ChucVuViews> GetAll()
        {
            List < ChucVuViews > lst = new List<ChucVuViews> ();
            lst =
                (
                from a in _IChucVuReopository.GetAll()
                select new ChucVuViews()
                {
                    Id = a.Id,
                    Ten = a.Ten,
                    Ma = a.Ma,
                }
                ).ToList();
            return lst;
        }





        public string Update(ChucVuViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var ChucVu = new ChucVu()
            {
                Id = obj.Id,
                Ten = obj.Ten,
                Ma = obj.Ma,

            };
            if (_IChucVuReopository.Update(ChucVu)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
