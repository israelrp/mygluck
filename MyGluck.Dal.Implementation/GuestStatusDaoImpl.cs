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
	public class GuestStatusDaoImpl : Abstracts.BaseDaoImpl, GuestStatusDao
	{
		public List<GuestStatus> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<GuestStatus>("dbo.usp_GuestStatusSelect @GuestStatusId={0}", parameters).ToList();
		}

		public GuestStatus SelectByKey(GuestStatus entity)
		{
			object[] parameters = new object[] { entity.GuestStatusId };
			return Context.Database.SqlQuery<GuestStatus>("dbo.usp_GuestStatusSelect @GuestStatusId={0}", parameters).FirstOrDefault();
		}

		public GuestStatus Update(GuestStatus entity)
		{
			object[] parameters = new object[] { entity.GuestStatusId, entity.Name, entity.Code };
			return Context.Database.SqlQuery<GuestStatus>("dbo.usp_GuestStatusUpdate @GuestStatusId={0}, @Name={1}, @Code={2}", parameters).FirstOrDefault();
		}

		public GuestStatus Insert(GuestStatus entity)
		{
			object[] parameters = new object[] { entity.Name, entity.Code };
			return Context.Database.SqlQuery<GuestStatus>("dbo.usp_GuestStatusInsert @Name={0}, @Code={1}", parameters).FirstOrDefault();
		}

		public bool Delete(GuestStatus entity)
		{
			object[] parameters = new object[] { entity.GuestStatusId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_GuestStatusDelete @GuestStatusId={0}", parameters) == -1 ? true : false);
		}

	}
}
