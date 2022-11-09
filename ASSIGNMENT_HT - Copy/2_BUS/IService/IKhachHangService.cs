using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IService
{
    public interface IKhachHangService
    {
        string Add(KhachHangViews obj);
        string Update(KhachHangViews obj);
        string Delete(Guid obj);
 

        List<KhachHangViews> GetAll();
    }
}
