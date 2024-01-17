﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XWEARShopUI.Models
{
	[Table("Product")]
	public class Product
	{
        public int Id { get; set; }
		[Required]
		[MaxLength(40)]
        public string? ProductName { get; set; }
        [Required]
        [MaxLength(40)]
        public string? BrendName { get; set; }
        [Required]
        public double Price { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
		public Category Category { get; set; }
        public List<OrderDetail> OrderDetail { get; set; }
        public List<CartDetail> CartDetail { get; set; }
        [NotMapped]
        public string CategoryName {  get; set; }
    }
}
