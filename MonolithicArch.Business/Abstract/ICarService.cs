using MonolithicArch.Core.Utilities.Results;
using MonolithicArch.Entities.Concrete;
using MonolithicArch.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

    }
}
