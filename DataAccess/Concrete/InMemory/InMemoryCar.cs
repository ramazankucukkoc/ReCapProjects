using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCar : ICarDal
    {
        List<Car> _cars;
        public InMemoryCar()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=3,DailyPrice=30000,ModelYear=2022,Description="BMW"},
                new Car{Id=1,BrandId=1,ColorId=2,DailyPrice=50000,ModelYear=2021,Description="MERCEDES"},
                new Car{Id=1,BrandId=1,ColorId=0,DailyPrice=70000,ModelYear=2012,Description="WOLSKWAGEN"},
                new Car{Id=1,BrandId=1,ColorId=3,DailyPrice=120000,ModelYear=2015,Description="NISSAN"},
                new Car{Id=1,BrandId=1,ColorId=9,DailyPrice=140000,ModelYear=2018,Description="FORD"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(int id)
        {
            return _cars.Where(c => c.BrandId == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
