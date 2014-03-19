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
	public class SectionDaoImpl : Abstracts.BaseDaoImpl, SectionDao
	{
		public List<Section> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Section>("dbo.usp_SectionsSelect @SectionId={0}", parameters).ToList();
		}

		public Section SelectByKey(Section entity)
		{
			object[] parameters = new object[] { entity.SectionId };
			return Context.Database.SqlQuery<Section>("dbo.usp_SectionsSelect @SectionId={0}", parameters).FirstOrDefault();
		}

		public Section Update(Section entity)
		{
			object[] parameters = new object[] { entity.SectionId, entity.EventId, entity.SectionTypeId, entity.Name, entity.SubTitle, entity.Title, entity.Body };
			return Context.Database.SqlQuery<Section>("dbo.usp_SectionsUpdate @SectionId={0}, @EventId={1}, @SectionTypeId={2}, @Name={3}, @SubTitle={4}, @Title={5}, @Body={6}", parameters).FirstOrDefault();
		}

		public Section Insert(Section entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.SectionTypeId, entity.Name, entity.SubTitle, entity.Title, entity.Body };
			return Context.Database.SqlQuery<Section>("dbo.usp_SectionsInsert @EventId={0}, @SectionTypeId={1}, @Name={2}, @SubTitle={3}, @Title={4}, @Body={5}", parameters).FirstOrDefault();
		}

		public bool Delete(Section entity)
		{
			object[] parameters = new object[] { entity.SectionId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_SectionsDelete @SectionId={0}", parameters) == -1 ? true : false);
		}

	}
}
