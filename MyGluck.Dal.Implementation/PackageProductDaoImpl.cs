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
	public class PackageProductDaoImpl : Abstracts.BaseDaoImpl, PackageProductDao
	{
		public List<PackageProduct> SelectAll()
		{
			object[] parameters = new object[] {  };
			return Context.Database.SqlQuery<PackageProduct>("dbo.usp_PackageProductsSelect ", parameters).ToList();
		}

		public PackageProduct SelectByKey(PackageProduct entity)
		{
			object[] parameters = new object[] {  };
			return Context.Database.SqlQuery<PackageProduct>("dbo.usp_PackageProductsSelect ", parameters).FirstOrDefault();
		}

		public PackageProduct Update(PackageProduct entity)
		{
			object[] parameters = new object[] { entity.ProductId, entity.PackageId, entity.Discount };
			return Context.Database.SqlQuery<PackageProduct>("dbo.usp_PackageProductsUpdate @ProductId={0}, @PackageId={1}, @Discount={2}", parameters).FirstOrDefault();
		}

		public PackageProduct Insert(PackageProduct entity)
		{
			object[] parameters = new object[] { entity.ProductId, entity.PackageId, entity.Discount };
			return Context.Database.SqlQuery<PackageProduct>("dbo.usp_PackageProductsInsert @ProductId={0}, @PackageId={1}, @Discount={2}", parameters).FirstOrDefault();
		}

		public bool Delete(PackageProduct entity)
		{
			object[] parameters = new object[] {  };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PackageProductsDelete ", parameters) == -1 ? true : false);
		}

	}
}
