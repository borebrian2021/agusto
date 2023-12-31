using System.ComponentModel.DataAnnotations;

namespace SHOP.Models
{
	public class Restock_history
	{
		[Required]
		public int Item_id { get; set; }

		[Required]
		public string Date_restock { get; set; }

		public string Supplier { get; set; }


		[Required]
		public double new_quanity { get; set; }

		[Required]
		public double Prev_quantity { get; set; }

		[Required]
		public double quantity { get; set; }

		[Key]
		public int id { get; set; }
	}
}
