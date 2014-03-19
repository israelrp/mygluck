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
	[Table("Sales")]
	public class Sale : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int SaleId { get; set; } //(int, not null)
		[Required]
		public int WishListId { get; set; } //(int, not null)
		[Required]
		public int GuestId { get; set; } //(int, not null)
		[Required]
		public int ProductId { get; set; } //(int, not null)
		[Required]
		public int Quantity { get; set; } //(int, not null)
		[Required]
		[StringLength(50)]
		public string Name { get; set; } //(varchar(50), not null)
		[Required]
		[StringLength(300)]
		public string Description { get; set; } //(varchar(300), not null)
		[Required]
		[DataType(DataType.Currency)]
		public decimal UnitPrice { get; set; } //(money, not null)
		[Required]
		[StringLength(20)]
		public string Sku { get; set; } //(varchar(20), not null)
		[Required]
		[DataType(DataType.Currency)]
		public decimal Total { get; set; } //(money, not null)
		[Required]
		public bool SendEvent { get; set; } //(bit, not null)
	}
}
