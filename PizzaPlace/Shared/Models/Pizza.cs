using System;
namespace PizzaPlace.Shared.Models
{
	public class Pizza
	{
		// Contructor
		public Pizza(int id, string name, decimal price, Spiciness spiciness)
		{
			this.Id = id;
			this.Name = name;
			this.Price = price;
			this.Spiciness = spiciness;
		}

		public int Id { get; }
		public string Name { get; }
        public Decimal Price { get; }
        public Spiciness Spiciness { get; }
    }
}

