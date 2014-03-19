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
	[Table("Providers")]
	public class Provider : Base.BaseObjectDomain
	{
		[Required]
		[Key, Column(Order=0)]
		public int ProviderId { get; set; } //(int, not null)
		[Required]
		public int CountryId { get; set; } //(int, not null)
		[Required]
		public int StateId { get; set; } //(int, not null)
		[Required]
		[StringLength(100)]
		public string Name { get; set; } //(varchar(100), not null)
		[Required]
		[StringLength(400)]
		public string Description { get; set; } //(varchar(400), not null)
		[Required]
		[StringLength(100)]
		public string WebSite { get; set; } //(varchar(100), not null)
		[Required]
		[StringLength(20)]
		public string PhoneNumber { get; set; } //(varchar(20), not null)
		[Required]
		[StringLength(50)]
		public string ContactPerson { get; set; } //(varchar(50), not null)
		[Required]
		[StringLength(150)]
		public string EmailContact { get; set; } //(varchar(150), not null)
		[Required]
		public string Logo { get; set; } //(nvarchar(max), not null)
		[Required]
		[StringLength(100)]
		public string Comments { get; set; } //(varchar(100), not null)
	}
}
