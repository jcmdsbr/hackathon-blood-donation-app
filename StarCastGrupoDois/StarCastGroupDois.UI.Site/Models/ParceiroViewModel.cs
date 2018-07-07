using StarCastGrupoDois.Infra.CrossCutting.Messages;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StarCastGroupDois.UI.Site.Models
{
    public class ParceiroViewModel
    {
        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        [DisplayName("CNPJ")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        [DisplayName("Benefícios")]
        public string Desconto { get; set; }
    }
}
