$(document).ready(function () {
    var baseUrl = "http://localhost:50834/";
    var loginUrl = "api/Account/Login";

    $("#loginForm").submit(function (event) {
        var loginVm = {};
        loginVm.username = $('#username').val();
        loginVm.password = $('#password').val();
        loginVm.rememberMe = $('#rememberme').is(' :checked');
        $.ajax({
            type: 'POST',
            url: baseUrl + loginUrl,
            data: JSON.stringify(loginVm),
            contentType: 'application/json; charset=utf-8',
            success: loginSuccess,
            error: loginFail
        });
        function loginSuccess(data, stringData, xqXHR) {
            alert('to do authentication');
            $('#modal-loginForm').modal('hide');
        };

        function loginFail(jqXHR, textStatus, errorThrown) {
            var responseText = jQuery.parseJSON(jqXHR.responseText);

            displayError(responseText.message);
        };

        var displayError = function (errorMessage) {
            $('#login-main-error').addClass('error-message');
            $('#login-main-error').html(errorMessage);
        };
        event.preventDefault();
    });
});