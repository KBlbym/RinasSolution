// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

 //inizilize owlCarousel card-carousel
$(document).ready(function () {
    $(".owl-carousel").owlCarousel({
        nav:true,
        autoplayTimeout: 3000,
        autoplayHoverPause: true,
        autoplay: false,
        dots: false,
        items: 4,
        loop:true,
        navText: ["<i class='fas fa-angle-left fa-2x'></i>", "<i class='fas fa-angle-right fa-2x'></i>"],
        responsiveClass: true,
        responsive: {
            0: {
                items: 1,
                nav: false,
                dots: true,
            },
            600: {
                items: 3,
                nav: true
            },
            1000: {
                items: 4,
                nav: true,
            }
        }
    });
    //$("#card-carousel").owlCarousel({
        
    //});
});









