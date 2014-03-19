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
	[Table("States")]
	public class State : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int StateId { get; set; } //(int, not null)
		[Required]
		public int CountryId { get; set; } //(int, not null)
		[Required]
		[StringLength(200)]
		public string Name { get; set; } //(varchar(200), not null)
		[Required]
		[StringLength(5)]
		public string Code { get; set; } //(varchar(5), not null)
	}
}
