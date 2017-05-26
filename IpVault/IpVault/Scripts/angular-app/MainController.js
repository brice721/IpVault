(function () {
    'use strict';

    var app = angular.module('app', []);
    app.controller('MainController', ['$scope', function ($scope) {
        $scope.title = 'This Better Fucking Work!!!';
    }]);
})();