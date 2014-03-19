using System;
using System.Collections.Generic;
using MyGluck.Domain;
namespace MyGluck.Dal.IGenerics
{
	/// <summary>
	/// Autor: Novatek generator
	/// Comentarios: Interface for support Update operation
	/// </summary>
	public interface ISelect<TEntity> where TEntity : MyGluck.Domain.Base.BaseObjectDomain
	{
		List<TEntity> SelectAll();
		TEntity SelectByKey(TEntity entity);
	}
}
