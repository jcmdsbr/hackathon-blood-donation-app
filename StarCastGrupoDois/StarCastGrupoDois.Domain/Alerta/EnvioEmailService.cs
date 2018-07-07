using StarCastGrupoDois.Domain.Entities.ValueObject;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Linq;
using StarCastGrupoDois.Application.Domain.Alerta;

namespace StarCastGrupoDois.Domain.Alerta
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
