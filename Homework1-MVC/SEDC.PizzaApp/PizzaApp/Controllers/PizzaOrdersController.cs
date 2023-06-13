using Microsoft.AspNetCore.Mvc;
using PizzaApp.Models;

namespace PizzaApp.Controllers
{
    public class PizzaOrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("ListOfOrders")]
        public IActionResult ListOfOrders()
        {
            return View("Index");
        }

        [Route("[controller]/Details/{id?}")]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            PizzaOrder order = StaticDb.Pizzas.Where(x => x.OrderNumber == id).FirstOrDefault();

            if (order == null)
            {
                return new EmptyResult();
            }
            return View(order);
        }
        [Route("GetJson")]
        public IActionResult GetJson()
        {
            PizzaOrder pizzaOrders = new PizzaOrder()
            {
                OrderNumber = 1,
                CustomerName = "Cacko Konopiski",
                TypeOfPizza = "Profesorska"
            };
            return new JsonResult(pizzaOrders);
        }

        public IActionResult RedirectToHomeController()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
