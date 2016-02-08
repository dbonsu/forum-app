(function () {
    'use strict';

    angular
        .module('forumApp')
        .service('LoginService', LoginService);

    LoginService.$inject = ['$http', '$window', 'tokenService', 'commonConstant', '$state'];

    function LoginService($http, $window, tokenService, commonConstant, $state) {
        this.logUser = logUser;

        function logUser(userToLogin) {
           return  $http.post('/api/Account/Login', userToLogin)
                .then(function (response) {
                  var token = response.headers('forum-token');
                  var result = tokenService.saveToken(token);
                                    
                }, function (response) {
                    return commonConstant.FAILED_LOGIN;
                });
        }
    }
})();