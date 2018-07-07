using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using StarCastGrupoDois.Domain.Entities.Models;
using System.ComponentModel;

namespace StarCastGroupDois.UI.Site.Models
{
    public class AlertaViewModel
    {
        public AlertaViewModel(string descricaoDoacao, TipoAlerta tipoAlerta)
        {
            DescricaoDoacao = descricaoDoacao;
            TipoAlerta = tipoAlerta;
        }

        [DisplayName("Doações Cadastradas")]
        public string DescricaoDoacao { get; set; }

        [DisplayName("Status")]
        public TipoAlerta TipoAlerta { get; set; }

        public static explicit operator AlertaViewModel(Alerta alerta)
        {

            if (alerta == null)
                return null;

            return new AlertaViewModel(alerta.Doacao != null ? alerta.Doacao.Descricao : "", alerta.TipoAlerta);
        }

        public Guid Codigo { get; set; }
    }
}
