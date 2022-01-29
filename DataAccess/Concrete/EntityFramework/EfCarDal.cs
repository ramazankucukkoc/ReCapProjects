using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context =new CarContext())
            {
                var result = from p in context.Car
                             join c in context.Brand
                             on p.BrandId equals c.Id
                             join color in context.Color
                             on p.ColorId equals color.Id
                             select new CarDetailDto { Description = p.Description, BrandName = c.BrandName, DailyPrice = p.DailyPrice ,ColorName=color.ColorName};
                return result.ToList();
            }
        }
    }
}
