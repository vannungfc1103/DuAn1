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
    public class MauSacRespository : IMauSacRespository
    {
        private FpolyDBContext _dbContext;
        public MauSacRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            _dbContext.MauSacs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<MauSac> GetAll()
        {
            return _dbContext.MauSacs.ToList();
        }

     

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.MauSacs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
