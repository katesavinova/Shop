using ASPproject.Data.Models;
using ASPproject.Data.Models.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{categoreName="Электромобили", desc="Современный вид транспорта"},
                    new Category{categoreName="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}
                };
            }

        }

       
    }
}
