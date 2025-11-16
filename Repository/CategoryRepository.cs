using System;
using PsCoreDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace PsCoreDemo.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly MarketShopDbContext _marketShopDbContext;

    public CategoryRepository(MarketShopDbContext marketShopDbContext)
    {
        _marketShopDbContext = marketShopDbContext;
    }

    public IEnumerable<Category> GetAllCategories()
    {
        // Return categories ordered by Name
        return _marketShopDbContext.Categories.OrderBy(c => c.Name);
    }
}
