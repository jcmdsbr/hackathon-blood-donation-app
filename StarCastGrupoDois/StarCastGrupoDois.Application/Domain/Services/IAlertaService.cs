using StarCastGrupoDois.Application.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using StarCastGrupoDois.Domain.Entities.Models;
using System;

namespace StarCastGrupoDois.Application.Domain.Services
{
    public interface IAlertaService : IService<Alerta>
    {
        void AlterarStatus(Guid codigo, TipoAlerta tipoAlerta);
    }
}