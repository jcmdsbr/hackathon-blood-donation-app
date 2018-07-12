using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using StarCastGrupoDois.Application.Domain.Services;
using StarCastGrupoDois.Domain.Entities.ValueObject;

namespace StarCastGrupoDois.Domain.Services
{
    public class EnvioEmailService : IEnvioEmailService
    {
        public void Enviar(string mensagem, List<Email> emails)
        {
            var client = new SmtpClient("ARASRVFISMSR002.castmeta.local", 25)
            {
                UseDefaultCredentials = false,

                Credentials = new NetworkCredential("sefin.pmsp", "53f!n@p")
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("starcart@groupodois.com")
            };

            mailMessage.To.Add(string.Join(",", emails.Select(x => x.Descricao)));
            mailMessage.Body = mensagem;

            client.Send(mailMessage);
        }
    }
}