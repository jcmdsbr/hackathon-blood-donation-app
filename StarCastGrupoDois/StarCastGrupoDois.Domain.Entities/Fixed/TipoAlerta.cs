using System.ComponentModel.DataAnnotations;

namespace StarCastGrupoDois.Domain.Entities.Fixed
{
    public enum TipoAlerta
    {
        [Display(Name = "Aguardando")]
        AguardandoDoacao = 1,
        Finalizado,
        Cancelado
    }
}
