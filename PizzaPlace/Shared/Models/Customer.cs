using System.ComponentModel.DataAnnotations;
namespace PizzaPlace.Shared.Models
{
	public class Customer
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Please, provide a name")]
		public string Name { get; set; } = default!;

		[Required(ErrorMessage = "Please, provide a Street")]
		public string Street { get; set; } = default!;

		[Required(ErrorMessage = "Please, provide a City")]
		public string City { get; set; } = default!;

	}
}

