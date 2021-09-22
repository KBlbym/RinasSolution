using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RinasWeb.Models;
using RinasWeb.ModelsView;
using RinasWeb.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RinasWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public JsonFileProductService _productService;

        public HomeController(ILogger<HomeController> logger, JsonFileProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> Products = _productService.GetProducts();
            IEnumerable<Category>  Categories = _productService.GetCategories();
            PerfumeModelView PerfumeModelView = new PerfumeModelView()
            {
                Catecories = Categories,
                Products = Products
            };

            return View(PerfumeModelView);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
