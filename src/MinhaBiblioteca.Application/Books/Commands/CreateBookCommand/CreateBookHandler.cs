using MediatR;
using MinhaBiblioteca.Core.Entities;
using MinhaBiblioteca.Core.Exceptions;
using MinhaBiblioteca.Core.Repositories;

namespace MinhaBiblioteca.Application.Books.Commands.CreateBookCommand;

public class CreateBookHandler : IRequestHandler<CreateBookCommand, Unit>
{
   private readonly IBookRepository _bookRepository;
    private readonly ICategoryRepository _categoryRepository;

    public CreateBookHandler(IBookRepository bookRepository, ICategoryRepository categoryRepository)
    {
        _bookRepository = bookRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Unit> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(request.CategoryId) ?? throw new NotFoundException(typeof(Category));
        var book = new Book(request.Title, request.ISBN, request.Author, request.PublishedDate, category.Id);
        await _bookRepository.CreateAsync(book);
        return Unit.Value;
    }
}
