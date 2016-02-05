(function () {
    'use strict';

    angular
        .module('forumApp')
        .controller('ForumController', ForumController);

    ForumController.$inject = ['$location'];

    function ForumController($location) {
        /* jshint validthis:true */
        var vm = this;
        vm.title = 'ForumController';
        vm.person = {
            firstname: 'derick',
            lastname: 'bonsu'
        };

        activate();

        function activate() { }
    }
})();