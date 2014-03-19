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
	[Table("GiftTables")]
	public class GiftTable : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int EventId { get; set; } //(int, not null)
		[Required]
		[StringLength(16)]
		public string Code { get; set; } //(varchar(16), not null)
		[Required]
		public DateTime DateLimit { get; set; } //(datetime, not null)
		[Required]
		public bool SendRememberEmail { get; set; } //(bit, not null)
	}
}
