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
	public class EventDaoImpl : Abstracts.BaseDaoImpl, EventDao
	{
		public List<Event> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Event>("dbo.usp_EventsSelect @EventId={0}", parameters).ToList();
		}

		public Event SelectByKey(Event entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return Context.Database.SqlQuery<Event>("dbo.usp_EventsSelect @EventId={0}", parameters).FirstOrDefault();
		}

		public Event Update(Event entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.EventTypeId, entity.UserId, entity.ThemeId, entity.CountryId, entity.StateId, entity.ParnertShipId, entity.Name, entity.EventDate, entity.City, entity.PostalCode };
			return Context.Database.SqlQuery<Event>("dbo.usp_EventsUpdate @EventId={0}, @EventTypeId={1}, @UserId={2}, @ThemeId={3}, @CountryId={4}, @StateId={5}, @ParnertShipId={6}, @Name={7}, @EventDate={8}, @City={9}, @PostalCode={10}", parameters).FirstOrDefault();
		}

		public Event Insert(Event entity)
		{
			object[] parameters = new object[] { entity.EventTypeId, entity.UserId, entity.ThemeId, entity.CountryId, entity.StateId, entity.ParnertShipId, entity.Name, entity.EventDate, entity.City, entity.PostalCode };
			return Context.Database.SqlQuery<Event>("dbo.usp_EventsInsert @EventTypeId={0}, @UserId={1}, @ThemeId={2}, @CountryId={3}, @StateId={4}, @ParnertShipId={5}, @Name={6}, @EventDate={7}, @City={8}, @PostalCode={9}", parameters).FirstOrDefault();
		}

		public bool Delete(Event entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_EventsDelete @EventId={0}", parameters) == -1 ? true : false);
		}

	}
}
