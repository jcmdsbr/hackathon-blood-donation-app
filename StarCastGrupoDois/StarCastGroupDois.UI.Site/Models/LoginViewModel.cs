using StarCastGrupoDois.Infra.CrossCutting.Messages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StarCastGroupDois.UI.Site.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = MensagensGerais.CAMPO_OBRIGATORIO)]
        [DisplayName("Usuário")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = MensagensGerais.CAMPO_OBRIGATORIO)]
        [DisplayName("Senha")]
        public string Senha { get; set; }
    }
}