using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TL.DAL
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T Get(string Id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<T> FindAll(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        bool Add(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entiry"></param>
        /// <returns></returns>
        bool Update(T entiry);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        bool Delete(T entity);
    }
}
