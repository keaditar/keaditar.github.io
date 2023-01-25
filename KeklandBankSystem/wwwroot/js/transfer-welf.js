$(document).ready(function () {
    $('.input-check').change(function () {
        var value = $('.input-check').val();
        var new_value = +value;

        new_value = value * 90;
 
        $('.money-changing').text(Math.ceil(new_value));

        new_value = 0;
    });
});