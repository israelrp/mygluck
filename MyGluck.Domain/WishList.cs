using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGluck.Domain
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Clase de dato
	/// </summary>
	[Table("WishList")]
	public class WishList : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int WishListId { get; set; } //(int, not null)
		[Required]
		public int EventId { get; set; } //(int, not null)
		public int ProductId { get; set; } //(int, null)
		[Required]
		[StringLength(50)]
		public string Name { get; set; } //(varchar(50), not null)
		[Required]
		public string Photo { get; set; } //(varchar(max), not null)
		[Required]
		[DataType(DataType.Currency)]
		public decimal UnitPrice { get; set; } //(money, not null)
		[Required]
		[StringLength(20)]
		public string Sku { get; set; } //(varchar(20), not null)
		[Required]
		[StringLength(20)]
		public string Brand { get; set; } //(varchar(20), not null)
		[Required]
		[StringLength(20)]
		public string Model { get; set; } //(varchar(20), not null)
		[Required]
		public int Quantity { get; set; } //(int, not null)
		[Required]
		public bool Already { get; set; } //(bit, not null)
	}
}
