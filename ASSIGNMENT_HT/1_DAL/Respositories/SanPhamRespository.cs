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
    public class SanPhamRespository : ISanPhamRespository
    {
        private FpolyDBContext _dbContext;
        public SanPhamRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(SanPham obj)
        {
            if (obj == null) return false;
            _dbContext.SanPhams.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<SanPham> GetAll()
        {
            return _dbContext.SanPhams.ToList();
        }

        public bool Update(SanPham obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.SanPhams.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
