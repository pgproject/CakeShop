using System;
using Microsoft.EntityFrameworkCore;

namespace CakeShop.Models;

public class PieRepository : IPieRepository
{
    public IEnumerable<Pie> AllPies
    {
        get
        {
            return _cakeShopDbContext.Pies.Include(p => p.Category);
        }
    }

    public IEnumerable<Pie> PiesOfTheWeek
    {
        get
        {
            return _cakeShopDbContext.Pies.Include(p => p.Category)
                .Where(p => p.IsPieOfTheWeek);
        }
    }

    public Pie? GetPieById(int pieId)
    {
        return _cakeShopDbContext.Pies.Include(p => p.Category)
            .FirstOrDefault(p => p.PieId == pieId);
    }

    private readonly CakeShopDbContext _cakeShopDbContext;

    public PieRepository(CakeShopDbContext cakeShopDbContext)
    {
        _cakeShopDbContext = cakeShopDbContext;
    }
}
