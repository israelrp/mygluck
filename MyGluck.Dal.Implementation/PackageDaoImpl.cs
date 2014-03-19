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
	public class PackageDaoImpl : Abstracts.BaseDaoImpl, PackageDao
	{
		public List<Package> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Package>("dbo.usp_PackagesSelect @ProductPackageId={0}", parameters).ToList();
		}

		public Package SelectByKey(Package entity)
		{
			object[] parameters = new object[] { entity.ProductPackageId };
			return Context.Database.SqlQuery<Package>("dbo.usp_PackagesSelect @ProductPackageId={0}", parameters).FirstOrDefault();
		}

		public Package Update(Package entity)
		{
			object[] parameters = new object[] { entity.ProductPackageId, entity.ProviderId, entity.Name, entity.Discount };
			return Context.Database.SqlQuery<Package>("dbo.usp_PackagesUpdate @ProductPackageId={0}, @ProviderId={1}, @Name={2}, @Discount={3}", parameters).FirstOrDefault();
		}

		public Package Insert(Package entity)
		{
			object[] parameters = new object[] { entity.ProviderId, entity.Name, entity.Discount };
			return Context.Database.SqlQuery<Package>("dbo.usp_PackagesInsert @ProviderId={0}, @Name={1}, @Discount={2}", parameters).FirstOrDefault();
		}

		public bool Delete(Package entity)
		{
			object[] parameters = new object[] { entity.ProductPackageId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PackagesDelete @ProductPackageId={0}", parameters) == -1 ? true : false);
		}

	}
}
