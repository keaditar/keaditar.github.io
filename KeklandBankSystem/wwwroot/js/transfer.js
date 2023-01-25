$(document).ready(function () {
    $('.input-check').change(function () {
        var value = $('.input-check').val();
        var new_value = +value;

        if (value < 100) {
            new_value += stavka;
        }
        else {
            new_value += (value / 100) * stavka;
        }

        $('.money-changing').text(Math.ceil(new_value));

        new_value = 0;
    });
});

var stavka = GetNalogString();

function GetNalogString() {
    var dat;
    $.ajax({
        url: GetAbsoluteUrlFunc("GetNalogTransfer", "Bank", { }),
        type: 'POST',
        dataType: 'json',
        async: false,

        complete: function (data) {
            dat = JSON.parse(data.responseText);
        }
    });
    return dat;
}

function GetAbsoluteUrlFunc(Actions, Controllers, objects) {
    var dat;
    $.ajax({
        url: '/getAbsoluteUrl?act=' + Actions + '&Controllers=' + Controllers + '&array=' + JSON.stringify(objects),
        type: 'POST',
        data: objects,
        async: false,

        complete: function (data) {
            dat = JSON.parse(data.responseText);
        }
    });

    return dat;
}
