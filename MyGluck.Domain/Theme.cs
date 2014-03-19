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
	[Table("Themes")]
	public class Theme : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int ThemeId { get; set; } //(int, not null)
		[Required]
		[StringLength(30)]
		public string Name { get; set; } //(varchar(30), not null)
		[Required]
		public string PhotoPreview { get; set; } //(nvarchar(max), not null)
		[Required]
		public string Css { get; set; } //(text, not null)
	}
}
