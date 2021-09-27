// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

 //inizilize owlCarousel card-carousel
$(document).ready(function () {

    $(".owl-carousel").owlCarousel({
        autoplayTimeout: 3000,
        autoplayHoverPause: true,
        autoplay: false,
        nav: true,
        dots: true,
        items: 5,
        navText: ["<i class='fas fa-angle-left fa-3x'></i>", "<i class='fas fa-angle-right fa-3x'></i>"],
        responsiveClass: true,
        responsive: {
            0: {
                items: 2,
                nav: false,
            },
            600: {
                items: 4,
                nav: true
            },
            1000: {
                items: 5,
                nav: true,
            }
        }
    });
    //$("#card-carousel").owlCarousel({
        
    //});
});









