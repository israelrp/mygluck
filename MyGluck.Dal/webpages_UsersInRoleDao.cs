using System;
using MyGluck.Dal.IGenerics;
using MyGluck.Domain;
namespace MyGluck.Dal
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Interfaz para CRUD
	/// </summary>
	public interface webpages_UsersInRoleDao : ISelect<webpages_UsersInRole>, IUpdate<webpages_UsersInRole>, IInsert<webpages_UsersInRole>, IDelete<webpages_UsersInRole>
	{
	}
}
