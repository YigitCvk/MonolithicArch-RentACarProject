using MonolithicArch.Core.Dal.EntityFramework;
using MonolithicArch.Dal.Abstract;
using MonolithicArch.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Dal.Concrete.EntityFramework
{
    public class EfBrandDal:EfEntityRepositoryBase<Brand, RentACarContext>,IBrandDal
    {
    }
}
