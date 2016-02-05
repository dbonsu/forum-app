(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('loginController', loginController);

    loginController.$inject = ['$location', '$http'];

    function loginController($location, $http) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'LoginController';
        //vm.username;
        //vm.password;
        vm.user = {
            username: '',
            password: '',
            remeberme: false
        }
        vm.loginUser = loginUser;
        vm.logUser = logUser;
        activate();

        function loginUser() {
            this.user.username// = this.username;
            this.user.password //= this.password;
            this.user.rememberMe //= this.remeberMe;
            this.logUser(this.user)
        }
        function logUser(userToLog) {
            $http({
                method: 'POST',
                url: '/api/Debug/angularuser',
                data: userToLog
            }).then(function (response) {
                var r = response; // this callback will be called asynchronously
                // when the response is available
            }, function (response) {
                var a = response;
                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        }

        function activate() { }
    }
})();