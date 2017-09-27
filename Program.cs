using System;

namespace PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
			var shop1 = PizzaShop.GetInstance();
			var shop2 = PizzaShop.GetInstance();

			var pizza = shop1.OrderPizza("Pepperoni");
		}
    }
}
