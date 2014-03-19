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
	public class InvitationSettingDaoImpl : Abstracts.BaseDaoImpl, InvitationSettingDao
	{
		public List<InvitationSetting> SelectAll()
		{
			object[] parameters = new object[] { null };
			return Context.Database.SqlQuery<InvitationSetting>("dbo.usp_InvitationSettingsSelect @EventId={0}", parameters).ToList();
		}

		public InvitationSetting SelectByKey(InvitationSetting entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return Context.Database.SqlQuery<InvitationSetting>("dbo.usp_InvitationSettingsSelect @EventId={0}", parameters).FirstOrDefault();
		}

		public InvitationSetting Update(InvitationSetting entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.BackgroudImage, entity.BackgroudColor, entity.FontType, entity.FontSizeHeader, entity.FontSizeBody, entity.FontSizeFooter, entity.FontColorHeader, entity.FontColorBody, entity.FontColorFooter, entity.HeaderText, entity.BodyText, entity.FooterText, entity.LogoImage };
			return Context.Database.SqlQuery<InvitationSetting>("dbo.usp_InvitationSettingsUpdate @EventId={0}, @BackgroudImage={1}, @BackgroudColor={2}, @FontType={3}, @FontSizeHeader={4}, @FontSizeBody={5}, @FontSizeFooter={6}, @FontColorHeader={7}, @FontColorBody={8}, @FontColorFooter={9}, @HeaderText={10}, @BodyText={11}, @FooterText={12}, @LogoImage={13}", parameters).FirstOrDefault();
		}

		public InvitationSetting Insert(InvitationSetting entity)
		{
			object[] parameters = new object[] { entity.EventId, entity.BackgroudImage, entity.BackgroudColor, entity.FontType, entity.FontSizeHeader, entity.FontSizeBody, entity.FontSizeFooter, entity.FontColorHeader, entity.FontColorBody, entity.FontColorFooter, entity.HeaderText, entity.BodyText, entity.FooterText, entity.LogoImage };
			return Context.Database.SqlQuery<InvitationSetting>("dbo.usp_InvitationSettingsInsert @EventId={0}, @BackgroudImage={1}, @BackgroudColor={2}, @FontType={3}, @FontSizeHeader={4}, @FontSizeBody={5}, @FontSizeFooter={6}, @FontColorHeader={7}, @FontColorBody={8}, @FontColorFooter={9}, @HeaderText={10}, @BodyText={11}, @FooterText={12}, @LogoImage={13}", parameters).FirstOrDefault();
		}

		public bool Delete(InvitationSetting entity)
		{
			object[] parameters = new object[] { entity.EventId };
			return (Context.Database.ExecuteSqlCommand("dbo.usp_InvitationSettingsDelete @EventId={0}", parameters) == -1 ? true : false);
		}

	}
}
