using MonolithicArch.Core.Utilities.Results;
using MonolithicArch.Entities.Concrete;
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
        IResult GetCarsDetails();
        IResult GetCarColorId(int id);
        Car GetById(int carId);        
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);    
    
    }
}
