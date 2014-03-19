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
	[Table("PackageProducts")]
	public class PackageProduct : Base.BaseObjectDomain
	{
		[Required]
        [Key, Column(Order=0)]
		public int ProductId { get; set; } //(int, not null)
		[Required]
        [Key, Column(Order = 1)]
		public int PackageId { get; set; } //(int, not null)
		[DataType(DataType.Currency)]
		public decimal Discount { get; set; } //(money, null)
	}
}
