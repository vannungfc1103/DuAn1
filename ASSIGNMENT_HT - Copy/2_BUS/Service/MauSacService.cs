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
    public class MauSacService:IMauSacService
    {
        
        IMauSacRespository _IMauSacRespository;
        public MauSacService()
        {
            _IMauSacRespository = new MauSacRespository();
        }

        public string Add(MauSacViews obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var MauSac = new MauSac()
            {
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_IMauSacRespository.Add(MauSac)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public string Delete(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            var MauSac =new MauSac()
            {
                Id = obj,
              
            };
            if (_IMauSacRespository.Delete(MauSac)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public List<MauSacViews> GetAll()
        {
            List<MauSacViews> lst = new List<MauSacViews>();
            lst =
                (
                from a in _IMauSacRespository.GetAll()
                select new MauSacViews()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                }
                ).ToList();
            return lst;
        }


        public string Update(MauSacViews obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var MauSac =  new MauSac()
            {
                Id  =obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            if (_IMauSacRespository.Update(MauSac)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
