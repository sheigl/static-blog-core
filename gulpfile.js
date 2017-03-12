/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var $ = require('gulp-load-plugins')({lazy: true});

var webroot = './wwwroot/';
var webApp = webroot + 'app/';
var bower = {
    json: require('./bower.json'),
    directory: webroot + 'lib/',
    ignorePath: '../../wwwroot/',
};

var js = [
    webApp + '**/*.module.js',
    webApp + '**/*.service.js',
    webApp + '**/*.config.js',
    webApp + '**/*.controller.js',
    webApp + '**/*.filter.js'
];

var ts = [
    webApp + '**/*.module.ts',
    webApp + '**/*.service.ts',
    webApp + '**/*.config.ts',
    webApp + '**/*.controller.ts',
    webApp + '**/*.filter.ts'
];

var css = [
    webroot + 'css/**/*.css',
    '!' + webroot + 'css/lib/**/*.css'
]

var sass = webroot + 'scss/*.scss';

gulp.task('sass:watch', function(){
    return gulp.watch(sass, ['sass']);
});

gulp.task('default', function () {
    // place code for your default task here
});

gulp.task('sass', function(){
    return gulp
        .src(sass)
        .pipe($.sass())
        .pipe(gulp.dest(webroot + 'css'));
});

gulp.task('typescript', function() {
    return gulp.src(ts)
        .pipe($.typescript({
            noImplicitAny: false,
            module: 'commonjs',
            target: 'ES5'
        }))
        .pipe(gulp.dest(webroot + 'app'));
});
gulp.task('wiredep', function () {
    var wiredep = require('wiredep').stream;
    var options = {
        bowerJson: bower.json,
        directory: bower.directory,
        ignorePath: bower.ignorePath,
        addRootSlash: false
    };

    return gulp
        .src('./Views/Home/Index.cshtml')
        .pipe(wiredep(options))
        .pipe($.inject(gulp.src(/*js*/webroot + 'js/*.js', { read: false }), { ignorePath: '/wwwroot/', addRootSlash: false }))
        .pipe($.inject(gulp.src(css, { read: false }), { ignorePath: '/wwwroot/', addRootSlash: false }))
        .pipe(gulp.dest('./Views/Home/'));
});

gulp.task('watch', function() {
    return gulp.watch([webroot + '**/*.ts', webroot + '**/*.scss'], ['wiredep', 'sass'])
})