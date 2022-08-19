using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonolithicArch.Entities.Dtos
{
    public class CarDetailDto
    {
        public int CarId { get; set; }
        public string Description { get; set; }
        public double DailyPrice { get; set; }
        public string Name { get; set; }
        public string ColorName { get; set; }
    }
}
