using StarCastGrupoDois.Domain.Entities.Core;
using System.Text.RegularExpressions;

namespace StarCastGrupoDois.Domain.Entities.ValueObject
{
    public class Email : ValueObject<Email>
    {
        protected Email() { }

        public Email(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }

        public bool EmailValido()
        {
            var rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            return rg.IsMatch(Descricao);
        }

        public override string ToString()
        {
            return Descricao;
        }

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