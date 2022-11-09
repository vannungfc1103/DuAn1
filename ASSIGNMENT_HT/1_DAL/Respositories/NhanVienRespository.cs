using _1_DAL.Context;
using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1_DAL.Respositories
{
    public class NhanVienRespository : INhanVienRespository
    {
        private FpolyDBContext _dbContext;
        public NhanVienRespository()
        {
            _dbContext = new FpolyDBContext();
        }
        public bool Add(NhanVien obj)
        {
            if (obj == null) return false;
            _dbContext.NhanViens.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }
        public List<NhanVien> GetAll()
        {
            return _dbContext.NhanViens.ToList();
        }
        public bool Delete(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            _dbContext.Remove(tempobj);
            _dbContext.SaveChanges();
            return true;
        }
        public bool Update(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _dbContext.NhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Ma = obj.Ma;
            tempobj.Ten = obj.Ten;
            tempobj.TenDem = obj.TenDem;
            tempobj.Ho = obj.Ho;
            tempobj.GioiTinh = obj.GioiTinh;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.MatKhau = obj.MatKhau;
            tempobj.IdCh = obj.IdCh;
            tempobj.IdCv = obj.IdCv;
            //tempobj.IdGuiBc = obj.IdGuiBc;
            tempobj.TrangThai = obj.TrangThai;
            _dbContext.Update(tempobj);
            _dbContext.SaveChanges();
            return true;
        }

        public NhanVien GetByMaNv(string Ma)
        {
            if (Ma == "") return null;
            return _dbContext.NhanViens.FirstOrDefault(c => c.Ma.ToLower() == Ma.ToLower());
        }
    }
}
