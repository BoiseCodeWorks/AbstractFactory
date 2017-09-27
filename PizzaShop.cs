using System;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace PizzaShop
{
	public class PizzaShop : IPizzaShop
	{
		private static IPizzaShop instance;

		public IConfiguration Configuration { get; set; }
		public IPizzaFactory Factory { get; set; }

		private PizzaShop()
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

			Configuration = builder.Build();

			var factoryType = Configuration["Factory"];
			var type = Assembly.GetEntryAssembly().GetType(factoryType);

			Factory = (IPizzaFactory)Activator.CreateInstance(type);
		}

		public static IPizzaShop GetInstance()
		{
			if(instance == null)
			{
				instance = new PizzaShop();
			}

			return instance;
		}
		public IPizza OrderPizza(string name)
		{
			return Factory.MakePizza(name);
		}
	}
}