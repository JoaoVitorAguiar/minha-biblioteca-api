

namespace MinhaBiblioteca.Core.Exceptions;

public class AlreadyExistsException: Exception
{
    public AlreadyExistsException(Type entityType) : base($"{entityType.Name} already exists")
    { }
}
