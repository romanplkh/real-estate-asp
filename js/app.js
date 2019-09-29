$('.slider').slick({
	infinite: true,
	slideToShow: 1,
	slideToScroll: 1,
	autoplay: true,
	autoplaySpeed: 3000,
	speed: 1200
});

$(document).ready(function() {
	$('.owl-carousel').owlCarousel();
});

$('.owl-carousel').owlCarousel({
	loop: true,
	margin: 20,
	autoplay: true,
	autoplayTimeout: 4000,
	autoplayHoverPause: true,

	responsive: {
		0: {
			items: 1
		},
		600: {
			items: 2
		},
		1000: {
			items: 3
		},
		1200: {
			items: 4
		}
	}
});
