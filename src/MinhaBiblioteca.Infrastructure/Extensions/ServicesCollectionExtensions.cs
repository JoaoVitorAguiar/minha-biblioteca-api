using Microsoft.Extensions.DependencyInjection;
using MinhaBiblioteca.Core.Services;
using MinhaBiblioteca.Infrastructure.Services;

namespace MinhaBiblioteca.Infrastructure.Extensions;

public static class ServicesCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();

        return services;
    }
}
