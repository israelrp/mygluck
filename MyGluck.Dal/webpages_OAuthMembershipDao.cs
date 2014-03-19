using System;
using MyGluck.Dal.IGenerics;
using MyGluck.Domain;
namespace MyGluck.Dal
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Interfaz para CRUD
	/// </summary>
	public interface webpages_OAuthMembershipDao : ISelect<webpages_OAuthMembership>, IUpdate<webpages_OAuthMembership>, IInsert<webpages_OAuthMembership>, IDelete<webpages_OAuthMembership>
	{
	}
}
