using la_mia_pizzeria_static.Data;
using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            //query al db
            PizzeriaDbContext db = new PizzeriaDbContext();
            //grabbing all Pizzas in db 
            //return View(db.Pizzas.ToList());

            //store Pizza in an obj can be useful but require further inclusion
            List<Pizza> listPizza = db.Pizzas.ToList();
            return View(listPizza);
        }

        public IActionResult Detail(int id)
        {
            PizzeriaDbContext db = new PizzeriaDbContext();

            Pizza pizza = db.Pizzas.Where(p => p.Id == id).FirstOrDefault();

            return View(pizza);
        }
    }
}
