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
	[Table("EventPhotos")]
	public class EventPhoto : Base.BaseObjectDomain
	{
		[Required]
		public int EventPhotoId { get; set; } //(int, not null)
		[Required]
		public int EventId { get; set; } //(int, not null)
		[Required]
		public int UserId { get; set; } //(int, not null)
		[Required]
		public string Photo { get; set; } //(nvarchar(max), not null)
		[Required]
		public bool Private { get; set; } //(bit, not null)
		[Required]
		public DateTime Datetime { get; set; } //(datetime, not null)
	}
}
