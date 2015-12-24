using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp.DataModel.GenericRepository.Interfaces
{
    public interface IGenericRepository<TEntity> : IDisposable
    {
        /// <summary>
        /// Deletes entity in db based on id
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);

        /// <summary>
        /// Generic Delete method for the entities
        /// </summary>
        /// <param name="entityToDelete"></param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Overloaded Delete based on condition
        /// </summary>
        /// <param name="where"></param>
        void Delete(Func<TEntity, Boolean> where);

        /// <summary>
        /// Checks if entity exits
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool EntityExists(object id);

        /// <summary>
        /// Returns Entity based on boolean
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        TEntity Get(Func<TEntity, Boolean> where);

        /// <summary>
        /// Get all the records from db
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// Overloaded GetAll based on condition
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll(Func<TEntity, bool> where);

        /// <summary>
        /// Returns Entities as queryable
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetAllAsQueryable(Func<TEntity, bool> where);

        /// <summary>
        ///Get Entity based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity GetByID(object id);

        /// <summary>
        /// Gets first Entity in db
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity GetFirst(Func<TEntity, bool> predicate);

        /// <summary>
        /// DbSet implementation of single method which returns the only entity matches the predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity GetSingle(Func<TEntity, bool> predicate);

        /// <summary>
        /// Inclue multiple
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="include"></param>
        /// <returns></returns>
        IQueryable<TEntity> GetWithInclude(
             System.Linq.Expressions.Expression<Func<TEntity,
             bool>> predicate, params string[] include);

        /// <summary>
        /// Inserts an entity in to db
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Generic update method for the entities
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
    }
}