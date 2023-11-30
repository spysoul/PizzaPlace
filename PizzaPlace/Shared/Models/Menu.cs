using System;
namespace PizzaPlace.Shared.Models
{
	public class Menu
	{
		public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

		public void Add(Pizza pizza) => Pizzas.Add(pizza);

		public Pizza? GetPizza(int id) => Pizzas.SingleOrDefault(pizza => pizza.Id == id);
	}
}

