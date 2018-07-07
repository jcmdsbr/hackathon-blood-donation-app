using StarCastGrupoDois.Domain.Entities.Core;

namespace StarCastGrupoDois.Domain.Entities.ValueObject
{
    public class Endereco : ValueObject<Endereco>
    {
        protected Endereco()
        {
        }

        public Endereco(string cidade)
        {
            Cidade = cidade;
        }

        public override string ToString()
        {
            return Cidade;
        }

        public string GetCidade => Cidade;

        public string Cidade { get; private set; }

        protected override bool EqualsCore(Endereco other)
        {
            return Cidade == other.Cidade;
        }

        protected override int GetHashCodeCore()
        {
            return Cidade.GetHashCode();
        }
    }
}
