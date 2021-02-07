using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car {Id = 1,BrandId=1,ColorId=1,ModelYear="2021",DailyPrice=85000,Descriptions="Manuel,Benzinli"},
                new Car {Id = 2,BrandId=1,ColorId=2,ModelYear="2021",DailyPrice=105000,Descriptions="otomatik,Diesel"},
                new Car {Id = 3,BrandId=2,ColorId=2,ModelYear="2021",DailyPrice=135000,Descriptions="Otomatik,Benzinli"},
                new Car {Id = 4,BrandId=2,ColorId=3,ModelYear="2021",DailyPrice=75000,Descriptions="Manuel,Diesel"},
                new Car {Id = 5,BrandId=3,ColorId=3,ModelYear="2021",DailyPrice=85000,Descriptions="Manuel,Benzinli"}
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
            carToUpdate.Descriptions = car.Descriptions;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> flter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> flter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
