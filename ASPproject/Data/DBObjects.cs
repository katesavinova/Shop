using ASPproject.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ASPproject.Data
{
    public class DBObjects
    {
        public static void Initial (AppDBContent content)
        {
            
            if (!content.Category.Any())
            content.Category.AddRange(Categories.Select(c=>c.Value));

            if (!content.Car.Any())
            {

                content.AddRange(

                    new Car
                    {
                        name = "Tesla Model S 2013- г. ",
                        shortDesc = "Быстрый автомобиль",
                        longDesc = "Спортивный электромобиль, автомобиль фирмы Tesla.",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Mazda 6",
                        shortDesc = "японская компания-производитель автомобильной техники",
                        longDesc = "Японская автомобилестроительная компания, выпускающая автомобили «Мазда». " +
                        "Штаб-квартира расположена в посёлке Футю, уезд Аки, префектура Хиросима, Япония.",
                        img = "/img/mazda.jpg",
                        price = 39990,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Форд Мустанг 2015",
                        shortDesc = "японская компания-производитель автомобильной техники",
                        longDesc = "Культовый автомобиль класса Pony Car производства Ford Motor Company. " +
                        "На автомобиле размещается не эмблема Ford, а специальная эмблема Mustang",
                        img = "/img/mustang.jpg",
                        price = 21000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }

                );

            }
            content.SaveChanges();
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category==null) 
                {
                    var list = new Category[]
                    {
                         new Category{categoreName="Электромобили", desc="Современный вид транспорта"},
                         new Category{categoreName="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoreName, el);
                    }
                        
                }
                return category;
            }
        }
    }
}
