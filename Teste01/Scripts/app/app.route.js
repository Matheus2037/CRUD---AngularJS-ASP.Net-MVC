(function () {
    'use strict';

    angular.module('app')
        .config(['$routeProvider', '$locationProvider', function ($routeProvider, $locationProvider) {
            $locationProvider.hashPrefix('');

            $routeProvider
                .when('/', {
                    templateUrl: '/Home/Home',
                    
                })
                .when('/Cadastros', {
                    templateUrl: '/Home/Cadastros',
                    
                })
        }])
})();