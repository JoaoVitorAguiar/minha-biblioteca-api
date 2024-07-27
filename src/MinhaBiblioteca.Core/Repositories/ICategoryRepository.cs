using MinhaBiblioteca.Core.Entities;

namespace MinhaBiblioteca.Core.Repositories;

public interface ICategoryRepository
{
    Task<Category> CreateAsync(Category category);
    Task<Category> UpdateAsync(Category category);
    Task<Category?> GetByIdAsync(Guid id);
    Task<Category> DeleteAsync(Category category);
    Task<IList<Category>> GetAllAsync();
}
