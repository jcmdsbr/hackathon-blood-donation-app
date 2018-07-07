$(function () {
    jsDoacaoIndex.acoes.validarTipoDoacao();
    jsDoacaoIndex.listener();
});
var jsDoacaoIndex = {
    listener: function () {
        jsDoacaoIndex.acoes.carregar();
    },
    acoes: {
        carregar: function () {
            this.change();
            this.salvar();
        },
        change: function () {
            $("#drpTipoDoacao").on('change', function () {
                jsDoacaoIndex.acoes.validarTipoDoacao();
            });
        },
        salvar: function () {
        },
        validarTipoDoacao: function () {
            if ($("#drpTipoDoacao").val() == tipoDoacaoSangue) {
                $("#divTipoSangue").show();
                $("#divDescricao").hide();
            }
            else {
                $("#divTipoSangue").hide();
                $("#divDescricao").show();
            }
        }
    },
};