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
    public class DongSpReopository : IDongSpReopository
    {
        private FpolyDBContext _dbContext;
        public DongSpReopository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(DongSp obj)
        {
            if (obj == null) return false;
            _dbContext.DongSps.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<DongSp> GetAll()
        {
            return _dbContext.DongSps.ToList();
        }


        public bool Update(DongSp obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.DongSps.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
