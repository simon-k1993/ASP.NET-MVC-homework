using PizzaApp.Models;

namespace PizzaApp
{
    public class StaticDb
    {
        public static List<PizzaOrder> Pizzas = new List<PizzaOrder>
        {
            new PizzaOrder()
            {
                OrderNumber = 1,
                CustomerName = "Cacko Konopiski",
                TypeOfPizza = "Profesorska"
            },
            new PizzaOrder()
            {
                OrderNumber = 2,
                CustomerName = "Mile Panika",
                TypeOfPizza = "Quattro formaggi"
            },

            new PizzaOrder()
            {
                OrderNumber = 3,
                CustomerName = "Toso Malerot",
                TypeOfPizza = "Frutti di Mare"
            }
        };
    }
}
