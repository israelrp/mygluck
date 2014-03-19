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
	public class PaymentDaoImpl : Abstracts.BaseDaoImpl, PaymentDao
	{
		public List<Payment> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Payment>("dbo.usp_PaymentsSelect @SaleId={0}", parameters).ToList();
		}

		public Payment SelectByKey(Payment entity)
		{
			object[] parameters = new object[] { entity.SaleId };
			return Context.Database.SqlQuery<Payment>("dbo.usp_PaymentsSelect @SaleId={0}", parameters).FirstOrDefault();
		}

		public Payment Update(Payment entity)
		{
			object[] parameters = new object[] { entity.SaleId, entity.Name };
			return Context.Database.SqlQuery<Payment>("dbo.usp_PaymentsUpdate @SaleId={0}, @Name={1}", parameters).FirstOrDefault();
		}

		public Payment Insert(Payment entity)
		{
			object[] parameters = new object[] { entity.SaleId, entity.Name };
			return Context.Database.SqlQuery<Payment>("dbo.usp_PaymentsInsert @SaleId={0}, @Name={1}", parameters).FirstOrDefault();
		}

		public bool Delete(Payment entity)
		{
			object[] parameters = new object[] { entity.SaleId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_PaymentsDelete @SaleId={0}", parameters) == -1 ? true : false);
		}

	}
}
