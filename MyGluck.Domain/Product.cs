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
	[Table("Products")]
	public class Product : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int ProductId { get; set; } //(int, not null)
		[Required]
		public int ProviderId { get; set; } //(int, not null)
		[Required]
		public int CategoryId { get; set; } //(int, not null)
		[Required]
		public int UnitId { get; set; } //(int, not null)
		[Required]
		[StringLength(50)]
		public string Name { get; set; } //(varchar(50), not null)
		[Required]
		[StringLength(300)]
		public string Description { get; set; } //(varchar(300), not null)
		[Required]
		public string Photo { get; set; } //(varchar(max), not null)
		[Required]
		[DataType(DataType.Currency)]
		public decimal UnitPrice { get; set; } //(money, not null)
		[Required]
		[StringLength(20)]
		public string Sku { get; set; } //(varchar(20), not null)
		[StringLength(20)]
		public string Brand { get; set; } //(varchar(20), null)
		[StringLength(20)]
		public string Model { get; set; } //(varchar(20), null)
		[Required]
		public bool Avaible { get; set; } //(bit, not null)
	}
}
