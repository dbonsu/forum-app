(function () {
    'use strict';

    angular.module('common.services', [])
    .constant('commonConstant', {
        NO_TOKEN: 'there is no token',
        FAIL_TO_GET_TOKEN: 'failed to retrieve token',
        SUCCESS_LOGIN: 'user logged in successfully',
        FAILED_LOGIN: 'user failed to login'
    }).service('tokenService', ['$http', '$window', 'commonConstant', function ($http, $window, commonConstant) {
        this.getToken = getToken;
        this.saveToken = saveToken;
        this.removeToken = removeToken;

        function getToken() {
            var token = $window.sessionStorage.getItem('forum-token');
            if (token !== null && token !== undefined) {
                return token;
            }
            return commonConstant.NO_TOKEN;
        }

        function saveToken(token) {
            if (token !== null && token !== undefined) {
                $window.sessionStorage.setItem("forum-token", token);
                $http.defaults.headers.common['Authorization'] = 'Bearer ' +token;

                return "";
            }
            return commonConstant.FAIL_TO_GET_TOKEN;
        }

        function removeToken() {
            var tokenPresent = getToken();
            if (tokenPresent !== commonConstant.NO_TOKEN) {
                $window.sessionStorage.removeItem('forum-token');
            }
        }
    }]);
})();