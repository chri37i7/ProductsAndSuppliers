using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ProductsAndSuppliers.Entities;
using ProductsAndSuppliers.Services;

namespace ProductsAndSuppliers.WebApp.Controllers
{
    public class CoronaController : Controller
    {
        protected readonly CoronaService service;

        public CoronaController()
        {
            service = new CoronaService();
        }

        // GET: CoronaController
        public virtual async Task<ActionResult> Index()
        {
            //IEnumerable<Corona> countryData = await service.GetAllAsync();

            List<Corona> countryData = new List<Corona>();
            Corona denmark = await service.GetByNameAsync("Denmark");
            countryData.Add(denmark);

            return View(countryData);
        }
    }
}
