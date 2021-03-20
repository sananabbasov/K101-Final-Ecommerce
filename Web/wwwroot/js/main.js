// $('#qqqq').click(function() {
//     console.log("qweqweq")
// });

// $( "#qqqq" ).click(function() {
//   alert( "Handler for .click() called." );

// });

// $(".asdfg").click(function(){
//     $(".asdfg").hover();
//   }).click(function(){
//     $(".asdfg:hover").css("transform","rotateY(185deg)");
//   });

//   $(document).ready(function(){
//     $('button').click(function(){
//       $(".asdfg").hover();
//     }).hover(function() {
//       $(".asdfg:hover").css("transform","rotateY(185deg)");
//     });
// });

var page = true;
function nextPage() {
  if (page == true) {
    //  alert("aasdasd");
    $(".bookSections .asdfg").css("transform", "rotateY(185deg)");
    $(".bookSections .page").css("opacity", "0");
    $(".bookSections .asdfg img").css("transform", "rotateY(0deg)");

    page = false;
  } else {
    $(".bookSections .asdfg").css("transform", "rotateY(0deg)");
    $(".bookSections .page").css("opacity", "0");
    $(".bookSections .asdfg img").css("transform", "rotateY(0deg)");


    page = true;
  }

}
let flip = true;

function bookOpen() {


  $(".bookSections .asdfg").css("transform", "rotateY(0deg)");
  $(".bookSections .asdfg").css("transition", "all 0.5s");



  if (flip == true) {
    $(".bookSections .asdfg img").css("transform", "rotateY(-180deg)");

    flip = false;
  } else {
    $(".bookSections .asdfg img").css("transform", "rotateY(0deg)");

    flip = true;
  }
  $(".bookSections .asdfg img").css("transition", "all .60s");



  $(".bookSections .page").css("opacity", "1");




}



function nextPageMinus() {
  $(".bookSections .asdfg").css("transform", "rotateY(-185deg)");
}
function myFunction() {
  alert("I am an alert box!");
}



$('.responsive').slick({
  dots: false,
  infinite: false,
  speed: 300,
  slidesToShow: 4,
  slidesToScroll: 4,
  arrows: false,
  responsive: [
    {
      breakpoint: 1024,
      settings: {
        slidesToShow: 3,
        slidesToScroll: 3,
        infinite: false,
        dots: false,
        arrows: false,

      }
    },
    {
      breakpoint: 600,
      settings: {
        slidesToShow: 2,
        slidesToScroll: 2
      }
    },
    {
      breakpoint: 480,
      settings: {
        slidesToShow: 1,
        slidesToScroll: 1
      }
    }
    // You can unslick at a given breakpoint now by adding:
    // settings: "unslick"
    // instead of a settings object
  ]
});




