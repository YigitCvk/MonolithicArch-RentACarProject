using MonolithicArch.Business.Abstract;
using MonolithicArch.Business.Constants;
using MonolithicArch.Core.Utilities.Results;
using MonolithicArch.Dal.Abstract;
using MonolithicArch.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);

            if (result == null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult();
            }
            return new ErrorResult(Messages.CarAlreadyRented);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }
    }
}
