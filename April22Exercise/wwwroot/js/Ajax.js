$(() => {

    $("#my-btn").on('click', function () {
        let reversed = $("#textbox").val();
        $.get(`/home/reverser?x=${reversed}`, function (obj) {
            $("#my-h1").text(obj);
        });
    })
})