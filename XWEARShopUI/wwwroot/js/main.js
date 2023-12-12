const welcome = new Swiper('.welcome__slider', {
	// Optional parameters
	direction: 'horizontal',
	loop: true,
	slidesPerView: 1,

	// If we need pagination
	pagination: {
		el: '.swiper-pagination',
	},

	// Navigation arrows
	navigation: {
		nextEl: '.swiper-button-next',
		prevEl: '.swiper-button-prev',
	},
});
