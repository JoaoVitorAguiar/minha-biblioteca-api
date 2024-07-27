using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Core.Entities;

public class Category: BaseEntity
{
    public Category() { }
    public Category(string name) 
    {
        Id = Guid.NewGuid();
        Name = name;
        Books = [];
    }

    public string Name { get; private set; }
    public IList<Book> Books { get; private set; }
}
