using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carService = new CarManager(new EfCarDal());
            foreach (var car in carService.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Description);
            }



        }
    }
}
