(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('LoginController', LoginController);

    LoginController.$inject = ['$location', 'LoginService'];

    function LoginController($location, LoginService) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'LoginController';

        vm.user = {
            username: '',
            password: '',
            remeberme: false
        }
        vm.loginUser = loginUser;


        function loginUser() {
            this.user.username// = this.username;
            this.user.password //= this.password;
            this.user.rememberMe //= this.remeberMe;
            LoginService.logUser(this.user);
            
        }

    }
})();