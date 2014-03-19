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
	[Table("Categories")]
	public class Category : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int CategoryId { get; set; } //(int, not null)
		[Required]
		[StringLength(25)]
		public string Name { get; set; } //(varchar(25), not null)
		[Required]
		public string Photo { get; set; } //(nvarchar(max), not null)
	}
}
