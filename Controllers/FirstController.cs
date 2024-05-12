using Microsoft.AspNetCore.Mvc;
using App.Services;

namespace App.Controllers
{
    public class FirstController : Controller
    {
        private readonly ProductService _productService;

        public FirstController(ProductService productService){
            _productService = productService;
        }

        public string Index(){
            return "toi la first controller";
        }

        public IActionResult HelloView(string username){
            if(string.IsNullOrEmpty(username)){
                username = "khach";
            }
            return View((object)username);
        }

        [TempData]
        public string StatusMessage{set; get;}

        public IActionResult ViewProduct(int? id){
            var product = _productService.Where(p => p.Id == id).FirstOrDefault();
            if(product == null)
            {
                StatusMessage = "San pham khong co";
                return Redirect(Url.Action("Index","Home"));
            }
            //ViewData["Title"] = product.Name;  
            return View(product);
        }
    }
}