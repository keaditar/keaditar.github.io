$(document).on("click", ".identity-url-menu", function () {
    identity_sett(".identity-url-menu", ".identity-menu-container");
    $('.identity-menu-container-admin').fadeOut();
    $('.identity-menu-container').fadeToggle();
    $('.submenu').fadeOut();
});

var requestSubmitted = false;

$(document).on("click", ".button", function () {
    if (!requestSubmitted) {
        requestSubmitted = true;
        var el = $(".button");
        $(el).attr("disabled", "disabled");
        $(el).addClass("off");

        var parent = $(el).parents("form").first();
        $(parent).submit();

        setTimeout(function ()
        {
            el.removeClass("off");
            el.removeAttr("disabled");
        }, 2500);
    }
});

$(document).on("click", ".identity-url-admin", function () {
    identity_sett(".identity-url-admin", ".identity-menu-container-admin");
    $('.identity-menu-container').fadeOut();
    $('.identity-menu-container-admin').fadeToggle();
    $('.submenu').fadeOut();
});

$(document).on("click", ".menu-block", function () {
    var data = $(this).attr("data-open");

    $(".sub-ext-" + data).fadeToggle();

    $(".submenu").each(function (f, e) {
        if ($(e).hasClass("sub-ext-" + data) == false) {
            $(e).fadeOut();
        }
    });
});

function prepareImageUpload(ctr) {
    if ($(ctr)[0].files.length > 5) {
        $('.image-inp').val("");
        $(ctr).parent("div").find(".js-imageTexter").text("Максмальное количество: 5");
    }
    else {

        var str = $(ctr)[0].files.length + " загруженных файлов.";
        $(ctr).parent("div").find(".js-imageTexter").text(str);
    }
};


function identity_sett(pos, container) {
    var rect = $(pos).position();

    var w = $(window);
    $(container).css("top", (rect.top + 44) + "px");
    $(container).css("left", (rect.left - 20) + "px");
}



$(document).mouseup(function (e) {
    if (!$(e.target).hasClass('non-target-js') && $(e.target).parent('.non-target-js').length == 0) {
        var div = $(".off-block-onclick");

        if (!div.is(e.target)
            && div.has(e.target).length === 0) {

            $(div).fadeOut();
        }
    }
});
