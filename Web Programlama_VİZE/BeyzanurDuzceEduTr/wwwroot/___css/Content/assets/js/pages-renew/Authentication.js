var _userid = document.getElementById('username'),
    _pwd = document.getElementById('password-input'),
    loginBtn = document.getElementById("btnLogin");

loginBtn.addEventListener("click", function (e) {
    $.ajax({
        url: "/Authentication/Login",
        type: "POST",
        dataType: "json",
        data: {
            userId: _userid.value,
            password: _pwd.value
        },
        success: function (data) {
            if (data.statu == 'ok') {
                //pm('Oturum açma başarılı', data.message);


                setTimeout(function () {
                    var returnUrl = GetURLParameter("0");
                    if (returnUrl != "") {
                        window.location.href = returnUrl;
                    }
                    else {
                        window.location.href = "/Admin/Index";
                    }
                }, 300);
            }
            else if (data.statu == "fail") {
                //pm('Oturum açma Hatası', data.message, data.statu);
                //$('#btnSubmit').attr('disabled', false);
            }
        }
    })
});


function GetURLParameter(sParam) {
    var sPageURL = window.location.href;
    var indexOfLastSlash = sPageURL.indexOf("/?");
    if (indexOfLastSlash > 0 && sPageURL.length - 1 != indexOfLastSlash)
        return sPageURL.substring(indexOfLastSlash + 1).replace("?ReturnUrl=", "");
    else
        return 0;
};