using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IQLHoaDonService
    {
        string Add(HoaDonViews obj);
        string Update(HoaDonViews obj);
        string Delete(Guid obj);
 

        List<HoaDonViews> GetAll();
    }
}

