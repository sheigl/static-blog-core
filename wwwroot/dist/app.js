var app;
(function (app) {
    'use strict';
    angular.module('app', [
        'app.core'
    ]);
})(app || (app = {}));
var app;
(function (app) {
    angular.module('app.core', [
        'ngRoute',
        'app.services',
        'app.widgets'
    ]);
})(app || (app = {}));
var app;
(function (app) {
    angular.module('app.services', []);
})(app || (app = {}));
var app;
(function (app) {
    angular.module('app.widgets', []);
})(app || (app = {}));
var app;
(function (app) {
    angular
        .module('app.core')
        .config(config);
    config.$inject = ['$routeProvider'];
    function config($routeProvider) {
        $routeProvider
            .otherwise('/');
    }
})(app || (app = {}));
