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
	public class CategoryDaoImpl : Abstracts.BaseDaoImpl, CategoryDao
	{
		public List<Category> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Category>("dbo.usp_CategoriesSelect @CategoryId={0}", parameters).ToList();
		}

		public Category SelectByKey(Category entity)
		{
			object[] parameters = new object[] { entity.CategoryId };
			return Context.Database.SqlQuery<Category>("dbo.usp_CategoriesSelect @CategoryId={0}", parameters).FirstOrDefault();
		}

		public Category Update(Category entity)
		{
			object[] parameters = new object[] { entity.CategoryId, entity.Name, entity.Photo };
			return Context.Database.SqlQuery<Category>("dbo.usp_CategoriesUpdate @CategoryId={0}, @Name={1}, @Photo={2}", parameters).FirstOrDefault();
		}

		public Category Insert(Category entity)
		{
			object[] parameters = new object[] { entity.Name, entity.Photo };
			return Context.Database.SqlQuery<Category>("dbo.usp_CategoriesInsert @Name={0}, @Photo={1}", parameters).FirstOrDefault();
		}

		public bool Delete(Category entity)
		{
			object[] parameters = new object[] { entity.CategoryId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_CategoriesDelete @CategoryId={0}", parameters) == -1 ? true : false);
		}

	}
}
