using Business.Abstract;
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
            CarAddTest();
            ColorTest();
            RentalAddTest();
            CustomerAddTest();
            UserAddTest();
            CarGetAllTest();
            GetCarDetailsTest();
            CarDeleteTest();

        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Delete(new Car
            {
                Id = 7007,
                BrandId = 4,
                Name = "BMW",
                ColorId = 4,
                ModelYear = 2020,
                Descriptions = "Hybrid",
                DailyPrice = 15
            });
        }

        private static void GetCarDetailsTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Get Car Details Test");
            Console.ResetColor();
            Console.WriteLine("------------------");
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Car Id : " + car.Id + "\nBrand Name : " + car.BrandName +
                        "\nColor Name : " + car.ColorName + "\nDaily Price : " + car.DailyPrice);

                    Console.WriteLine("********************************");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarGetAllTest()
        {
            Console.WriteLine("------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Car GetAll Test");
            Console.ResetColor();
            Console.WriteLine("------------------");
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine("{0}--------{1}---------{2}-------{3}",car.Name,car.ModelYear,car.ModelYear,car.Descriptions);
            }
        }

        private static void UserAddTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Berat",
                LastName = "Yılmaz",
                Email = "BrtYlmz@gmail.com",
                Password = "12345"
            });
        }

        private static void CustomerAddTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                UserId = 2,
                CompanyName = "Azt A.Ş"
            });
        }

        private static void RentalAddTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 2, 12),
            });

            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
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
                Console.WriteLine(brand.Name);
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
                Console.WriteLine(color.Name);
            }
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            carManager.Add(new Car
            {
                BrandId = 4,
                Name = "BMW",
                ColorId = 4,
                ModelYear = 2020,
                Descriptions = "Hybrid",
                DailyPrice = 15
            });

        }

    }
}
