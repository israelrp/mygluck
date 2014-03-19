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
	public class ProviderDaoImpl : Abstracts.BaseDaoImpl, ProviderDao
	{
		public List<Provider> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Provider>("dbo.usp_ProvidersSelect @ProviderId={0}", parameters).ToList();
		}

		public Provider SelectByKey(Provider entity)
		{
			object[] parameters = new object[] { entity.ProviderId };
			return Context.Database.SqlQuery<Provider>("dbo.usp_ProvidersSelect @ProviderId={0}", parameters).FirstOrDefault();
		}

		public Provider Update(Provider entity)
		{
			object[] parameters = new object[] { entity.ProviderId, entity.CountryId, entity.StateId, entity.Name, entity.Description, entity.WebSite, entity.PhoneNumber, entity.ContactPerson, entity.EmailContact, entity.Logo, entity.Comments };
			return Context.Database.SqlQuery<Provider>("dbo.usp_ProvidersUpdate @ProviderId={0}, @CountryId={1}, @StateId={2}, @Name={3}, @Description={4}, @WebSite={5}, @PhoneNumber={6}, @ContactPerson={7}, @EmailContact={8}, @Logo={9}, @Comments={10}", parameters).FirstOrDefault();
		}

		public Provider Insert(Provider entity)
		{
			object[] parameters = new object[] { entity.CountryId, entity.StateId, entity.Name, entity.Description, entity.WebSite, entity.PhoneNumber, entity.ContactPerson, entity.EmailContact, entity.Logo, entity.Comments };
			return Context.Database.SqlQuery<Provider>("dbo.usp_ProvidersInsert @CountryId={0}, @StateId={1}, @Name={2}, @Description={3}, @WebSite={4}, @PhoneNumber={5}, @ContactPerson={6}, @EmailContact={7}, @Logo={8}, @Comments={9}", parameters).FirstOrDefault();
		}

		public bool Delete(Provider entity)
		{
			object[] parameters = new object[] { entity.ProviderId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_ProvidersDelete @ProviderId={0}", parameters) == -1 ? true : false);
		}

	}
}
