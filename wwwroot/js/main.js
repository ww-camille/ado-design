$(document).ready(function(){
   
    $(window).scroll(function(){
        
        if ($(window).scrollTop() > 768) {
            $('.navbar').addClass('navbar-fixed-top');
        }
        if ($(window).scrollTop() < 769) {
            $('.navbar').removeClass('navbar-fixed-top');
        }
        
    });  
});


$(".navbar-light ul li a[href^='#']").on('click', function(e) {

   e.preventDefault();

   var hash = this.hash;

   $('html, body').animate({
       scrollTop: $(hash).offset().top
     }, 300, function(){

       window.location.hash = hash;
     });

});



$("#section-parallax .col-sm-8 a[href^='#']").on('click', function(e) {

   e.preventDefault();

   var hash = this.hash;

   $('html, body').animate({
       scrollTop: $(hash).offset().top
     }, 300, function(){

       window.location.hash = hash;
     });

});

$(".footer .scroll-to-top-button a[href^='#']").on('click', function(e) {

   e.preventDefault();

   var hash = this.hash;

   $('html, body').animate({
       scrollTop: $(hash).offset().top
     }, 300, function(){

       window.location.hash = hash;
     });


});



// $(function() {

//   // "use strict";

//   var topoffset = 50; //variable for menu height

//   //Use smooth scrolling when clicking on navigation
//   $('.navbar a[href*=#]:not([href=#])').click(function() {
//     if (location.pathname.replace(/^\//,'') === 
//       this.pathname.replace(/^\//,'') && 
//       location.hostname === this.hostname) {
//       var target = $(this.hash);
//       target = target.length ? target : $('[name=' + this.hash.slice(1) +']');
//       if (target.length) {
//         $('html,body').animate({
//           scrollTop: target.offset().top-topoffset+2
//         }, 500);
//         return false;
//       } //target.length
//     } //click function
//   }); //smooth scrolling

// });



$('.js-wp-1').waypoint(function(direction) {
    $('.js-wp-1').addClass('animated fadeInDown');
}, {
    offset: '50%'
});


$('.js-wp-2').waypoint(function(direction) {
    $('.js-wp-2').addClass('animated fadeInLeft');
}, {
    offset: '50%'
});

$('.js-wp-3').waypoint(function(direction) {
    $('.js-wp-3').addClass('animated fadeInRight');
}, {
    offset: '50%'
});

$('.js-wp-4').waypoint(function(direction) {
    $('.js-wp-4').addClass('animated fadeInUp');
}, {
    offset: '50%'
});

//Nav Offset when clicking through to a section

var offset = 80;

$('.navbar li a').click(function(event) {
    event.preventDefault();
    $($(this).attr('href'))[0].scrollIntoView();
    scrollBy(0, -offset);
});



// $(document).on('click','.navbar-collapse.in',function(e) {
//     if( $(e.target).is('a') ) {
//         $(this).collapse('hide');
//     }
// });


$(document).on('click', '.navbar-collapse.in', function(e) {
    if($(e.target).is('a')){
      $(this).collapse('hide');
    }
});






























