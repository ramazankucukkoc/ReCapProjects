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

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carsDal;

        public CarManager(ICarDal cars)
        {
            _carsDal = cars;
        }

        public void Add(Car car)
        {
            if (car.Description.Length<2)
            {
                Console.WriteLine("İki kelimden küçük olamaza");
            }
            else if (car.DailyPrice<=0)
            {
                Console.WriteLine("Günlük kazançlar 0'dan küçük olamaz");
            }
            else
            {
                Console.WriteLine("Koşullarına uymuştur");
                _carsDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carsDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetailDto()
        {
            return _carsDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carsDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carsDal.GetAll(c => c.ColorId == colorId);
        }

        
    }
}
