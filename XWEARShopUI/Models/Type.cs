using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebXWEAR.Models
{
	[Table("Type")]
	public class Type
	{
		public int Id { get; set; }
		[Required]
		[MaxLength(40)]
		public string TypeName { get; set; }

		public List<Product> Products { get; set; }
	}
}
