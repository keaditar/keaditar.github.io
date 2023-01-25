$(document).on("input", function (ev) {
    var block = ev.target;
    if ($(block).hasClass("js-casino-input")) {
        var text = $(ev.target).val();

        if ($(block).hasClass("js-percemtal")) {

            $(block).val(text.replace(/[,]/g, '.')
                .replace(/[^\d,.]*/g, '')
                .replace(/([,.])[,.]+/g, '$1')
                .replace(/^[^\d]*(\d+([.,]\d{0,2})?).*$/g, '$1'));

            if (+text > 95) {
                $('.js-percemtal').val(95);
            }
        }
        else {
            $(block).val(text.replace(/[,]/g, '.')
                .replace(/[^\d,.]*/g, '')
                .replace(/([,.])[,.]+/g, '$1')
                .replace(/^[^\d]*(\d+([.,]\d{0,2})?).*$/g, '$1'));
        }


        var sum = parseFloat($(".js-sum").val());
        var proc = parseFloat($(".js-procent").val());

        var n = (100 / proc * sum).toFixed(2);

        $(".js-winBet").text(n);

        $(".js-bar-casino").css("width", proc + "%")
    }
    else if (($(block).hasClass("js-coins-buy"))) {
        var text = $(ev.target).val();

        $(block).val(text.replace(/[,]/g, '.')
            .replace(/[^\d,.]*/g, '')
            .replace(/([,.])[,.]+/g, '$1')
            .replace(/^[^\d]*(\d+([.,]\d{0,2})?).*$/g, '$1'));

        if ($(block).hasClass("js-95x")) {
            $(".js-coins-item").text(($(".js-coins-buy").val() * 95).toFixed(2));
        }
        else {
            $(".js-coins-item").text(($(".js-coins-buy").val() * 100).toFixed(2));
        }
    }
});

var off = false;

$(document).on("click", ".js-game-button", function () {
    if (off == false) {

        if (!isNaN($(".js-winBet").text())) {

            off = true;
            $(".js-info-block").text("Подождите...");

            var sum = parseFloat($(".js-sum").val());
            var proc = parseFloat($(".js-procent").val());

            $.ajax({
                url: '/Bank/CasinoMinMaxApply?sum=' + sum + '&procent=' + proc,
                type: 'POST',

                complete: function (data) {
                    var ret = JSON.parse(data.responseText);

                    if (ret.type == "win") {
                        $(".js-info-block").removeClass("inf").removeClass("err").addClass("succ");
                        $(".js-info-block").text(ret.message);

                        $('.odometer').text(ret.coins);
                    }
                    else if (ret.type = "nowin") {
                        $(".js-info-block").removeClass("inf").removeClass("succ").addClass("err");
                        $(".js-info-block").text(ret.message);

                        $('.odometer').text(ret.coins);
                    }
                    else {
                        $(".js-info-block").removeClass("inf").removeClass("succ").addClass("err");
                        $(".js-info-block").text(ret.message);
                    }

                    off = false;
                }
            });
        }
    }
 });