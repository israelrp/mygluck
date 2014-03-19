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
	[Table("UserProfile")]
	public class UserProfile : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int UserId { get; set; } //(int, not null)
		[Required]
		[StringLength(150)]
		public string UserName { get; set; } //(nvarchar(150), not null)
		[Required]
		public string Photo { get; set; } //(nvarchar(max), not null)
		[Required]
		public int CountryId { get; set; } //(int, not null)
		[Required]
		public int StateId { get; set; } //(int, not null)
		[Required]
		[StringLength(300)]
		public string City { get; set; } //(varchar(300), not null)
		[Required]
		[StringLength(10)]
		public string PostalCode { get; set; } //(varchar(10), not null)
		[Required]
		[StringLength(20)]
		public string PhoneNumber { get; set; } //(nvarchar(20), not null)
		[Required]
		[StringLength(80)]
		public string Name { get; set; } //(nvarchar(80), not null)
		[Required]
		[StringLength(100)]
		public string LastName { get; set; } //(nvarchar(100), not null)
	}
}
