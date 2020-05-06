using System;
using ASPproject.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Models.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { set; get; }//IEnumerable=перечисление

        Car getObjectCar(int CarId);
    }
}
