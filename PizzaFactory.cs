namespace PizzaShop
{
	public abstract class PizzaFactory : IPizzaFactory
	{
		public virtual IPizza MakePizza(string name)
		{
			var pizza = new Pizza();

			switch(name)
			{
				case "Pepperoni":
					pizza.Build(name, "tomato", "cheese, pepperoni");
					pizza.Bake(350, 18);
					pizza.Slice(12);
					pizza.Box();
					break;

				default:
					pizza.Build(name, "tomato", "cheese");
					pizza.Bake(350, 18);
					pizza.Slice(12);
					pizza.Box();
					break;
			}

			return pizza;
		}
	}
}