using System.ComponentModel.DataAnnotations;

namespace StarCastGrupoDois.Domain.Entities.Fixed
{
    public enum TipoSangue
    {
        [Display(Name = "A +")]
        A_POSITIVO = 1,
        [Display(Name = "A -")]
        A_NEGATIVO,
        [Display(Name = "B +")]
        B_POSITIVO,
        [Display(Name = "B -")]
        B_NEGATIVO,
        [Display(Name = "AB +")]
        AB_POSITIVO,
        [Display(Name = "AB -")]
        AB_NEGATIVO,
        [Display(Name = "O +")]
        O_POSITIVO,
        [Display(Name = "O -")]
        O_NEGATIVO
    }
}
