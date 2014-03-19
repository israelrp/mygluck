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
	[Table("webpages_UsersInRoles")]
	public class webpages_UsersInRole : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UserId { get; set; } //(int, not null)
		[Required]
		[Key, Column(Order=1)]
		public int RoleId { get; set; } //(int, not null)
	}
}
