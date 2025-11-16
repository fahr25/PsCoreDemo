using System.Collections.Generic;
using PsCoreDemo.Models;

namespace PsCoreDemo.Repository
{
    /// <summary>
    /// Represents the repository for managing category entities.
    /// </summary>
    public interface ICategoryRepository
    {
        /// <summary>
        /// Retrieves all categories.
        /// </summary>
        /// <returns>A collection of all categories.</returns>
        IEnumerable<Category> GetAllCategories();
    }
}