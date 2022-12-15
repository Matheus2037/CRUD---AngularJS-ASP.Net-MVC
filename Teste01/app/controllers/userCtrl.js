(function () {
    'use strict';

    angular
        .module('app')
        .controller('useCterl', ['$scope', 'dataService', function ($scope, dataService) {
            $scope.users = [];

            getData();

            function getData() {
                dataService.getUsers().then(function (result) {
                    $scope.users = result;
                });
            }
        }]);
})();