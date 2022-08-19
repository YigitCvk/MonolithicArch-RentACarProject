using MonolithicArch.Core.Dal.EntityFramework;
using MonolithicArch.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Dal.Abstract
{
    public interface IBrandDal: IEntityRepository<Brand>
    {
    }
}
