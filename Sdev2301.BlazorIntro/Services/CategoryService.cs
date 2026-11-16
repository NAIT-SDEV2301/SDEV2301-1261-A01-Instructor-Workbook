using Microsoft.EntityFrameworkCore;
using Sdev2301.BlazorIntro.Data;
using Sdev2301.BlazorIntro.Models;

namespace Sdev2301.BlazorIntro.Services
{
    public class CategoryService
    {
        private readonly IDbContextFactory<AppDbContext> _dbFactory;

        public CategoryService(IDbContextFactory<AppDbContext> dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            await using var context = await _dbFactory.CreateDbContextAsync();

            return await context.Categories
                .AsNoTracking()
                .OrderBy(category => category.Name)
                .ToListAsync();
        }
    }
}
