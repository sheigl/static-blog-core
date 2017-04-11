namespace app {

    angular
        .module('app.core')
        .config(config);

    config.$inject = ['$routeProvider', '$locationProvider'];
    function config($routeProvider: angular.route.IRouteProvider, $locationProvider: angular.ILocationProvider) {
        $routeProvider
            .otherwise('/');

        $locationProvider.hashPrefix('');            
    }

}