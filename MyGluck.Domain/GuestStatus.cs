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
	[Table("GuestStatus")]
	public class GuestStatus : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int GuestStatusId { get; set; } //(int, not null)
		[Required]
		[StringLength(50)]
		public string Name { get; set; } //(varchar(50), not null)
		[Required]
		public byte[] Code { get; set; } //(tinyint, not null)
	}
}
