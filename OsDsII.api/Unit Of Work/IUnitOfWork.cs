using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OsDsII.api.UnitOFWork
{
    public interface IUnitOfWork
    {
        public Task SaveChangesAsync();
    }
}