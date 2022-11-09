using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IQLSanPhamService
    {
        string Add(ChiTietSanPhamViews obj);
        string Update(ChiTietSanPhamViews obj);
        string Delete(Guid obj);
 

        List<ChiTietSanPhamViews> GetAll();
 
    }
}
