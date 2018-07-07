using StarCastGrupoDois.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarCastGrupoDois.Application.Domain.Alerta
{
    public interface  IEnvioEmailService
    {
        void Enviar(string mensagem, List<Email> emails);
    }
}
