using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Repository.Core
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
