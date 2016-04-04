using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TL.DAL
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RepositoryBase<T> : IRepository<T> where T:class
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
        public RepositoryBase(DbContext context)
        {
            dbContext = context;
        }
        #endregion

        #region IRepository<T> implimentation
        public T Get(string Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
