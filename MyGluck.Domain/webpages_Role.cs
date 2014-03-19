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
	[Table("webpages_Roles")]
	public class webpages_Role : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int RoleId { get; set; } //(int, not null)
		[Required]
		[StringLength(256)]
		public string RoleName { get; set; } //(nvarchar(256), not null)
	}
}
