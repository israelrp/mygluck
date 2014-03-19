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
	[Table("InvitationSettings")]
	public class InvitationSetting : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int EventId { get; set; } //(int, not null)
		public string BackgroudImage { get; set; } //(nvarchar(max), null)
		[StringLength(10)]
		public string BackgroudColor { get; set; } //(varchar(10), null)
		[Required]
		[StringLength(50)]
		public string FontType { get; set; } //(varchar(50), not null)
		[Required]
		public byte[] FontSizeHeader { get; set; } //(tinyint, not null)
		[Required]
		public byte[] FontSizeBody { get; set; } //(tinyint, not null)
		public byte[] FontSizeFooter { get; set; } //(tinyint, null)
		[Required]
		[StringLength(10)]
		public string FontColorHeader { get; set; } //(varchar(10), not null)
		[Required]
		[StringLength(10)]
		public string FontColorBody { get; set; } //(varchar(10), not null)
		[StringLength(10)]
		public string FontColorFooter { get; set; } //(varchar(10), null)
		[Required]
		[StringLength(40)]
		public string HeaderText { get; set; } //(varchar(40), not null)
		[Required]
		[StringLength(300)]
		public string BodyText { get; set; } //(varchar(300), not null)
		[StringLength(70)]
		public string FooterText { get; set; } //(varchar(70), null)
		public string LogoImage { get; set; } //(nvarchar(max), null)
	}
}
