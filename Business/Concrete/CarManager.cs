using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete.InMemory;
using Entities.Concrete.DTOs;
using Core.Entities.Utilities.Results;
using Business.Constants;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carsDal;

        public CarManager(ICarDal cars)
        {
            _carsDal = cars;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length < 2)
            {
                //magic strings
                return new ErrorResult(Messages.CarNameInvalid);
            }
            _carsDal.Add(car);
            return new SuccessResult("Ürün Eklendi");
        }
        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult< List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carsDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult< List<CarDetailDto>> GetCarDetail()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carsDal.GetCarDetails());
        }

        public IDataResult< List<Car> >GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>( _carsDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult< List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>( _carsDal.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
