namespace PizzaShop
{
	public class IdahoPizzaFactory: PizzaFactory
	{
		public override IPizza MakePizza(string name)
		{
			var pizza = new Pizza();

			switch(name)
			{
				case "Pepperoni":
					pizza.Build(name, "tomato", "cheese, basil, pepperoni");
					pizza.Bake(350, 18);
					pizza.Slice(12);
					pizza.Box();
					break;

				default:
					pizza.Build(name, "tomato", "cheese, basil");
					pizza.Bake(350, 18);
					pizza.Slice(12);
					pizza.Box();
					break;
			}

			return pizza;
		}

	}
}