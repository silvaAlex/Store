using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        bool Commit();
    }
}
