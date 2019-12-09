// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(function () {
    $(".expand").slice(0, 1).show();
    $("#loadMore").on('click', function (e) {
        e.preventDefault();
        $(".expand:hidden").slice(0, 1).slideDown();
        if ($(".expand:hidden").length == 0) {
            $("#load").fadeOut('slow');
        }
        $('html,body').animate({
            scrollTop: $(this).offset().top
        }, 1500);
    });
});
