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
	[Table("Units")]
	public class Unit : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UnitId { get; set; } //(int, not null)
		[Required]
		[StringLength(20)]
		public string Name { get; set; } //(varchar(20), not null)
	}
}
