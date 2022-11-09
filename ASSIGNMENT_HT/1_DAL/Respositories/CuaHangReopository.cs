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
    public class CuaHangReopository : ICuaHangReopository
    {
        private FpolyDBContext _dbContext;
        public CuaHangReopository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.CuaHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHangs.ToList();
        }
        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.CuaHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
