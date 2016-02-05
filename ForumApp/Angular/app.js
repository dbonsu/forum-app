(function () {
    'use strict';

    angular.module('forumApp', ['ui.router'])
    .config(function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/');

        $stateProvider
        .state('home', {
            url: '/',
            templateUrl: '/Angular/forum/partial-welcome.html'
        })
        .state('forum', {
            url: '/forum',
            templateUrl: '/Angular/forum/partial-forum.html',
            controller: 'forumController',
            controllerAs: 'forum'
        })
        .state('login', {
            url: '/login',
            templateUrl: '/Angular/login/partial-login.html',
            controller: 'loginController',
            controllerAs: 'login'
        })
        .state('state3', {
            url: '/state3',
            templateUrl: '/partials/partial-state3.html'
        })
    });
})();