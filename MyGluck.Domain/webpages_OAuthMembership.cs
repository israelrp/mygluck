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
	[Table("webpages_OAuthMembership")]
	public class webpages_OAuthMembership : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		[StringLength(30)]
		public string Provider { get; set; } //(nvarchar(30), not null)
		[Required]
		[Key, Column(Order=1)]
		[StringLength(100)]
		public string ProviderUserId { get; set; } //(nvarchar(100), not null)
		[Required]
		public int UserId { get; set; } //(int, not null)
	}
}
