using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=35331,ModelYear=1995,DailyPrice=80,Description="D-class comfortable sedan"},
                new Car{Id=2,BrandId=2,ColorId=88931,ModelYear=2005,DailyPrice=100,Description="SUV"},
                new Car{Id=3,BrandId=2,ColorId=10031,ModelYear=2020,DailyPrice=250,Description="Supersport"},
                new Car{Id=4,BrandId=3,ColorId=31131,ModelYear=2019,DailyPrice=230,Description="Electrical Car"},
                new Car{Id=5,BrandId=5,ColorId=00331,ModelYear=2018,DailyPrice=210,Description="C-class hatchback"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.ModelYear= car.ModelYear;
            carToUptade.DailyPrice = car.DailyPrice;
            carToUptade.Description = car.Description;


        }
    }
}
