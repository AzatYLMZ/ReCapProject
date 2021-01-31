using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> cars;
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car {Id = 1,BrandId="BMW",ColorId=1,ModelYear=2021,DailyPrice=85000,Decription="Manuel,Benzinli"},
                new Car {Id = 2,BrandId="BMW",ColorId=2,ModelYear=2021,DailyPrice=105000,Decription="otomatik,Diesel"},
                new Car {Id = 3,BrandId="Mercedes",ColorId=2,ModelYear=2021,DailyPrice=135000,Decription="Otomatik,Benzinli"},
                new Car {Id = 4,BrandId="Mercedes",ColorId=3,ModelYear=2021,DailyPrice=75000,Decription="Manuel,Diesel"},
                new Car {Id = 5,BrandId="Audi",ColorId=3,ModelYear=2021,DailyPrice=85000,Decription="Manuel,Benzinli"}
            };
        }
        public List<Car> GetAll()
        {
            return _cars;
        }


        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
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

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Decription = car.Decription;
        }

       
    }
}
