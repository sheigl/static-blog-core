namespace app {

    angular
        .module('app.core')
        .config(config);

    config.$inject = ['$routeProvider'];
    function config($routeProvider: angular.route.IRouteProvider) {
        $routeProvider
            .otherwise('/');
    }

}