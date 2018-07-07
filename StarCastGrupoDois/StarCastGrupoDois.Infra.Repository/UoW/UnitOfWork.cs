using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Infra.Repository.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Infra.Repository.UoW
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly StarCastGroupoDoisContexto _context;

        public UnitOfWork(StarCastGroupoDoisContexto context)
        {
            _context = context;
        }

        public bool Commit()
        {
            var rowsAffected = _context.SaveChanges();

            return rowsAffected > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
