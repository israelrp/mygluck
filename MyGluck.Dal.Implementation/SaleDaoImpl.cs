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
	public class SaleDaoImpl : Abstracts.BaseDaoImpl, SaleDao
	{
		public List<Sale> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Sale>("dbo.usp_SalesSelect @SaleId={0}", parameters).ToList();
		}

		public Sale SelectByKey(Sale entity)
		{
			object[] parameters = new object[] { entity.SaleId };
			return Context.Database.SqlQuery<Sale>("dbo.usp_SalesSelect @SaleId={0}", parameters).FirstOrDefault();
		}

		public Sale Update(Sale entity)
		{
			object[] parameters = new object[] { entity.SaleId, entity.WishListId, entity.GuestId, entity.ProductId, entity.Quantity, entity.Name, entity.Description, entity.UnitPrice, entity.Sku, entity.Total, entity.SendEvent };
			return Context.Database.SqlQuery<Sale>("dbo.usp_SalesUpdate @SaleId={0}, @WishListId={1}, @GuestId={2}, @ProductId={3}, @Quantity={4}, @Name={5}, @Description={6}, @UnitPrice={7}, @Sku={8}, @Total={9}, @SendEvent={10}", parameters).FirstOrDefault();
		}

		public Sale Insert(Sale entity)
		{
			object[] parameters = new object[] { entity.WishListId, entity.GuestId, entity.ProductId, entity.Quantity, entity.Name, entity.Description, entity.UnitPrice, entity.Sku, entity.Total, entity.SendEvent };
			return Context.Database.SqlQuery<Sale>("dbo.usp_SalesInsert @WishListId={0}, @GuestId={1}, @ProductId={2}, @Quantity={3}, @Name={4}, @Description={5}, @UnitPrice={6}, @Sku={7}, @Total={8}, @SendEvent={9}", parameters).FirstOrDefault();
		}

		public bool Delete(Sale entity)
		{
			object[] parameters = new object[] { entity.SaleId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_SalesDelete @SaleId={0}", parameters) == -1 ? true : false);
		}

	}
}
