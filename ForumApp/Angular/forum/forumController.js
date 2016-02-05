(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('forumController', forumController);

    forumController.$inject = ['$location'];

    function forumController($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'forumController';
        vm.person = {
            firstname: 'derick',
            lastname: 'bonsu'
        };

        activate();

        function activate() { }
    }
})();