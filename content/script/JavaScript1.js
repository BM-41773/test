$(document).ready(function (e) {
    $('#cmd').click(function () {
        var email = $('#Mail').val();
        if ($.trim(email).length == 0) {
            alert('Please Enter Valid Email Address');
            return false;
        }
        if (validateEmail(email)) {
            alert('Valid Email Address');
            return false;
        }
        else {
            alert('Invalid Email Address');
            return false;
        }
    });
});

