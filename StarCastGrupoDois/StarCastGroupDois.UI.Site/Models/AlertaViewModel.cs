using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.ComponentModel;

namespace StarCastGroupDois.UI.Site.Models
{
    public class AlertaViewModel
    {
        [DisplayName("Doações Cadastradas")]
        public string DescricaoDoacao { get; set; }

        [DisplayName("Status")]
        public TipoAlerta TipoAlerta { get; set; }

        public Guid Codigo { get; set; }
    }
}
