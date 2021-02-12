using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    
   public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;
        public InMemoryColorDal()
        {
            _colors = new List<Color>
            {
                
                new Color{Id = 1, Name= "Siyah"},
                new Color{Id = 2, Name = "Beyaz"},
                new Color{Id = 3, Name = "Mavi"}
            };

        }
        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> flter)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> flter = null)
        {
            return _colors;
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
