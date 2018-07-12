using StarCastGrupoDois.Infra.CrossCutting.Messages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StarCastGroupDois.UI.Site.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = MensagensGerais.CAMPO_OBRIGATORIO)]
        [DisplayName("Nome")]
        public string Username { get; set; }

        [Required(ErrorMessage = MensagensGerais.CAMPO_OBRIGATORIO)]
        [DisplayName("Nome")]
        public string Password { get; set; }
    }
}