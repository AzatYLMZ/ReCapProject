﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka başarılı bir şekilde eklenmiştir.");
            }
            else
            {
                Console.WriteLine($"Araba ismi minimum 2 karakter olmalıdır.Girdiğin marka ismi : {brand.BrandName}");
            }
            
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarılı bir şekilde silindi.");
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(c => c.BrandId == id);
        }

        public void Update(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka başarılı bir şekilde güncellenmiştir.");
            }
            else
            {
                Console.WriteLine($"Araba ismi minimum 2 karakter olmalıdır.Girdiğin marka ismi : {brand.BrandName}");
            }

        }
    }
}