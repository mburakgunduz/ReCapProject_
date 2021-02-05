using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        IBrandDal _brandDal;
        IColorDal _colorDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Brand> GetCarsByBrandId(int id)
        {
            return _brandDal.GetAll(p => p.Id == id);
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorDal.GetAll(p => p.Id == id);
        }
    }
}
