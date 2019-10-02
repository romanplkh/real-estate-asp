const gulp = require('gulp');
const concatCss = require('gulp-concat-css');
const concat = require('gulp-concat');

//CSS
gulp.task('default', function() {
	return gulp
		.src('./*.css')
		.pipe(concatCss('bundle.css'))
		.pipe(gulp.dest('./css'));
});

//JS
// gulp.task('default', function() {
// 	return gulp
// 		.src('./js/*.js')
// 		.pipe(concat('bundle.js'))
// 		.pipe(gulp.dest('src/'));
// });
