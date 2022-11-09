using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IDongSpService
    {
        string Add(DongSpViews obj);
        string Update(DongSpViews obj);
        string Delete(Guid obj);
 

        List<DongSpViews> GetAll();
    }
}
