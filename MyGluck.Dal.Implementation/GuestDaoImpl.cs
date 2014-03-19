using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGluck.Domain
;
using MyGluck.Dal;
using MyGluck.Connection;
namespace MyGluck.Dal.Implementation
{
	public class GuestDaoImpl : Abstracts.BaseDaoImpl, GuestDao
	{
		public List<Guest> SelectAll()
		{
			object[] parameters = new object[] { null, null };
			return Context.Database.SqlQuery<Guest>("dbo.usp_GuestsSelect @EventId={0}, @UserId={1}", parameters).ToList();
		}

		public Guest SelectByKey(Guest entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.UserId };
			return Context.Database.SqlQuery<Guest>("dbo.usp_GuestsSelect @EventId={0}, @UserId={1}", parameters).FirstOrDefault();
		}

		public Guest Update(Guest entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.UserId, entity.GuestStatusId, entity.LastUpdateDate, entity.TotalAdults, entity.TotalChildrens };
			return Context.Database.SqlQuery<Guest>("dbo.usp_GuestsUpdate @EventId={0}, @UserId={1}, @GuestStatusId={2}, @LastUpdateDate={3}, @TotalAdults={4}, @TotalChildrens={5}", parameters).FirstOrDefault();
		}

		public Guest Insert(Guest entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.UserId, entity.GuestStatusId, entity.LastUpdateDate, entity.TotalAdults, entity.TotalChildrens };
			return Context.Database.SqlQuery<Guest>("dbo.usp_GuestsInsert @EventId={0}, @UserId={1}, @GuestStatusId={2}, @LastUpdateDate={3}, @TotalAdults={4}, @TotalChildrens={5}", parameters).FirstOrDefault();
		}

		public bool Delete(Guest entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.UserId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_GuestsDelete @EventId={0}, @UserId={1}", parameters) == -1 ? true : false);
		}

	}
}
