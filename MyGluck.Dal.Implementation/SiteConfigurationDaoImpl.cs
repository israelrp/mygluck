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
	public class SiteConfigurationDaoImpl : Abstracts.BaseDaoImpl, SiteConfigurationDao
	{
		public List<SiteConfiguration> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<SiteConfiguration>("dbo.usp_SiteConfigurationsSelect @EventId={0}", parameters).ToList();
		}

		public SiteConfiguration SelectByKey(SiteConfiguration entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return Context.Database.SqlQuery<SiteConfiguration>("dbo.usp_SiteConfigurationsSelect @EventId={0}", parameters).FirstOrDefault();
		}

		public SiteConfiguration Update(SiteConfiguration entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.BackgroundImage, entity.BackgroudHexa, entity.BackgroundImageFooter, entity.BackgroudHexaFooter, entity.BackgroundImageHeader, entity.BackgroudHexaHeader };
			return Context.Database.SqlQuery<SiteConfiguration>("dbo.usp_SiteConfigurationsUpdate @EventId={0}, @BackgroundImage={1}, @BackgroudHexa={2}, @BackgroundImageFooter={3}, @BackgroudHexaFooter={4}, @BackgroundImageHeader={5}, @BackgroudHexaHeader={6}", parameters).FirstOrDefault();
		}

		public SiteConfiguration Insert(SiteConfiguration entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.BackgroundImage, entity.BackgroudHexa, entity.BackgroundImageFooter, entity.BackgroudHexaFooter, entity.BackgroundImageHeader, entity.BackgroudHexaHeader };
			return Context.Database.SqlQuery<SiteConfiguration>("dbo.usp_SiteConfigurationsInsert @EventId={0}, @BackgroundImage={1}, @BackgroudHexa={2}, @BackgroundImageFooter={3}, @BackgroudHexaFooter={4}, @BackgroundImageHeader={5}, @BackgroudHexaHeader={6}", parameters).FirstOrDefault();
		}

		public bool Delete(SiteConfiguration entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_SiteConfigurationsDelete @EventId={0}", parameters) == -1 ? true : false);
		}

	}
}
