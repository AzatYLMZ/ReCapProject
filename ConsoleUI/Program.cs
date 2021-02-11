using Business.Concrate;
using DataAccess.Concrate.EntitiyFramework;
using DataAccess.Concrate.InMemory;
using Entities.Concrate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandTest();
            CarTest();
            ColorTest();

        }

        private static void BrandTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Brand Test");
            Console.ResetColor();
            Console.WriteLine("------------------");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Color Test");
            Console.ResetColor();
            Console.WriteLine("------------------");

            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car Test");
            Console.ResetColor();
            Console.WriteLine("------------------");

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {

                foreach (var car in result.Data)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(car.CarName + " --/-- " + car.BrandName + " --/-- " + car.ColorName + " --/-- " + car.DailyPrice);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.WriteLine(result.Messsage);
            }

            
            
            Car car1 = new Car();
            car1.BrandId = 2;
            car1.ColorId = 3;
            car1.DailyPrice = 150;
            car1.Descriptions = "Otomatik , Diesel";

            var result1 = carManager.Add(car1);
            if (result1.Success)
                Console.WriteLine(result1.Messsage);
            else
                Console.WriteLine(result1.Messsage);
        }

    }
}
