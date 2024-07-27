using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace MinhaBiblioteca.Infrastructure.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly MinhaBibliotecaDbContext _dbContext;

    public CategoryRepository(MinhaBibliotecaDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        await _dbContext.Categories.AddAsync(category);
        await _dbContext.SaveChangesAsync();
        return category;
    }

    public async Task<Category> DeleteAsync(Category category)
    {
        _dbContext.Categories.Remove(category);
        await _dbContext.SaveChangesAsync();
        return category;
    }

    public async Task<IList<Category>> GetAllAsync()
    {
        return await _dbContext.Categories.ToListAsync();
    }

    public async Task<Category?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Categories.FindAsync(id);
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        _dbContext.Categories.Update(category);
        await _dbContext.SaveChangesAsync();
        return category;
    }
}
