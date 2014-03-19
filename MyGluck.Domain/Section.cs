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
	[Table("Sections")]
	public class Section : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int SectionId { get; set; } //(int, not null)
		[Required]
		public int EventId { get; set; } //(int, not null)
		[Required]
		public int SectionTypeId { get; set; } //(int, not null)
		[Required]
		[StringLength(50)]
		public string Name { get; set; } //(varchar(50), not null)
		[Required]
		[StringLength(70)]
		public string SubTitle { get; set; } //(varchar(70), not null)
		[Required]
		[StringLength(50)]
		public string Title { get; set; } //(varchar(50), not null)
		[Required]
		public string Body { get; set; } //(text, not null)
	}
}
