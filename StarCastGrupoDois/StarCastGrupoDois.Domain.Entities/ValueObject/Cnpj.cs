using StarCastGrupoDois.Domain.Entities.Core;
using StarCastGrupoDois.Infra.CrossCutting.Extensions;
using System;

namespace StarCastGrupoDois.Domain.Entities.ValueObject
{
    public class Cnpj : ValueObject<Cnpj>
    {
        protected Cnpj() { }

        public Cnpj(string value)
        {
            Numero = value.UnMask();
        }

        public string Numero { get; private set; }

        public string Formatar => Convert.ToUInt64(Numero).ToString(@"00\.000\.000/0000-00");


        protected override bool EqualsCore(Cnpj other)
        {
            return Numero == other.Numero;
        }

        public override string ToString()
        {
            return Formatar;
        }

        protected override int GetHashCodeCore()
        {
            return Numero.GetHashCode();
        }
    }
}