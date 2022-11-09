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
    public class NsxService:INsxService
    {
        INsxRespository _INsxRespository;
        public NsxService()
        {
            _INsxRespository = new NsxRespository();
        }

        public string Add(NsxViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var Nsx = new Nsx()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_INsxRespository.Add(Nsx)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var Nsx = new Nsx()
            {
                Id = obj,
            };
            if (_INsxRespository.Delete(Nsx)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<NsxViews> GetAll()
        {
            List<NsxViews> lst = new List<NsxViews>();
            lst =
                (
                from a in _INsxRespository.GetAll()
                select new NsxViews()
                {
                    Id = a.Id,
                    Ten = a.Ten,
                    Ma = a.Ma
                }
                ).ToList();
            return lst;
        }

        public string Update(NsxViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var Nsx = new Nsx()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_INsxRespository.Update(Nsx)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
