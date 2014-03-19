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
	public class webpages_UsersInRoleDaoImpl : Abstracts.BaseDaoImpl, webpages_UsersInRoleDao
	{
		public List<webpages_UsersInRole> SelectAll()
		{
			object[] parameters = new object[] { null, null };
			return Context.Database.SqlQuery<webpages_UsersInRole>("dbo.usp_webpages_UsersInRolesSelect @UserId={0}, @RoleId={1}", parameters).ToList();
		}

		public webpages_UsersInRole SelectByKey(webpages_UsersInRole entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.RoleId };
			return Context.Database.SqlQuery<webpages_UsersInRole>("dbo.usp_webpages_UsersInRolesSelect @UserId={0}, @RoleId={1}", parameters).FirstOrDefault();
		}

		public webpages_UsersInRole Update(webpages_UsersInRole entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.RoleId };
			return Context.Database.SqlQuery<webpages_UsersInRole>("dbo.usp_webpages_UsersInRolesUpdate @UserId={0}, @RoleId={1}", parameters).FirstOrDefault();
		}

		public webpages_UsersInRole Insert(webpages_UsersInRole entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.RoleId };
			return Context.Database.SqlQuery<webpages_UsersInRole>("dbo.usp_webpages_UsersInRolesInsert @UserId={0}, @RoleId={1}", parameters).FirstOrDefault();
		}

		public bool Delete(webpages_UsersInRole entity)
		{
			object[] parameters = new object[] { entity.UserId, entity.RoleId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_webpages_UsersInRolesDelete @UserId={0}, @RoleId={1}", parameters) == -1 ? true : false);
		}

	}
}
