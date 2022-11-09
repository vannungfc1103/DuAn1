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
    public class NsxRespository : INsxRespository
    {
        private FpolyDBContext _dbContext;
        public NsxRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null) return false;
            _dbContext.Nsxes.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }

        public List<Nsx> GetAll()
        {
            return _dbContext.Nsxes.ToList();
        }

        public bool Update(Nsx obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.Nsxes.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
