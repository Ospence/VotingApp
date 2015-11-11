﻿(function () {
    angular.module("VotingApp", ['ngRoute', 'ui.bootstrap', 'ngResource', 'ngAnimate'])
        .config(['$routeProvider', function ($routeProvider) {
            $routeProvider
            /*
                .when('url/:urlParam1', {
                    templateUrl: '/url/to/template.html',
                    controller: 'BlahController',
                    controllerAs: 'vm'
                })
            */

            //.when('/', {
            //        templateUrl: '/ngViews/TestView.html',
            //        controller: 'userController',
            //        controllerAs: 'vm'
            //    })

                .when('/', {
                    templateUrl: '/ngViews/TestView2.html',
                    controller: 'userController',
                    controllerAs: 'vm'
                })
                
            .otherwise({
                templateUrl: '/ngViews/notFound.html'
            });
        }]);
})();