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
	public class CountryDaoImpl : Abstracts.BaseDaoImpl, CountryDao
	{
		public List<Country> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Country>("dbo.usp_CountriesSelect @CountryId={0}", parameters).ToList();
		}

		public Country SelectByKey(Country entity)
		{
			object[] parameters = new object[] { entity.CountryId };
			return Context.Database.SqlQuery<Country>("dbo.usp_CountriesSelect @CountryId={0}", parameters).FirstOrDefault();
		}

		public Country Update(Country entity)
		{
			object[] parameters = new object[] { entity.CountryId, entity.Name, entity.Code };
			return Context.Database.SqlQuery<Country>("dbo.usp_CountriesUpdate @CountryId={0}, @Name={1}, @Code={2}", parameters).FirstOrDefault();
		}

		public Country Insert(Country entity)
		{
			object[] parameters = new object[] { entity.Name, entity.Code };
			return Context.Database.SqlQuery<Country>("dbo.usp_CountriesInsert @Name={0}, @Code={1}", parameters).FirstOrDefault();
		}

		public bool Delete(Country entity)
		{
			object[] parameters = new object[] { entity.CountryId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CountriesDelete @CountryId={0}", parameters) == -1 ? true : false);
		}

	}
}
