using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using App.Services;

namespace App.Controllers
{   
    [Area("ProductManage")]
    // /Areas/ProductManage/Views/Product/Index.html
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        private readonly ILogger<HomeController> _logger;


        public ProductController(ProductService productService, ILogger<HomeController> logger){
            _productService = productService;
            _logger = logger;
        }

        [Route("cac-san-pham")]
        public IActionResult Index()
        {
            var products = _productService.OrderBy(p => p.Name).ToList();
            return View(products);
        }
    }
}