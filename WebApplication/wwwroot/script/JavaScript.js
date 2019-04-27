// В данную структуру копируются данные из JSON
var local_images = [{

}]

// инициализация кнопок
$(document).ready(function () {
    $("#mainButton").click(function () {
        sendRequest();
    });

    $("#clearButton").click(function () {
        clear();
    });
});

// Загрзить данные о галерее изображений
function sendRequest() {
    $.getJSON("http://localhost:5000/gallery", function (result) {
        if (typeof result !== 'undefined') {
            process(result);
            local_images = JSON.stringify(result);
            console.log(JSON.stringify(result));
            console.log(local_images);
        }
    }).fail(function () {
        alert("Произошла ошибка! Возможно удаленный хост недоступен.");
    });
}

// Выдача галереи
function process(gallery) {
    // Очищаем содержимое
    clear();

    $('#heading').append(gallery.title);

    $.each(gallery.images, function (index, value) {
        $('#content').append('<img class="card-img-top" src="' + value.link + '"width="594" height="100"">');
    });

}

// 1. Показ изображений с увеличением из уменьшенной копии
$(document).ready(function () {
    start_height = 100;
    start_width = 100;

    new_height = 500;
    new_width = 500;

    $(".img").hover(function () {
        $(this).attr('height', new_height);
        $(this).attr('width', new_width);
    },
        function () {
            $(this).attr('height', start_height);
            $(this).attr('width', start_width);
        });
});

// Функция очистки экрана
function clear() {
    $('#content').html('');
    $('#heading').html('');
}