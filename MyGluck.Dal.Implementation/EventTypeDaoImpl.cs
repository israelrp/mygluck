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
	public class EventTypeDaoImpl : Abstracts.BaseDaoImpl, EventTypeDao
	{
		public List<EventType> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<EventType>("dbo.usp_EventTypesSelect @EventTypeId={0}", parameters).ToList();
		}

		public EventType SelectByKey(EventType entity)
		{
			object[] parameters = new object[] { entity.EventTypeId };
			return Context.Database.SqlQuery<EventType>("dbo.usp_EventTypesSelect @EventTypeId={0}", parameters).FirstOrDefault();
		}

		public EventType Update(EventType entity)
		{
			object[] parameters = new object[] { entity.EventTypeId, entity.Name, entity.Code };
			return Context.Database.SqlQuery<EventType>("dbo.usp_EventTypesUpdate @EventTypeId={0}, @Name={1}, @Code={2}", parameters).FirstOrDefault();
		}

		public EventType Insert(EventType entity)
		{
			object[] parameters = new object[] { entity.Name, entity.Code };
			return Context.Database.SqlQuery<EventType>("dbo.usp_EventTypesInsert @Name={0}, @Code={1}", parameters).FirstOrDefault();
		}

		public bool Delete(EventType entity)
		{
			object[] parameters = new object[] { entity.EventTypeId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_EventTypesDelete @EventTypeId={0}", parameters) == -1 ? true : false);
		}

	}
}
