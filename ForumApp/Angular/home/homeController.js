(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('HomeController', HomeController);

    HomeController.$inject = ['HomeService', '$rootScope', '$state', '$window'];

    function HomeController(HomeService, $rootScope, $state, $window) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'homeController';
        vm.isAuthenticated = false;
        vm.logout = logout;

        checkAuthentication();

        function checkAuthentication() {
            var result = $window.sessionStorage.getItem("ftoken");
            if (result !== null || result !== undefined) {
                vm.isAuthenticated = true;
            }
        }

        function logout() {
            this.isAuthenticated = false;
            $rootScope.isAuthenticated;
            $state.go('home');
            //remove token
        }
    }
})();