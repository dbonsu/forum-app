﻿(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['$state', '$window', 'tokenService', 'commonConstant'];

    function HomeController($state, $window, tokenService, commonConstant) {
        /* jshint validthis:true */
        var vm = this;
        vm.isAuthenticated = false;
        vm.logout = logout;
        vm.loginPage = loginPage;

        checkAuthentication();

        function checkAuthentication() {
            var result = tokenService.getToken();
            if (result !== commonConstant.NO_TOKEN) {
                vm.isAuthenticated = true;
                return vm.isAuthenticated;
            }
        }

        function logout() {
            vm.isAuthenticated = false;
            $state.go('home');
            tokenService.removeToken();

            return vm.isAuthenticated;
        }
        function loginPage() {
            $state.go('login');
        }
    }
})();