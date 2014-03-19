using System;
using MyGluck.Domain;
namespace MyGluck.Dal.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Update operation
	/// </summary>
	public interface IUpdate<TEntity> where TEntity : MyGluck.Domain.Base.BaseObjectDomain
	{
		TEntity Update(TEntity entity);
	}
}
