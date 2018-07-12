$(function() {
    jsDoacaoIndex.acoes.validarTipoDoacao();
    jsDoacaoIndex.listener();
});
var jsDoacaoIndex = {
    listener: function() {
        jsDoacaoIndex.acoes.carregar();
    },
    acoes: {
        carregar: function() {
            this.change();
            this.click();
        },
        change: function() {
            $("#drpTipoDoacao").on("change",
                function() {
                    jsDoacaoIndex.acoes.validarTipoDoacao();
                });
        },
        click: function() {
            $("#btnEmitirAviso").on("click",
                function() {
                    event.preventDefault();
                    $("#isEmitirAviso").val(true);
                    $("#formDoacao").submit();
                });
        },
        validarTipoDoacao: function() {
            if ($("#drpTipoDoacao").val() == tipoDoacaoSangue) {
                $("#divTipoSangue").show();
                $("#divDescricao").hide();
            } else {
                $("#divTipoSangue").hide();
                $("#divDescricao").show();
            }
        }
    },
};