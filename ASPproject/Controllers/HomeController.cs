using ASPproject.Data.Models.interfaces;
using ASPproject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPproject.Controllers
{
    public class HomeController: Controller
    {
        private  IAllCars _carRep;
       

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
         
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }
    }
}
