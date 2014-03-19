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
	public class EventPhotoDaoImpl : Abstracts.BaseDaoImpl, EventPhotoDao
	{
		public List<EventPhoto> SelectAll()
		{
			object[] parameters = new object[] {  };
			return Context.Database.SqlQuery<EventPhoto>("dbo.usp_EventPhotosSelect ", parameters).ToList();
		}

		public EventPhoto SelectByKey(EventPhoto entity)
		{
			object[] parameters = new object[] {  };
			return Context.Database.SqlQuery<EventPhoto>("dbo.usp_EventPhotosSelect ", parameters).FirstOrDefault();
		}

		public EventPhoto Update(EventPhoto entity)
		{
			object[] parameters = new object[] { entity.EventPhotoId, entity.EventId, entity.UserId, entity.Photo, entity.Private, entity.Datetime };
			return Context.Database.SqlQuery<EventPhoto>("dbo.usp_EventPhotosUpdate @EventPhotoId={0}, @EventId={1}, @UserId={2}, @Photo={3}, @Private={4}, @Datetime={5}", parameters).FirstOrDefault();
		}

		public EventPhoto Insert(EventPhoto entity)
		{
			object[] parameters = new object[] { entity.EventPhotoId, entity.EventId, entity.UserId, entity.Photo, entity.Private, entity.Datetime };
			return Context.Database.SqlQuery<EventPhoto>("dbo.usp_EventPhotosInsert @EventPhotoId={0}, @EventId={1}, @UserId={2}, @Photo={3}, @Private={4}, @Datetime={5}", parameters).FirstOrDefault();
		}

		public bool Delete(EventPhoto entity)
		{
			object[] parameters = new object[] {  };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_EventPhotosDelete ", parameters) == -1 ? true : false);
		}

	}
}
