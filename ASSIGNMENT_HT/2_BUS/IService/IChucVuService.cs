using _1_DAL.DomainClass;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IChucVuService
    {
        string Add(ChucVuViews obj);
        string Update(ChucVuViews obj);
        string Delete(Guid obj);

        List<ChucVuViews> GetAll();
    }
}
