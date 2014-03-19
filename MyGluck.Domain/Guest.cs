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
	[Table("Guests")]
	public class Guest : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int EventId { get; set; } //(int, not null)
		[Required]
		[Key, Column(Order=1)]
		public int UserId { get; set; } //(int, not null)
		[Required]
		public int GuestStatusId { get; set; } //(int, not null)
		[Required]
		public DateTime LastUpdateDate { get; set; } //(datetime, not null)
		[Required]
		public byte[] TotalAdults { get; set; } //(tinyint, not null)
		[Required]
		public byte[] TotalChildrens { get; set; } //(tinyint, not null)
	}
}
