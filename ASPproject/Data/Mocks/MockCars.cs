using ASPproject.Data.Models;
using ASPproject.Data.Models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars=new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        name="Tesla Model S 2013- г. ",
                        shortDesc="Быстрый автомобиль",
                        longDesc="Спортивный электромобиль, автомобиль фирмы Tesla.",
                        img="/img/tesla.jpg",
                        price=45000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.First()
                    },
                    new Car
                    {
                        name="Mazda 6",
                        shortDesc="японская компания-производитель автомобильной техники",
                        longDesc="Японская автомобилестроительная компания, выпускающая автомобили «Мазда». " +
                        "Штаб-квартира расположена в посёлке Футю, уезд Аки, префектура Хиросима, Япония.",
                        img="/img/mazda.jpg",
                        price=39990,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    },
                    new Car
                    {
                        name="Форд Мустанг 2015",
                        shortDesc="японская компания-производитель автомобильной техники",
                        longDesc="Культовый автомобиль класса Pony Car производства Ford Motor Company. " +
                        "На автомобиле размещается не эмблема Ford, а специальная эмблема Mustang",
                        img="/img/mustang.jpg",
                        price=21000,
                        isFavourite=true,
                        available=true,
                        Category=_categoryCars.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set; }

        public Car getObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
