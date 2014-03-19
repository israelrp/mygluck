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
	public class webpages_OAuthMembershipDaoImpl : Abstracts.BaseDaoImpl, webpages_OAuthMembershipDao
	{
		public List<webpages_OAuthMembership> SelectAll()
		{
			object[] parameters = new object[] { null, null };
			return Context.Database.SqlQuery<webpages_OAuthMembership>("dbo.usp_webpages_OAuthMembershipSelect @Provider={0}, @ProviderUserId={1}", parameters).ToList();
		}

		public webpages_OAuthMembership SelectByKey(webpages_OAuthMembership entity)
		{
			object[] parameters = new object[] { entity.Provider, entity.ProviderUserId };
			return Context.Database.SqlQuery<webpages_OAuthMembership>("dbo.usp_webpages_OAuthMembershipSelect @Provider={0}, @ProviderUserId={1}", parameters).FirstOrDefault();
		}

		public webpages_OAuthMembership Update(webpages_OAuthMembership entity)
		{
			object[] parameters = new object[] { entity.Provider, entity.ProviderUserId, entity.UserId };
			return Context.Database.SqlQuery<webpages_OAuthMembership>("dbo.usp_webpages_OAuthMembershipUpdate @Provider={0}, @ProviderUserId={1}, @UserId={2}", parameters).FirstOrDefault();
		}

		public webpages_OAuthMembership Insert(webpages_OAuthMembership entity)
		{
			object[] parameters = new object[] { entity.Provider, entity.ProviderUserId, entity.UserId };
			return Context.Database.SqlQuery<webpages_OAuthMembership>("dbo.usp_webpages_OAuthMembershipInsert @Provider={0}, @ProviderUserId={1}, @UserId={2}", parameters).FirstOrDefault();
		}

		public bool Delete(webpages_OAuthMembership entity)
		{
			object[] parameters = new object[] { entity.Provider, entity.ProviderUserId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_webpages_OAuthMembershipDelete @Provider={0}, @ProviderUserId={1}", parameters) == -1 ? true : false);
		}

	}
}
