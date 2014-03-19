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
	public class SectionTypeDaoImpl : Abstracts.BaseDaoImpl, SectionTypeDao
	{
		public List<SectionType> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<SectionType>("dbo.usp_SectionTypesSelect @SectionTypeId={0}", parameters).ToList();
		}

		public SectionType SelectByKey(SectionType entity)
		{
			object[] parameters = new object[] { entity.SectionTypeId };
			return Context.Database.SqlQuery<SectionType>("dbo.usp_SectionTypesSelect @SectionTypeId={0}", parameters).FirstOrDefault();
		}

		public SectionType Update(SectionType entity)
		{
			object[] parameters = new object[] { entity.SectionTypeId, entity.Name, entity.Code };
			return Context.Database.SqlQuery<SectionType>("dbo.usp_SectionTypesUpdate @SectionTypeId={0}, @Name={1}, @Code={2}", parameters).FirstOrDefault();
		}

		public SectionType Insert(SectionType entity)
		{
			object[] parameters = new object[] { entity.Name, entity.Code };
			return Context.Database.SqlQuery<SectionType>("dbo.usp_SectionTypesInsert @Name={0}, @Code={1}", parameters).FirstOrDefault();
		}

		public bool Delete(SectionType entity)
		{
			object[] parameters = new object[] { entity.SectionTypeId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_SectionTypesDelete @SectionTypeId={0}", parameters) == -1 ? true : false);
		}

	}
}
