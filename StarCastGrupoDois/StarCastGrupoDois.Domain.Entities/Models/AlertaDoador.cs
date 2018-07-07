using System;

namespace StarCastGrupoDois.Domain.Entities.Models
{
    public class AlertaDoador
    {

        public AlertaDoador(Doador doador, Alerta alerta)
        {
            Doador = doador;
            Alerta = alerta;
            CodigoAlerta = alerta.Codigo;
            CodigoDoador = doador.Codigo;
        }

        protected AlertaDoador() { }

        public Guid CodigoAlerta { get; private set; }
        public Guid CodigoDoador { get; private set; }
        public Doador Doador { get; private set; }
        public Alerta Alerta { get; private set; }

        public override bool Equals(object obj)
        {
            var compareTo = obj as AlertaDoador;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return CodigoAlerta.Equals(compareTo.CodigoAlerta) && CodigoDoador.Equals(compareTo.CodigoDoador);
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode() * 907 + CodigoAlerta.GetHashCode() + CodigoDoador.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Codigo=" + CodigoAlerta.GetHashCode() + CodigoDoador.GetHashCode() + "]";
        }
    }
}

