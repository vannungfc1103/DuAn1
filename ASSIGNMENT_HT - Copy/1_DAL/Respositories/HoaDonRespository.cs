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
    public class HoaDonRespository : IHoaDonRespository
    {
        private FpolyDBContext _dbContext;
        public HoaDonRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(HoaDon obj)
        {
            if (obj == null) return false;
            _dbContext.HoaDons.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<HoaDon> GetAll()
        {
            return _dbContext.HoaDons.ToList();
        }

  
        public bool Update(HoaDon obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.HoaDons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdKh = obj.IdKh;
            tempobj.IdNv = obj.IdNv;
            tempobj.Ma = obj.Ma;
            tempobj.NgayTao = obj.NgayTao;
            tempobj.NgayThanhToan = obj.NgayThanhToan;
            tempobj.NgayShip = obj.NgayShip;
            tempobj.NgayNhan = obj.NgayNhan;
            tempobj.TinhTrang = obj.TinhTrang;
            tempobj.TenNguoiNhan = obj.TenNguoiNhan;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
