(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('LoginController', LoginController);

    LoginController.$inject = ['$window', 'LoginService', 'commonConstant', '$state'];

    function LoginController($window, LoginService, commonConstant, $state) {
        /* jshint validthis:true */
        var vm = this;
        vm.user = {};
        vm.login = login;
        
        function login() {
            vm.user.username
            vm.user.password
            LoginService.logUser(vm.user).then(function () {
                //force reload then navigate to return url
                //to do: get return url
                $window.location.reload();
                $state.go('home');
            },
                function (error) { }
                )
        }
    }
})();