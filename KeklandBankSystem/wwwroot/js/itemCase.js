var off = false;

$(document).on("click", ".js-game-button", function () {
    if (off == false) {

        off = true;
        $(".js-info-block").text("Подождите...");

        $.ajax({
            url: '/Bank/BuyCaseFinal',
            type: 'POST',

            complete: function (data) {
                var ret = JSON.parse(data.responseText);

                if (ret.type == "ok") {
                    $(".money-user").text(+($(".money-user").text() - 2000));
                    $(".js-info-block").removeClass("inf").removeClass("err").addClass("succ");
                    $(".js-info-block").text("Поздравляем!");

                    console.log(ret);

                    var type = "";
                    if (+ret.item.rareType == 0) {
                        type = "Обычная"
                    }
                    else if (+ret.item.rareType == 1) {
                        type = "Дорогая"
                    }
                    else if (+ret.item.rareType == 2) {
                        type = "Редкая"
                    }
                    else if (+ret.item.rareType == 3) {
                        type = "Эпическая"
                    }
                    else if (+ret.item.rareType == 4) {
                        type = "ЛЕГЕНДАРНАЯ"
                    }

                    $(".js-oppener-this").html('<div class="post-item no-padding block-item-rare-' + ret.item.rareType + '" style="width: 24%; margin: 0 auto;">' +
                        '<a class="post-item-name" >' +
                            '<div class="wpg-head">' +
                                '<div class="wrapp-image-cut no-padding">' +
                        '<img class="post-image" src="' + ret.item.imageUrl + '">' +
                        '</div>' +
                        '<span class="post-item-name post-item-name-url">' + ret.item.name + '</span>' +
                                '</div>' +
                        '</a>' +
                            '<div class="wpg-list-info-block">' +
                        '<p class="post-item-text">' + ret.item.short_Desc + '</p>' +
                        '<p class="post-item-date"><i class="fas fa-comment-alt-dollar"></i> Стоимость ' + ret.item.price + ' Мемлар</p>' +
                        '<p class="post-item-date"><i class="fas fa-caret-square-right"></i> Редкость: <span class="text-rare-' + ret.item.rareType + '">' + type + '</span></p>' +
                            '</div>' +
                        '</div >')
                }
                else if (ret.type = "error") {
                    $(".js-info-block").removeClass("inf").removeClass("succ").addClass("err");
                    $(".js-info-block").text(ret.message);
                }

                off = false;
            }
        });
    }
});