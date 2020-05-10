using ASPproject.Data.Models;
using ASPproject.Data.Models.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Repository
{
    public class CarRepository : IAllCars
    {

        private AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

        public IEnumerable<Car>GetFavCars => appDBContent.Car.Where(p=>p.isFavourite).Include(c => c.Category);

        public Car getObjectCar(int CarId) => appDBContent.Car.FirstOrDefault(p => p.id == CarId);


    }
}
