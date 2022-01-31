using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            // CarTest();
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var carservice in carManager.GetCarDetailDto())
            //{
            //    Console.WriteLine(carservice.DailyPrice);
            //}
            RentalManager rentalManager  = new RentalManager(new EfRentalDal());
            var date1 = new DateTime(2022, 5, 1, 8, 30, 52);
            var date2 = new DateTime(2021, 5, 1, 8, 30, 52);
            rentalManager.Add(new Rentals
            {
                CustomerId = 5,
                CarId = 7,
                RentDate = date1,
                ReturnDate = date2
            }) ;

            // GetAll(usersManager);
            //usersManager.Update(new Users
            //{
            //    Id=5,
            //    FirstName="Ihsan",
            //    LastName="Kaplan",
            //    Email="ihsankpln@hotmail.com",
            //    Password="199442"

            //});

            //  Delete(usersManager);
            //Add(usersManager);

        }

        private static void GetAll(UsersManager usersManager)
        {
            foreach (var item in usersManager.GetAll().Data)
            {
                Console.WriteLine("Id=" + item.Id + " Isim= " + item.FirstName + " Soyad= " + item.LastName + " Şifre=" + item.Password + " Email=" + item.Email);
            }
        }

        private static void Delete(UsersManager usersManager)
        {
            usersManager.Delete(new Users
            {
                Id = 1,
                FirstName = "Ramazan",
                LastName = "Küçükkoç",
                Email = "ramazankucukkoc43@gmail.com",
                Password = "12345"
            });
        }

        private static void Add(UsersManager usersManager)
        {
            
            usersManager.Add(new Users
            {
                FirstName = "Ramazan",
                LastName = "Küçükkoç",
                Email = "ramazankucukkoc43@gmail.com",
                Password = "12345"
            });
            usersManager.Add(new Users
            {
                FirstName = "Ali",
                LastName = "Küçükkoç",
                Email = "alikckkc01@gmail.com",
                Password = "1988"
            });
        }

        //private static void CarTest()
        //{
        //    CarManager carService = new CarManager(new EfCarDal());
        //    foreach (var car in carService.GetCarsByColorId(3))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}
