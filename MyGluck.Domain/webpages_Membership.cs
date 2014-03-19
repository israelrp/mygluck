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
	[Table("webpages_Membership")]
	public class webpages_Membership : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UserId { get; set; } //(int, not null)
		public DateTime CreateDate { get; set; } //(datetime, null)
		[StringLength(128)]
		public string ConfirmationToken { get; set; } //(nvarchar(128), null)
		public bool IsConfirmed { get; set; } //(bit, null)
		public DateTime LastPasswordFailureDate { get; set; } //(datetime, null)
		[Required]
		public int PasswordFailuresSinceLastSuccess { get; set; } //(int, not null)
		[Required]
		[StringLength(128)]
		public string Password { get; set; } //(nvarchar(128), not null)
		public DateTime PasswordChangedDate { get; set; } //(datetime, null)
		[Required]
		[StringLength(128)]
		public string PasswordSalt { get; set; } //(nvarchar(128), not null)
		[StringLength(128)]
		public string PasswordVerificationToken { get; set; } //(nvarchar(128), null)
		public DateTime PasswordVerificationTokenExpirationDate { get; set; } //(datetime, null)
	}
}
