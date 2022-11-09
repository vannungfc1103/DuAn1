using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface INsxService
    {

        string Add(NsxViews obj);
        string Update(NsxViews obj);
        string Delete(Guid obj);
 
        List<NsxViews> GetAll();
    }
}
