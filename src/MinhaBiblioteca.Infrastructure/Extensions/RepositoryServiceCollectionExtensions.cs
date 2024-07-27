using Microsoft.Extensions.DependencyInjection;
using MinhaBiblioteca.Core.Repositories;
using MinhaBiblioteca.Infrastructure.Repositories;

namespace MinhaBiblioteca.Infrastructure.Extensions;

public static class RepositoryServiceCollectionExtensions
{
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IBookRepository, BookRepository>();
        services.AddScoped<ILoanRepository, LoanRepository>();
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        return services;
    }
}
