using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TL.DAL.ORM;

namespace TL.DAL
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryBase<T> : IDisposable, IRepository<T> where T : class
    {
        #region Local resource declarations
        /// <summary>
        /// 
        /// </summary>
        private DbContext dbContext = null;
        #endregion

        #region Object construction
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public RepositoryBase(TravelManagementEntities context)
        {
            dbContext = context;
        }
        #endregion

        #region IRepository<T> implimentation
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public T Get(string Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            var se = dbContext.Set<T>().First();
            return dbContext.Set<T>().ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public T Find(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Find(predicate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            return dbContext.Set<T>().Where(predicate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(T entity)
        {
            var retVal = false;
            dbContext.Set<T>().Add(entity);
            var rowsAffected = dbContext.SaveChanges();
            retVal = rowsAffected > 0;
            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(T entity)
        {
            var retVal = false;
            dbContext.Set<T>().Add(entity);
            dbContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Modified;
            var rowsAffected = dbContext.SaveChanges();
            retVal = rowsAffected > 0;
            return retVal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Delete(T entity)
        {
            var retVal = false;
            dbContext.Set<T>().Remove(entity);
            var rowsAffected = dbContext.SaveChanges();
            retVal = rowsAffected > 0;
            return retVal;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public virtual void Dispose()
        {
        }
    }
}
