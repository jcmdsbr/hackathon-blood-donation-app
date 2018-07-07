using StarCastGrupoDois.Domain.Entities.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarCastGrupoDois.Domain.Entities.Models
{
    public class Doacao : EntidadeBase
    {
        protected Doacao() { }

        public Doacao(TipoDoacao tipoDoacao, string descricao, bool isEmitirAviso)
        {
            TipoDoacao = tipoDoacao;
            Descricao = descricao;
            IsEmitirAviso = isEmitirAviso;
        }

        public TipoDoacao TipoDoacao { get; set; }

        public string Descricao { get; set; }

        public ICollection<Alerta> AlertasEmitidos { get; private set; }

        [NotMapped]
        public bool IsEmitirAviso { get; set; }

    }
}
