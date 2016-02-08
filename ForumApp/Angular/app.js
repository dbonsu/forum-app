(function () {
    'use strict';

    angular.module('forumApp', ['ui.router', 'common.services'])
    .config(function ($stateProvider, $urlRouterProvider) {
        $urlRouterProvider.otherwise('/');

        $stateProvider
        .state('home', {
            url: '/',
            templateUrl: '/Angular/forum/partial-welcome.html',
           
            //controller: 'HomeController',
            //controllerAs: 'home'
        })
        .state('forum', {
            url: '/forum',
            templateUrl: '/Angular/forum/partial-forum.html',
            controller: 'ForumController',
            controllerAs: 'forum'
        })
        .state('login', {
            url: '/login',
            templateUrl: '/Angular/login/partial-login.html',
            controller: 'LoginController',
            controllerAs: 'login'
        })
        .state('debug', {
            url: '/debug',
            templateUrl: '/Angular/debug/partial-debug.html',
            controller: 'DebugController',
            controllerAs: 'debug'
        })
    });
})();