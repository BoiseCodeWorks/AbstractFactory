using System;

namespace PizzaShop
{
	public class Pizza : IPizza
	{
		public void Bake(int temperature, int duration)
		{
			Console.WriteLine($"Baking at {temperature} degrees for {duration} minutes.");
		}

		public void Box()
		{
			Console.WriteLine("Boxing.");
		}

		public void Build(string name, string sauce, string toppings)
		{
			Console.WriteLine($"Building a {name} pizza with {sauce}, {toppings}.");
		}

		public void Slice(int numberOfSlices)
		{
			Console.WriteLine($"Slicing into {numberOfSlices} slices.");
		}
	}
}