$(document).ready(function () {

    $('.nav-link').click(function (e) {
        var url = $(this).attr('href');
        e.preventDefault();
        Navigate(url);
    });

});

var Navigate = function (urlLink) {

    $.ajax({
        method: 'GET',
        url: '../'+urlLink,
        success: function (result) {
            debugger;
            $('#content-wrapper').empty();
            $('#content-wrapper').html(result);
        }
    });
}