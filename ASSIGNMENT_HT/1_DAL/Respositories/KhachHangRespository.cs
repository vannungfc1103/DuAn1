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
    public class KhachHangRespository : IKhachHangRespository
    {
        private FpolyDBContext _dbContext;
        public KhachHangRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(KhachHang obj)
        {
            if (obj == null) return false;
            _dbContext.KhachHangs.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;

        }



        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHangs.ToList();
        }


        public bool Update(KhachHang obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.KhachHangs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.ThanhPho = obj.ThanhPho;
            tempobj.QuocGia = obj.QuocGia;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }



    }
}
