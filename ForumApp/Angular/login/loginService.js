(function () {
    'use strict';

    angular
        .module('forumApp')
        .service('LoginService', LoginService);

    LoginService.$inject = ['$http', '$rootScope', '$window'];

    function LoginService($http, $rootScope, $window) {
        this.logUser = logUser;

        function logUser(userToLogin) {
            $http({
                method: 'POST',
                url: '/api/Debug/angularuser',
                data: userToLogin
            }).then(function (response) {
                var r = response; // this callback will be called asynchronously
                $window.sessionStorage.setItem("ftoken", 'token');
            }, function (response) {
                var a = response
                $rootScope.isAutheticated = false;

                // called asynchronously if an error occurs
                // or server returns response with an error status.
            });
        }
    }
})();