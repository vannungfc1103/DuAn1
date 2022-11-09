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
    public class DongSpService:IDongSpService
    {
         IDongSpReopository _IDongSpReopository;
        public DongSpService()
        {
            _IDongSpReopository = new DongSpReopository();
        }

        public string Add(DongSpViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var DongSp = new DongSp()
            {
                Id = obj.Id,
                Ten = obj.Ten,
                Ma = obj.Ma,

            };
            if (_IDongSpReopository.Add(DongSp)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var DongSp = new DongSp()
            {
                Id = obj,
            };
            if (_IDongSpReopository.Delete(DongSp)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<DongSpViews> GetAll()
        {
            List<DongSpViews> lst = new List<DongSpViews>();
            lst =
                (
                from a in _IDongSpReopository.GetAll()
                select new DongSpViews()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }
                ).ToList();
            return lst;
        }

       

        public string Update(DongSpViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var DongSp = new DongSp()
            {
                Id = obj.Id,
                Ten = obj.Ten,
                Ma = obj.Ma,

            };
            if (_IDongSpReopository.Update(DongSp)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
