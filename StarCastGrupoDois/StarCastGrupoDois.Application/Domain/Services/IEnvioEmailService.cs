using System.Collections.Generic;
using StarCastGrupoDois.Domain.Entities.ValueObject;

namespace StarCastGrupoDois.Application.Domain.Services
{
    public interface IEnvioEmailService
    {
        void Enviar(string mensagem, List<Email> emails);
    }
}