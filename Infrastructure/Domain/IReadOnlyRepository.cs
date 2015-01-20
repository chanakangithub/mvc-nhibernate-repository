using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Domain
{
    public interface IReadOnlyRepository<T, TId>
    {
        T FindById(TId id);

        IEnumerable<T> FindAll();
    }
}
