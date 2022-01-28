using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IColorService
    {
        List<Color> GetAll();
        //List<Color> GetCarsByBrandId(int brandId);
        List<Color> GetCarsByColorId(int colorId);
    }
}
