using MonolithicArch.Business.Abstract;
using MonolithicArch.Core.Utilities.Results;
using MonolithicArch.Dal.Abstract;
using MonolithicArch.Entities.Concrete;
using MonolithicArch.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult();
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public Car GetById(int carId)
        {
            return _carDal.Get(c=>c.Id==carId);
        }

        public IResult GetCarColorId(int id)
        {
             _carDal.GetCarsColorDetail(x=>x.ColorId==id).ToList();
            return new SuccessResult();
        }

        public IResult GetCarsDetails()
        {
              _carDal.GetCarDetails();
            return new SuccessResult();
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult();
        }
    }
}