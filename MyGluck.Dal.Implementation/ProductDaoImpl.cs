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
	public class ProductDaoImpl : Abstracts.BaseDaoImpl, ProductDao
	{
		public List<Product> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Product>("dbo.usp_ProductsSelect @ProductId={0}", parameters).ToList();
		}

		public Product SelectByKey(Product entity)
		{
			object[] parameters = new object[] { entity.ProductId };
			return Context.Database.SqlQuery<Product>("dbo.usp_ProductsSelect @ProductId={0}", parameters).FirstOrDefault();
		}

		public Product Update(Product entity)
		{
			object[] parameters = new object[] { entity.ProductId, entity.ProviderId, entity.CategoryId, entity.UnitId, entity.Name, entity.Description, entity.Photo, entity.UnitPrice, entity.Sku, entity.Brand, entity.Model, entity.Avaible };
			return Context.Database.SqlQuery<Product>("dbo.usp_ProductsUpdate @ProductId={0}, @ProviderId={1}, @CategoryId={2}, @UnitId={3}, @Name={4}, @Description={5}, @Photo={6}, @UnitPrice={7}, @Sku={8}, @Brand={9}, @Model={10}, @Avaible={11}", parameters).FirstOrDefault();
		}

		public Product Insert(Product entity)
		{
			object[] parameters = new object[] { entity.ProviderId, entity.CategoryId, entity.UnitId, entity.Name, entity.Description, entity.Photo, entity.UnitPrice, entity.Sku, entity.Brand, entity.Model, entity.Avaible };
			return Context.Database.SqlQuery<Product>("dbo.usp_ProductsInsert @ProviderId={0}, @CategoryId={1}, @UnitId={2}, @Name={3}, @Description={4}, @Photo={5}, @UnitPrice={6}, @Sku={7}, @Brand={8}, @Model={9}, @Avaible={10}", parameters).FirstOrDefault();
		}

		public bool Delete(Product entity)
		{
			object[] parameters = new object[] { entity.ProductId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_ProductsDelete @ProductId={0}", parameters) == -1 ? true : false);
		}

	}
}
