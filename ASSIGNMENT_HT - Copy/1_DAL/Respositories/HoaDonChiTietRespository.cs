using _1_DAL.Context;
using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Respositories
{
    public class HoaDonChiTietRespository : IHoaDonChiTietRespository
    {
        private FpolyDBContext _dbContext;
        public HoaDonChiTietRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.HoaDonChiTiets.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiets.ToList();
        }


        public bool Update(HoaDonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDonChiTiets.FirstOrDefault(c => c.IdHoaDon == obj.IdHoaDon);
            tempobj.IdChiTietSp = obj.IdChiTietSp;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DonGia = obj.DonGia;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
