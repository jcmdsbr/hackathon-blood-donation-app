using StarCastGrupoDois.Domain.Entities.Fixed;
using StarCastGrupoDois.Domain.Entities.Models;
using StarCastGrupoDois.Infra.CrossCutting.Messages;
using System.ComponentModel.DataAnnotations;

namespace StarCastGroupDois.UI.Site.Models
{
    public class DoacaoViewModel
    {
        public DoacaoViewModel()
        {

        }

        public DoacaoViewModel(string descricao, TipoDoacao tipoDoacao)
        {
            Descricao = descricao;
            TipoDoacao = tipoDoacao;
        }

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

        public static explicit operator DoacaoViewModel(Doacao doacao)
        {
            if (doacao == null)
                return null;

            return new DoacaoViewModel(doacao.Descricao, doacao.TipoDoacao);
        }
    }
}
