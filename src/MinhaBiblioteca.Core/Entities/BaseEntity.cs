using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca.Core.Entities;

public abstract class BaseEntity
{
    protected BaseEntity() { }
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set;}
}
