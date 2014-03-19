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
	[Table("Events")]
	public class Event : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int EventId { get; set; } //(int, not null)
		[Required]
		public int EventTypeId { get; set; } //(int, not null)
		[Required]
		public int UserId { get; set; } //(int, not null)
		[Required]
		public int ThemeId { get; set; } //(int, not null)
		[Required]
		public int CountryId { get; set; } //(int, not null)
		[Required]
		public int StateId { get; set; } //(int, not null)
		public int ParnertShipId { get; set; } //(int, null)
		[Required]
		[StringLength(100)]
		public string Name { get; set; } //(varchar(100), not null)
		[Required]
		public DateTime EventDate { get; set; } //(datetime, not null)
		[Required]
		[StringLength(300)]
		public string City { get; set; } //(varchar(300), not null)
		[Required]
		[StringLength(10)]
		public string PostalCode { get; set; } //(varchar(10), not null)
	}
}
