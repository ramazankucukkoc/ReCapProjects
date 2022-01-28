using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carService = new CarManager(new InMemoryCar());
            foreach (var cars in carService.GetAll())
            {
                Console.WriteLine(cars.Description);
            }


        }
    }
}
