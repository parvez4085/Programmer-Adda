/*
  $(function () {
    $("#username").hide();
    $("#mobile").hide();
    $("#profession").hide();
    $("#password").hide();
    $("cpassword").hide();
    $("#addres").hide();
    $("#email").hide();

    var error_username = false;
    var error_password = false;
    var error_cpassword = false;
    var error_mobno = false;
    var error_pro = false;

    var error_address = false;
    var error_emailid = false;
    $("#user").focusout(function () {
        check_uername();
    });
    $("#mobno").focusout(function () {
        check_mobno();
    });
    $("#pro").focusout(function () {
        check_pro();
    });
    $("#form_password").focusout(function () {
        check_password();
    });
    $("#form_cpass").focusout(function () {
        check_cpassword();
    });
    $("#address").focusout(function () {
        check_address();
    });
    $("#emailid").focusout(function () {
        check_emailid();
    });


    function check_uername() {
        var username_lenght = $("#user").val().length;
        if (username_lenght < 2 || username_lenght > 20) {

            $("#username").html("Should be between 5-20 characters");
            $("#username").show();
            error_user = true;
        }
        else {
            $("#username").hide();
        }
    }

    function check_mobno() {
        var username_lenght = $("#mobno").val().length;
        if (username_lenght != 10) {

            $("#mobile").html("Mobile Number only 10 digit");
            $("#mobile").show();
            error_mobno = true;
        }
        else {
            $("#mobile").hide();
        }
    }


    function check_pro() {
        var pro = $("#pro").val();
        if (pro == "") {

            $("#profession").html("Profession must be filled");
            $("#profession").show();
            error_pro = true;
        }
        else {
            $("#profession").hide();
        }
    }

    function check_password() {
        var username_lenght = $("#form_password").val().length;
        if (username_lenght < 8) {
            
            $("#password").html("At least 8 chatacters");
            $("#password").show();
            error_password = true;
        }
        else {
            $("#password").hide();
        }
    }

    function check_cpassword() {
        var username_lenght = $("#form_password").val();
        var username = $("#form_cpass").val();
        if (username_lenght!=username) {
           
            $("#cpassword").html("Password don't match");
            $("#cpassword").show();
            error_cpassword = true;
        }
        else {
            $("#cpassword").hide();
        }
    }

    function check_address() {
        var username_lenght = $("#address").val();
        if (username_lenght == "") {
            $("#addres").html("Filled address ");
            $("#addres").show();
            error_address = true;
        }
        else {
            $("#addres").hide();
        }
    }

    function check_emailid() {
        var pattern = new RegExp(/^[+a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-z]{2,4}$/i);
        if (pattern.test($("emailid").val())) {
            alert("test");
            $("#email").hide();

        }
        else {
            $("#email").html("Invaid email address 3rd");
            $("#email").show();
            error_address = true;

        }
    }

    $("#Registration").submit(function () {
        
        
        var error_username = false;
        var error_password = false;
        var error_cpassword = false;
        var error_mobno = false;
        var error_pro = false;

        var error_address = false;
        var error_emailid = false;
        check_uername();
        check_mobno();
        check_pro();
        check_password();
        check_cpassword();
        check_emailid();
        error_address();
        if (error_username == false && error_password == false && error_cpassword == false && error_mobno == false && error_pro == false && error_address == false && error_emailid == false) {
          
            return true;
        }
        else {
           
            return false;
        }
    });
});


   /* function validation()
   {
     var user = document.getElementById('user').value;
       var mobno = document.getElementById('mobno').value;
       var pro = document.getElementById('pro').value;
       var pass = document.getElementById('pass').value;
       var cpass = document.getElementById('cpass').value;
       var address = document.getElementById('address').value;
       var emailid = document.getElementById('emailid').value;

   if (user == "") {
           document.getElementById('username').innerHTML = "Please fill the username field";
           return false;
       }

       if ((user.length <= 2) || (user.length > 20)) {

           document.getElementById('username').innerHTML = "User length must be between 2 and 20";
           return false;
       }
       if (!isNaN(user)) {
           document.getElementById('username').innerHTML = "Only Characters are allowed ";
           return false;

       }

       if (mobno == "") {
           document.getElementById('mobile').innerHTML = "Please fill the mobile Number field";
           return false;
       }

       if (isNaN(mobno)) {
           document.getElementById('mobile').innerHTML = "user must write digits only characters";
           return false;
       }
       if (mobno.length != 10) {
           document.getElementById('mobile').innerHTML = "user must be 10 digits only";
           return false;
       }
       if (pro == "") {
           document.getElementById('profession').innerHTML = "Please fill the Profession field";
           return false;
       }

       if (address == "") {
           document.getElementById('addres').innerHTML = "Please fill the username field";
           return false;
       }

       if (emailid == "") {
           document.getElementById('email').innerHTML = "Please fill the Address field";
           return false;
       }
       if (emailid.indexOf('.') <= 0) {
           document.getElementById('email').innerHTML = " ** . Invalid Position";
           return false;
       }
       if ((emailid.charAt(emailid.length - 4) != '.') && (emailid.charAt(emailid.length - 3) != '.')) {
           document.getElementById('email').innerHTML = " ** . Invalid Position";
           return false;
       }

       if (pass == "") {
           document.getElementById('password').innerHTML = "Please fill the password field";
           return false;
       }
       if ((pass.length <= 5) || (pass.length > 20)) {

           document.getElementById('password').innerHTML = "User length must be between 5 and 20";
           return false;
       }

       if (cpass == "") {
           document.getElementById('cpassword').innerHTML = "Please fill the  Confirm Password field";
           return false;
       }

       if (pass != cpass) {
           document.getElementById('cpassword').innerHTML = "Password are not matching";
           return false;
       }


       if (captcha == "") {
           document.getElementById('inputc').innerHTML = "Please fill the Cpatcha field";
           return false;
       }
}*/