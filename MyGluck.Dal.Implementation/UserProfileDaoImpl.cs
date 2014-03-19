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
	public class UserProfileDaoImpl : Abstracts.BaseDaoImpl, UserProfileDao
	{
		public List<UserProfile> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<UserProfile>("dbo.usp_UserProfileSelect @UserId={0}", parameters).ToList();
		}

		public UserProfile SelectByKey(UserProfile entity)
		{
			object[] parameters = new object[] { entity.UserId };
			return Context.Database.SqlQuery<UserProfile>("dbo.usp_UserProfileSelect @UserId={0}", parameters).FirstOrDefault();
		}

		public UserProfile Update(UserProfile entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.UserName, entity.Photo, entity.CountryId, entity.StateId, entity.City, entity.PostalCode, entity.PhoneNumber, entity.Name, entity.LastName };
			return Context.Database.SqlQuery<UserProfile>("dbo.usp_UserProfileUpdate @UserId={0}, @UserName={1}, @Photo={2}, @CountryId={3}, @StateId={4}, @City={5}, @PostalCode={6}, @PhoneNumber={7}, @Name={8}, @LastName={9}", parameters).FirstOrDefault();
		}

		public UserProfile Insert(UserProfile entity)
		{
			object[] parameters = new object[] { entity.UserName, entity.Photo, entity.CountryId, entity.StateId, entity.City, entity.PostalCode, entity.PhoneNumber, entity.Name, entity.LastName };
			return Context.Database.SqlQuery<UserProfile>("dbo.usp_UserProfileInsert @UserName={0}, @Photo={1}, @CountryId={2}, @StateId={3}, @City={4}, @PostalCode={5}, @PhoneNumber={6}, @Name={7}, @LastName={8}", parameters).FirstOrDefault();
		}

		public bool Delete(UserProfile entity)
		{
			object[] parameters = new object[] { entity.UserId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_UserProfileDelete @UserId={0}", parameters) == -1 ? true : false);
		}

	}
}
