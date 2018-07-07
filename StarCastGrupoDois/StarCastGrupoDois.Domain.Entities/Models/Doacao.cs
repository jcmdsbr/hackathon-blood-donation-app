using StarCastGrupoDois.Domain.Entities.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System.Collections.Generic;

namespace StarCastGrupoDois.Domain.Entities.Models
{
    public class Doacao : EntidadeBase
    {
        protected Doacao() { }

        public Doacao(TipoDoacao tipoDoacao, string descricao)
        {
            TipoDoacao = tipoDoacao;
            Descricao = descricao;
        }

        public TipoDoacao TipoDoacao { get; set; }

        public string Descricao { get; set; }

        public ICollection<Alerta> AlertasEmitidos { get; private set; }

    }
}
