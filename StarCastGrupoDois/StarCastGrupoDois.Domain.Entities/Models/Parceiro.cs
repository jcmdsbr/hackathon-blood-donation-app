using StarCastGrupoDois.Domain.Entities.Core;
using StarCastGrupoDois.Domain.Entities.ValueObject;

namespace StarCastGrupoDois.Domain.Entities.Models
{
    public class Parceiro : EntidadeBase
    {
        protected Parceiro() { }

        public Parceiro(string cnpj, string nome, string desconto)
        {
            Cnpj = new Cnpj(cnpj);
            Nome = nome;
            Desconto = desconto;
        }

        public Cnpj Cnpj { get; private set; }
        public string Nome { get; private set; }
        public string Desconto { get; private set; }

    }
}
