using StarCastGrupoDois.Infra.CrossCutting.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StarCastGroupDois.UI.Site.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        [DisplayName("Nome")]
        public string Username { get; set; }

        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        [DisplayName("Nome")]
        public string Password { get; set; }
    }
}
