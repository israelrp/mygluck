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
	public class UnitDaoImpl : Abstracts.BaseDaoImpl, UnitDao
	{
		public List<Unit> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Unit>("dbo.usp_UnitsSelect @UnitId={0}", parameters).ToList();
		}

		public Unit SelectByKey(Unit entity)
		{
			object[] parameters = new object[] { entity.UnitId };
			return Context.Database.SqlQuery<Unit>("dbo.usp_UnitsSelect @UnitId={0}", parameters).FirstOrDefault();
		}

		public Unit Update(Unit entity)
		{
			object[] parameters = new object[] { entity.UnitId, entity.Name };
			return Context.Database.SqlQuery<Unit>("dbo.usp_UnitsUpdate @UnitId={0}, @Name={1}", parameters).FirstOrDefault();
		}

		public Unit Insert(Unit entity)
		{
			object[] parameters = new object[] { entity.Name };
			return Context.Database.SqlQuery<Unit>("dbo.usp_UnitsInsert @Name={0}", parameters).FirstOrDefault();
		}

		public bool Delete(Unit entity)
		{
			object[] parameters = new object[] { entity.UnitId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_UnitsDelete @UnitId={0}", parameters) == -1 ? true : false);
		}

	}
}
