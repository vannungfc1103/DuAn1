using _1_DAL.DomainClass;
using _1_DAL.IRespositories;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface ICTSP_Service
    {

        string Add(CTSP_Views obj);
        string Update(CTSP_Views obj);
        string Delete(Guid obj);

        List<CTSP_Views> GetAll();
        //List<SanPham> GetAllSp();
        ChiTietSanPhamViews GetById(Guid id);


    }
}
