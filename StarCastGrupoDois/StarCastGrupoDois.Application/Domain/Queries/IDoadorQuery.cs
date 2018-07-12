using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Domain.Entities.ValueObject;
using System.Collections.Generic;

namespace StarCastGrupoDois.Application.Domain.Queries
{
    public interface IDoadorQuery : IQuery<Doador>
    {
        List<Email> GetAllEmails();
    }
}