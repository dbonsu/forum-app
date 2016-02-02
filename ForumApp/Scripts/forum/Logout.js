$(document).ready(function () {
    logoutOption.logout();
    logoutOption.cancel();
});

var logoutOption = {
    logout: function () {
        $('#buttonLogout').click(function () {
            var oldtoken = window.sessionStorage.getItem('forum-token');
            if (oldtoken != null) {
                //to do remove token from storage
                //then hide modal
                $('#logoutBtn').addClass('hideBtn');
                $('#loginBtn').removeClass('hideBtn');
                $('#modal-logout').modal('hide');
            } else {
                alert('no token');
            }
        });
    },

    cancel: function () {
        $('#buttonLogout-cancel').click(function () {
            $('#modal-logout').modal('hide');
        });
    }
}