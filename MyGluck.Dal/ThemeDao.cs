using System;
using MyGluck.Dal.IGenerics;
using MyGluck.Domain;
namespace MyGluck.Dal
{
	/// <summary>
	/// Autor: Israel Romero Ponce
	/// Comentarios: Interfaz para CRUD
	/// </summary>
	public interface ThemeDao : ISelect<Theme>, IUpdate<Theme>, IInsert<Theme>, IDelete<Theme>
	{
	}
}
