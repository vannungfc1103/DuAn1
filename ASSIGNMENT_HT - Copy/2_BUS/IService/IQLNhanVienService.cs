using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IQLNhanVienService
    {
        string Add(NhanVienViews obj);
        string Update(NhanVienViews obj);
        string Delete(Guid obj);
 
        List<NhanVienViews> GetAll();
    }
}
