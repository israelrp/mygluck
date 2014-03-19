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
	public class GiftTableDaoImpl : Abstracts.BaseDaoImpl, GiftTableDao
	{
		public List<GiftTable> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<GiftTable>("dbo.usp_GiftTablesSelect @EventId={0}", parameters).ToList();
		}

		public GiftTable SelectByKey(GiftTable entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return Context.Database.SqlQuery<GiftTable>("dbo.usp_GiftTablesSelect @EventId={0}", parameters).FirstOrDefault();
		}

		public GiftTable Update(GiftTable entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.Code, entity.DateLimit, entity.SendRememberEmail };
			return Context.Database.SqlQuery<GiftTable>("dbo.usp_GiftTablesUpdate @EventId={0}, @Code={1}, @DateLimit={2}, @SendRememberEmail={3}", parameters).FirstOrDefault();
		}

		public GiftTable Insert(GiftTable entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.Code, entity.DateLimit, entity.SendRememberEmail };
			return Context.Database.SqlQuery<GiftTable>("dbo.usp_GiftTablesInsert @EventId={0}, @Code={1}, @DateLimit={2}, @SendRememberEmail={3}", parameters).FirstOrDefault();
		}

		public bool Delete(GiftTable entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_GiftTablesDelete @EventId={0}", parameters) == -1 ? true : false);
		}

	}
}
