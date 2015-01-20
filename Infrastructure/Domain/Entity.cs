using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Domain
{
    public abstract class Entity<TId>
    {
        public virtual TId Id { get; set; }
    }
}
