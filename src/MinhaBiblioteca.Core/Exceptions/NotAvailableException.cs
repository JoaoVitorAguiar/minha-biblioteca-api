namespace MinhaBiblioteca.Core.Exceptions;
public class NotAvailableException: Exception
{
    public NotAvailableException(Type entityType) : base($"{entityType.Name} not found")
    { }
}
