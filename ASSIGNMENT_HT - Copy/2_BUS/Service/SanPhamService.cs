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
    public class SanPhamService : ISanPhamService
    {
        ISanPhamRespository _ISanPhamRespository;
        public SanPhamService()
        {
            _ISanPhamRespository = new SanPhamRespository();
        }
        public string Add(SanPhamView obj)
        {
            if (obj == null)
            {
                return "Thêm thất bại";
            }
            else
            {
                SanPham c = new SanPham()
                {
                    Ma = obj.Ma,    
                    Ten = obj.Ten
                };
                _ISanPhamRespository.Add(c);
                return "Thêm thành công";
            }
        }

        public string Delete(Guid obj)
        {

            if (obj == null)
            {
                return "Xóa thất bại";
            }
            else
            {
                SanPham c = new SanPham()
                {
                    Id = obj,

                };
                _ISanPhamRespository.Delete(c);
                return "Xóa thành công";
            }
        }

        public List<SanPhamView> GetAll()
        {
            List<SanPhamView> c = new List<SanPhamView>
            (
                from a in _ISanPhamRespository.GetAll()
                select new SanPhamView()
                {
                    Id=a.Id,
                    Ten = a.Ten,
                    Ma = a.Ma
                });
            return c;
        }



        public string Update(SanPhamView obj)
        {

            if (obj == null)
            {
                return "Sửa thất bại";
            }
            else
            {
                SanPham c = new SanPham()
                {
                    Id = obj.Id,
                    Ma = obj.Ma,
                    Ten = obj.Ten
                };
                _ISanPhamRespository.Update(c);
                return "Sửa thành công";
            }
        }
    }
}
