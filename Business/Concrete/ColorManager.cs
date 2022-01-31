using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
  public  class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colors)
        {
            _colorDal = colors;
        }
        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }
        public List<Color> GetCarsByColorId(int colorId)
        {
            return _colorDal.GetAll(c => c.Id == colorId);
        }
    }
}
