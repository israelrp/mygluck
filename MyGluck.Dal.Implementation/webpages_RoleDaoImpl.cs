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
	public class webpages_RoleDaoImpl : Abstracts.BaseDaoImpl, webpages_RoleDao
	{
		public List<webpages_Role> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<webpages_Role>("dbo.usp_webpages_RolesSelect @RoleId={0}", parameters).ToList();
		}

		public webpages_Role SelectByKey(webpages_Role entity)
		{
			object[] parameters = new object[] { entity.RoleId };
			return Context.Database.SqlQuery<webpages_Role>("dbo.usp_webpages_RolesSelect @RoleId={0}", parameters).FirstOrDefault();
		}

		public webpages_Role Update(webpages_Role entity)
		{
			object[] parameters = new object[] { entity.RoleId, entity.RoleName };
			return Context.Database.SqlQuery<webpages_Role>("dbo.usp_webpages_RolesUpdate @RoleId={0}, @RoleName={1}", parameters).FirstOrDefault();
		}

		public webpages_Role Insert(webpages_Role entity)
		{
			object[] parameters = new object[] { entity.RoleName };
			return Context.Database.SqlQuery<webpages_Role>("dbo.usp_webpages_RolesInsert @RoleName={0}", parameters).FirstOrDefault();
		}

		public bool Delete(webpages_Role entity)
		{
			object[] parameters = new object[] { entity.RoleId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_webpages_RolesDelete @RoleId={0}", parameters) == -1 ? true : false);
		}

	}
}
