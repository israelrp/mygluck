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
	public class webpages_MembershipDaoImpl : Abstracts.BaseDaoImpl, webpages_MembershipDao
	{
		public List<webpages_Membership> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<webpages_Membership>("dbo.usp_webpages_MembershipSelect @UserId={0}", parameters).ToList();
		}

		public webpages_Membership SelectByKey(webpages_Membership entity)
		{
			object[] parameters = new object[] { entity.UserId };
			return Context.Database.SqlQuery<webpages_Membership>("dbo.usp_webpages_MembershipSelect @UserId={0}", parameters).FirstOrDefault();
		}

		public webpages_Membership Update(webpages_Membership entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.CreateDate, entity.ConfirmationToken, entity.IsConfirmed, entity.LastPasswordFailureDate, entity.PasswordFailuresSinceLastSuccess, entity.Password, entity.PasswordChangedDate, entity.PasswordSalt, entity.PasswordVerificationToken, entity.PasswordVerificationTokenExpirationDate };
			return Context.Database.SqlQuery<webpages_Membership>("dbo.usp_webpages_MembershipUpdate @UserId={0}, @CreateDate={1}, @ConfirmationToken={2}, @IsConfirmed={3}, @LastPasswordFailureDate={4}, @PasswordFailuresSinceLastSuccess={5}, @Password={6}, @PasswordChangedDate={7}, @PasswordSalt={8}, @PasswordVerificationToken={9}, @PasswordVerificationTokenExpirationDate={10}", parameters).FirstOrDefault();
		}

		public webpages_Membership Insert(webpages_Membership entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.CreateDate, entity.ConfirmationToken, entity.IsConfirmed, entity.LastPasswordFailureDate, entity.PasswordFailuresSinceLastSuccess, entity.Password, entity.PasswordChangedDate, entity.PasswordSalt, entity.PasswordVerificationToken, entity.PasswordVerificationTokenExpirationDate };
			return Context.Database.SqlQuery<webpages_Membership>("dbo.usp_webpages_MembershipInsert @UserId={0}, @CreateDate={1}, @ConfirmationToken={2}, @IsConfirmed={3}, @LastPasswordFailureDate={4}, @PasswordFailuresSinceLastSuccess={5}, @Password={6}, @PasswordChangedDate={7}, @PasswordSalt={8}, @PasswordVerificationToken={9}, @PasswordVerificationTokenExpirationDate={10}", parameters).FirstOrDefault();
		}

		public bool Delete(webpages_Membership entity)
		{
			object[] parameters = new object[] { entity.UserId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_webpages_MembershipDelete @UserId={0}", parameters) == -1 ? true : false);
		}

	}
}
