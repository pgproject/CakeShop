using System;

namespace CakeShop.Models;

public class CategoryRepository : ICategoryRepository
{
    private readonly CakeShopDbContext _cakeShopDbContext;


    public IEnumerable<Category> AllCategories
    {
        get
        {
            return _cakeShopDbContext.Categories.OrderBy(c => c.CategoryName);
        }
    }


    public CategoryRepository(CakeShopDbContext cakeShopDbContext)
    {
        _cakeShopDbContext = cakeShopDbContext;
    }
}
