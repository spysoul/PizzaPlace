
namespace PizzaPlace.Shared.Models
{
	public class State
	{
		public Menu Menu { get; set; } = new Menu();
		public ShoppingBasket Basket { get; set; } = new ShoppingBasket();
		public Ui Ui { get; set; } = new Ui();

		public Decimal TotalPrice => Basket.Orders.Sum(id => Menu.GetPizza(id)!.Price);
	}
}

