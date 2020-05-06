using ASPproject.Data.Models.interfaces;
using ASPproject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategores;

        public CarsController(IAllCars AllCars, ICarsCategory AllCat)
        {
            _allCars = AllCars;
            _allCategores = AllCat;

        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с Автомобилями";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars=_allCars.Cars;
            obj.carCategory = "Автомобили";
            return View(obj);
        }

    }
}
