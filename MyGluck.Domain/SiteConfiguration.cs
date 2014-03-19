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
	[Table("SiteConfigurations")]
	public class SiteConfiguration : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int EventId { get; set; } //(int, not null)
		public string BackgroundImage { get; set; } //(nvarchar(max), null)
		[StringLength(10)]
		public string BackgroudHexa { get; set; } //(varchar(10), null)
		public string BackgroundImageFooter { get; set; } //(nvarchar(max), null)
		[StringLength(10)]
		public string BackgroudHexaFooter { get; set; } //(varchar(10), null)
		public string BackgroundImageHeader { get; set; } //(nvarchar(max), null)
		[StringLength(10)]
		public string BackgroudHexaHeader { get; set; } //(varchar(10), null)
	}
}
