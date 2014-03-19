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
	[Table("Schedules")]
	public class Schedule : Base.BaseObjectDomain
	{
		[Required]
		public int ScheduleId { get; set; } //(int, not null)
		[Required]
		public int EventId { get; set; } //(int, not null)
		[Required]
		[StringLength(60)]
		public string Description { get; set; } //(varchar(60), not null)
		[Required]
		public string Photo { get; set; } //(varchar(max), not null)
		[Required]
		public DateTime Date { get; set; } //(datetime, not null)
		[Required]
		public string Place { get; set; } //(MyGluck.sys.geography, not null)
		[Required]
		[StringLength(300)]
		public string Direction { get; set; } //(varchar(300), not null)
	}
}
