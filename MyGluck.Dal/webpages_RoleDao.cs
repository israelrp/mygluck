using System;
using MyGluck.Dal.IGenerics;
using MyGluck.Domain
namespace MyGluck.Dal
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Interfaz para CRUD
	/// </summary>
	public interface webpages_RoleDao : ISelect<webpages_Role>, IUpdate<webpages_Role>, IInsert<webpages_Role>, IDelete<webpages_Role>
	{
	}
}