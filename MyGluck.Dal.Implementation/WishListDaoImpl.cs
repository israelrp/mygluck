using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGluck.Domain;
using MyGluck.Dal;
using MyGluck.Connection;
namespace MyGluck.Dal.Implementation
{
	public class WishListDaoImpl : Abstracts.BaseDaoImpl, WishListDao
	{
		public List<WishList> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<WishList>("dbo.usp_WishListSelect @WishListId={0}", parameters).ToList();
		}

		public WishList SelectByKey(WishList entity)
		{
			object[] parameters = new object[] { entity.WishListId };
			return Context.Database.SqlQuery<WishList>("dbo.usp_WishListSelect @WishListId={0}", parameters).FirstOrDefault();
		}

		public WishList Update(WishList entity)
		{
			object[] parameters = new object[] { entity.WishListId, entity.EventId, entity.ProductId, entity.Name, entity.Photo, entity.UnitPrice, entity.Sku, entity.Brand, entity.Model, entity.Quantity, entity.Already };
			return Context.Database.SqlQuery<WishList>("dbo.usp_WishListUpdate @WishListId={0}, @EventId={1}, @ProductId={2}, @Name={3}, @Photo={4}, @UnitPrice={5}, @Sku={6}, @Brand={7}, @Model={8}, @Quantity={9}, @Already={10}", parameters).FirstOrDefault();
		}

		public WishList Insert(WishList entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.ProductId, entity.Name, entity.Photo, entity.UnitPrice, entity.Sku, entity.Brand, entity.Model, entity.Quantity, entity.Already };
			return Context.Database.SqlQuery<WishList>("dbo.usp_WishListInsert @EventId={0}, @ProductId={1}, @Name={2}, @Photo={3}, @UnitPrice={4}, @Sku={5}, @Brand={6}, @Model={7}, @Quantity={8}, @Already={9}", parameters).FirstOrDefault();
		}

		public bool Delete(WishList entity)
		{
			object[] parameters = new object[] { entity.WishListId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_WishListDelete @WishListId={0}", parameters) == -1 ? true : false);
		}

	}
}
