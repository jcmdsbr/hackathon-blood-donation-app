using StarCastGrupoDois.Domain.Entities.Core;
using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.Collections.Generic;

namespace StarCastGrupoDois.Domain.Entities.Models
{
    public class Alerta : EntidadeBase
    {

        protected Alerta() { }

        public Alerta(TipoAlerta tipoAlerta, Doacao doacao)
        {
            TipoAlerta = tipoAlerta;
            Doacao = doacao;
            CodigoDoacao = doacao.Codigo;
        }

        public TipoAlerta TipoAlerta { get; private set; }

        public DateTime DataEmissao { get; private set; }

        public DateTime? DataConclusao { get; private set; }

        public Guid CodigoDoacao { get; private set; }

        public Doacao Doacao { get; private set; }

        public ICollection<AlertaDoador> DoadoresConfirmados { get; private set; }

        public void CriarEmissaoDeAlerta() => DataEmissao = DateTime.Now;

        public void CriarDataConclusao(DateTime dataConclusao) => DataConclusao = dataConclusao;

    }
}
