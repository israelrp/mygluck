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
	public class ScheduleDaoImpl : Abstracts.BaseDaoImpl, ScheduleDao
	{
		public List<Schedule> SelectAll()
		{
			object[] parameters = new object[] {  };
			return Context.Database.SqlQuery<Schedule>("dbo.usp_SchedulesSelect ", parameters).ToList();
		}

		public Schedule SelectByKey(Schedule entity)
		{
			object[] parameters = new object[] {  };
			return Context.Database.SqlQuery<Schedule>("dbo.usp_SchedulesSelect ", parameters).FirstOrDefault();
		}

		public Schedule Update(Schedule entity)
		{
			object[] parameters = new object[] { entity.ScheduleId, entity.EventId, entity.Description, entity.Photo, entity.Date, entity.Place, entity.Direction };
			return Context.Database.SqlQuery<Schedule>("dbo.usp_SchedulesUpdate @ScheduleId={0}, @EventId={1}, @Description={2}, @Photo={3}, @Date={4}, @Place={5}, @Direction={6}", parameters).FirstOrDefault();
		}

		public Schedule Insert(Schedule entity)
		{
			object[] parameters = new object[] { entity.ScheduleId, entity.EventId, entity.Description, entity.Photo, entity.Date, entity.Place, entity.Direction };
			return Context.Database.SqlQuery<Schedule>("dbo.usp_SchedulesInsert @ScheduleId={0}, @EventId={1}, @Description={2}, @Photo={3}, @Date={4}, @Place={5}, @Direction={6}", parameters).FirstOrDefault();
		}

		public bool Delete(Schedule entity)
		{
			object[] parameters = new object[] {  };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_SchedulesDelete ", parameters) == -1 ? true : false);
		}

	}
}
