using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorManager carService = new ColorManager(new EfColorDal());


            foreach (var cars in carService.GetCarsByColorId(1))
            {
                Console.WriteLine(cars.ColorName);
            }


        }
    }
}
