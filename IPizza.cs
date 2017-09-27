namespace PizzaShop
{
	public interface IPizza
	{
		void Build(string name, string sauce, string toppings);
		void Bake(int temperature, int duration);
		void Slice(int numberOfSlices);
		void Box();
	}
}