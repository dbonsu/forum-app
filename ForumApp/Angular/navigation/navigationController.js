(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('NavigationController', NavigationController);

    NavigationController.$inject = ['$location', '$state', '$window', 'tokenService', 'commonConstant'];

    function NavigationController($location, $state, $window, tokenService, commonConstant) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'navigationController';
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