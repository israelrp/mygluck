using System;
using MyGluck.Domain;
namespace MyGluck.Dal.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Delete operation
	/// </summary>
	public interface IDelete<TEntity> where TEntity : MyGluck.Domain.Base.BaseObjectDomain
	{
		bool Delete(TEntity entity);
	}
}
