using _1_DAL.Context;
using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Respositories
{
    public class ChiTietSpReopository : IChiTietSpReopository
    {
        private FpolyDBContext _dbContext;
        public ChiTietSpReopository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(ChiTietSp obj)
        {
            if (obj == null) return false;
            _dbContext.ChiTietSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSp obj)
        {

            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<ChiTietSp> GetAll()
        {
            return _dbContext.ChiTietSps.ToList();
        }

        public bool Update(ChiTietSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.ChiTietSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdSp = obj.IdSp;
            tempobj.IdNsx = obj.IdNsx;
            tempobj.IdMauSac = obj.IdMauSac;
            tempobj.IdDongSp = obj.IdDongSp;
            tempobj.NamBh = obj.NamBh;
            tempobj.MoTa = obj.MoTa;
            tempobj.SoLuongTon = obj.SoLuongTon;
            tempobj.GiaNhap = obj.GiaNhap;
            tempobj.GiaBan = obj.GiaBan;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
