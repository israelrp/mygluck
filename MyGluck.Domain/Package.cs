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
	[Table("Packages")]
	public class Package : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int ProductPackageId { get; set; } //(int, not null)
		[Required]
		public int ProviderId { get; set; } //(int, not null)
		[Required]
		[StringLength(25)]
		public string Name { get; set; } //(varchar(25), not null)
		[DataType(DataType.Currency)]
		public decimal Discount { get; set; } //(money, null)
	}
}
