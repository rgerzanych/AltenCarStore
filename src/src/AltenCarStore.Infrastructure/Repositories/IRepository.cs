using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AltenCarStore.Infrastructure.Domain;

namespace AltenCarStore.Infrastructure.Repositories
{
    /// <summary>
    /// Generic entity repository.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T>
        where T : EntityBase
    {
        /// <summary>
        /// Get instance by it's identifier.
        /// </summary>
        /// <param name="id">Instance's identifier.</param>
        /// <returns>Instance of T.</returns>
        Task<T> GetByIdAsync(Guid id);

        /// <summary>
        /// Update instance.
        /// </summary>
        /// <param name="object">Instance to update.</param>
        void Update(T @object);

        /// <summary>
        /// Add instance.
        /// </summary>
        /// <param name="object">Instance to be added.</param>
        void Add(T @object);

        /// <summary>
        /// Get all instances.
        /// </summary>
        /// <returns>Collection of instances.</returns>
        Task<ICollection<T>> GetAllAsync();

        /// <summary>
        /// Find all instances matching predicate.
        /// </summary>
        /// <param name="predicate">Predicate expression.</param>
        /// <returns>Collection of instances.</returns>
        Task<ICollection<T>> FindAsync(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Remove instance.
        /// </summary>
        /// <param name="object">Instance to be removed.</param>
        void Remove(T @object);
    }
}
