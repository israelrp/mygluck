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
	public class ThemeDaoImpl : Abstracts.BaseDaoImpl, ThemeDao
	{
		public List<Theme> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<Theme>("dbo.usp_ThemesSelect @ThemeId={0}", parameters).ToList();
		}

		public Theme SelectByKey(Theme entity)
		{
			object[] parameters = new object[] { entity.ThemeId };
			return Context.Database.SqlQuery<Theme>("dbo.usp_ThemesSelect @ThemeId={0}", parameters).FirstOrDefault();
		}

		public Theme Update(Theme entity)
		{
			object[] parameters = new object[] { entity.ThemeId, entity.Name, entity.PhotoPreview, entity.Css };
			return Context.Database.SqlQuery<Theme>("dbo.usp_ThemesUpdate @ThemeId={0}, @Name={1}, @PhotoPreview={2}, @Css={3}", parameters).FirstOrDefault();
		}

		public Theme Insert(Theme entity)
		{
			object[] parameters = new object[] { entity.Name, entity.PhotoPreview, entity.Css };
			return Context.Database.SqlQuery<Theme>("dbo.usp_ThemesInsert @Name={0}, @PhotoPreview={1}, @Css={2}", parameters).FirstOrDefault();
		}

		public bool Delete(Theme entity)
		{
			object[] parameters = new object[] { entity.ThemeId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_ThemesDelete @ThemeId={0}", parameters) == -1 ? true : false);
		}

	}
}
