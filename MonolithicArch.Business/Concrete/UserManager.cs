using MonolithicArch.Business.Abstract;
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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult();
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>();
        }

        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(x=>x.Id==userId));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
