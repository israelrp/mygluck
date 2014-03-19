using System;
using MyGluck.Domain;
namespace MyGluck.Dal.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Insert operation
	/// </summary>
	public interface IInsert<TEntity> where TEntity : MyGluck.Domain.Base.BaseObjectDomain
	{
		TEntity Insert(TEntity entity);
	}
}
