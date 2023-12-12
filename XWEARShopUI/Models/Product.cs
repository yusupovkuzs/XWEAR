using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebXWEAR.Models
{
	[Table("Product")]
	public class Product
	{
        public int Id { get; set; }
		[Required]
		[MaxLength(40)]
        public string? ProductName { get; set; }
        public int TypeId { get; set; }

		// type поменять
		public Type ProductType { get; set; }

    }
}
