using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.EntitiyFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from ca in filter is null ?context.Cars : context.Cars.Where(filter)
                             join co in context.Colors
                             on ca.ColorId equals co.Id
                             join b in context.Brands
                             on ca.BrandId equals b.Id

                             select new CarDetailDto
                             {
                                 Id = ca.Id,
                                 BrandId = b.Id,
                                 BrandName = b.Name,
                                 Name = ca.Name,
                                 ColorId = co.Id,
                                 ColorName = co.Name,
                                 DailyPrice = ca.DailyPrice,
                                 Descriptions = ca.Descriptions,
                                 ModelYear = ca.ModelYear
                             };

            
                return result.ToList();
            }
        }
    }
}
