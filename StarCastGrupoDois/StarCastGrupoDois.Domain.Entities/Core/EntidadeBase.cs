using System;

namespace StarCastGrupoDois.Domain.Entities.Core
{
    public abstract class EntidadeBase
    {
        public Guid Codigo { get; protected set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as EntidadeBase;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Codigo.Equals(compareTo.Codigo);
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode() * 907 + Codigo.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Codigo=" + Codigo + "]";
        }

        public virtual void CriarNovoCodigo()
        {
            Codigo = Guid.NewGuid();
        }
    }
}
