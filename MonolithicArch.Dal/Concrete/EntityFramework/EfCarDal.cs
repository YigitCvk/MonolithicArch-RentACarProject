using MonolithicArch.Core.Dal.EntityFramework;
using MonolithicArch.Dal.Abstract;
using MonolithicArch.Entities.Concrete;
using MonolithicArch.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Dal.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 Description = c.Description,
                                 Name = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }

        }

        public List<CarDetailDto> GetCarsColorDetail()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Cars
                             join c1 in context.Colors
                             on c.ColorId equals c1.ColorId
                             select new CarDetailDto
                             {
                                 ColorName = c1.ColorName,
                                 

                             };
                return result.ToList();

            }
        }
    }
}
