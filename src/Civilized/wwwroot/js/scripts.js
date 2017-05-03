$(document).ready(function () {
    $('.hello-ajax').click(function () {
        $.ajax({
            type: 'GET',
            url: '/Home/HelloAjax',
            success: function (result) {
                $('#result1').html(result);
                console.log(result);
            }
        });
    });
});