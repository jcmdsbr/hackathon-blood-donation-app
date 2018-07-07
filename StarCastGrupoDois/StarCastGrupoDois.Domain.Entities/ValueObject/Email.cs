using StarCastGrupoDois.Domain.Entities.Core;

namespace StarCastGrupoDois.Domain.Entities.ValueObject
{
    public class Email : ValueObject<Email>
    {
        protected Email()
        {
        }

        public Email(string descricao)
        {
            Descricao = descricao;
        }

        public override string ToString()
        {
            return Descricao;
        }

        public string Descricao { get; private set; }

        protected override bool EqualsCore(Email other)
        {
            return Descricao == other.Descricao;
        }

        protected override int GetHashCodeCore()
        {
            return Descricao.GetHashCode();
        }
    }
}
