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
	[Table("Payments")]
	public class Payment : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int SaleId { get; set; } //(int, not null)
		[Required]
		[StringLength(90)]
		public string Name { get; set; } //(nvarchar(90), not null)
	}
}
