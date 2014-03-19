using System;
using MyGluck.Dal.IGenerics;
using MyGluck.Domain;
namespace MyGluck.Dal
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Interfaz para CRUD
	/// </summary>
	public interface webpages_MembershipDao : ISelect<webpages_Membership>, IUpdate<webpages_Membership>, IInsert<webpages_Membership>, IDelete<webpages_Membership>
	{
	}
}
