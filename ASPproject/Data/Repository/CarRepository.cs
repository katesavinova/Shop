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
        IEnumerable<Car> IAllCars.Cars => appDBContent.Car.Include(c => c.Category);

        IEnumerable<Car> IAllCars.GetFavCars => appDBContent.Car.Where(p=>p.isFavourite).Include(c => c.Category);

        Car IAllCars.getObjectCar(int CarId) => appDBContent.Car.FirstOrDefault(p => p.id == CarId);


    }
}
