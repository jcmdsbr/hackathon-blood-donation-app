using StarCastGrupoDois.Application.Domain.Core;
using StarCastGrupoDois.Application.Repository.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Domain.Alerta
{
    public interface IAlertaService : IService<StarCastGrupoDois.Domain.Entities.Models.Alerta>
    {
        void AlterarStatus(Guid codigo, TipoAlerta tipoAlerta);
        ICollection<StarCastGrupoDois.Domain.Entities.Models.Alerta> BuscarAlertas();
    }
}
