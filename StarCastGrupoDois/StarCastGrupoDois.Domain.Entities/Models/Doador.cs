using StarCastGrupoDois.Domain.Entities.Core;
using StarCastGrupoDois.Domain.Entities.ValueObject;
using System.Collections.Generic;

namespace StarCastGrupoDois.Domain.Entities.Models
{
    public class Doador : EntidadeBase
    {

        protected Doador() { }

        public Doador(string email, string nome, long telefone, string cidade)
        {
            Email = new Email(email);
            Nome = nome;
            Telefone = telefone;
            Endereco = new Endereco(cidade);
        }

        public Doador(Email email, string nome, long telefone, Endereco endereco)
        {
            Email = email;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }

        public Email Email { get; private set; }

        public string Nome { get; private set; }

        public long Telefone { get; private set; }

        public Endereco Endereco { get; private set; }

        public ICollection<AlertaDoador> AlertasConfirmados { get; private set; }
    }
}
