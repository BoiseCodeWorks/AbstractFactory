namespace PizzaShop
{
	public interface IPizzaFactory
	{
		IPizza MakePizza(string name);
	}
}