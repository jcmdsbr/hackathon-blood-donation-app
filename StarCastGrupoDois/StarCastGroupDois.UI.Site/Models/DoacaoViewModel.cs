using StarCastGrupoDois.Domain.Entities.Fixed;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using StarCastGrupoDois.Infra.CrossCutting.Messages;
using StarCastGrupoDois.Domain.Entities.Models;

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
        public bool IsEmitirAviso { get; set; }

        public static implicit operator Doacao(DoacaoViewModel model)
        {
            if (model == null)
                return null;

            var descricao = model.Descricao == null ? model.DescricaoSangue : model.Descricao;

            return new Doacao(model.TipoDoacao, descricao, model.IsEmitirAviso);
        }
    }
}
