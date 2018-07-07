using StarCastGrupoDois.Application.Domain.Core;
using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Domain.Doador
{
    public interface IDoadorQuery : IQuery<StarCastGrupoDois.Domain.Entities.Models.Doador>
    {
        List<Email> GetAllEmails();
    }
}
