using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using _1_DAL.Respositories;
using _2_BUS.IService;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Service
{
    public class CTSP_Service : ICTSP_Service
    {
        IChiTietSpReopository _IChiTietSpReopository;
        ISanPhamRespository _ISanPhamRespository;
        
        public CTSP_Service()
        {
            _IChiTietSpReopository = new ChiTietSpReopository();
            _ISanPhamRespository = new SanPhamRespository();
        }
        public string Add(CTSP_Views obj)
        {
            if (obj==null)
            {
                return "Thêm thất bại";
            }
            else
            {
                ChiTietSp c = new ChiTietSp()
                {

                    IdSp = obj.IdSp,
                    MoTa = obj.MoTa,
                    SoLuongTon = obj.SoLuongTon,
                    GiaBan = obj.GiaBan,
                    GiaNhap = obj.GiaNhap,
                };
                _IChiTietSpReopository.Add(c);
                return "Thêm thành công";
            }
        }

        public string Delete(Guid obj)
        {
            if (obj == null)
            {
                return "Xóa thất bại";
            }
            else
            {
                var x = _IChiTietSpReopository.GetAll().FirstOrDefault(c => c.Id == obj);
                _IChiTietSpReopository.Delete(x);
                return "Xóa thành công";

            }
        }

        public List<CTSP_Views> GetAll()
        {
            List<CTSP_Views> lst = new List<CTSP_Views>(
                                from a in _IChiTietSpReopository.GetAll()
                                join b in _ISanPhamRespository.GetAll() on a.IdSp equals b.Id
                                select new CTSP_Views()
                                {
                                    Id = a.Id,
                                    IdSp= a.IdSp,
                                    MoTa = a.MoTa,
                                    TenSp = b.Ten,
                                    SoLuongTon = a.SoLuongTon,
                                    GiaNhap = a.GiaNhap,
                                    GiaBan = a.GiaBan,
                                    GiaTriTon = a.GiaNhap*a.SoLuongTon,
                                }).ToList();
            return lst;
        }



        public ChiTietSanPhamViews GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(CTSP_Views obj)
        {
                var x = _IChiTietSpReopository.GetAll().FirstOrDefault(c => c.Id == obj.Id);
                x.IdSp = obj.IdSp;
                x.MoTa = obj.MoTa;
                x.SoLuongTon = obj.SoLuongTon;
                x.GiaBan = obj.GiaBan;
                x.GiaNhap = obj.GiaNhap;
                _IChiTietSpReopository.Update(x);
                return "Sửa thành công";
        }
    }
}
