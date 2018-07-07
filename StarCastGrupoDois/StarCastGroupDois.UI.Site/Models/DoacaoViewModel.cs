using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using StarCastGrupoDois.Infra.CrossCutting.Messages;

namespace StarCastGroupDois.UI.Site.Models
{
    public class DoacaoViewModel
    {
        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        public string DescricaoSangue { get; set; }
        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        public string Descricao { get; set; }
        [Required(ErrorMessage = Mensagem.CAMPO_OBRIGATORIO)]
        public TipoDoacao TipoDoacao { get; set; }
    }
}
