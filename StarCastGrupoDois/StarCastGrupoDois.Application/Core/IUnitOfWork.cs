using System;

namespace StarCastGrupoDois.Application.Core
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}