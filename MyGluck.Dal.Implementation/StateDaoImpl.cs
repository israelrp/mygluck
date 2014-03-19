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
	public class StateDaoImpl : Abstracts.BaseDaoImpl, StateDao
	{
		public List<State> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<State>("dbo.usp_StatesSelect @StateId={0}", parameters).ToList();
		}

		public State SelectByKey(State entity)
		{
			object[] parameters = new object[] { entity.StateId };
			return Context.Database.SqlQuery<State>("dbo.usp_StatesSelect @StateId={0}", parameters).FirstOrDefault();
		}

		public State Update(State entity)
		{
			object[] parameters = new object[] { entity.StateId, entity.CountryId, entity.Name, entity.Code };
			return Context.Database.SqlQuery<State>("dbo.usp_StatesUpdate @StateId={0}, @CountryId={1}, @Name={2}, @Code={3}", parameters).FirstOrDefault();
		}

		public State Insert(State entity)
		{
			object[] parameters = new object[] { entity.CountryId, entity.Name, entity.Code };
			return Context.Database.SqlQuery<State>("dbo.usp_StatesInsert @CountryId={0}, @Name={1}, @Code={2}", parameters).FirstOrDefault();
		}

		public bool Delete(State entity)
		{
			object[] parameters = new object[] { entity.StateId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_StatesDelete @StateId={0}", parameters) == -1 ? true : false);
		}

	}
}
