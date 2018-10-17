function load_form() {
    var vw = $(window).width();
    var login_width = $("#wrapper_login").width();
    var login_margin = vw > 410 ? (vw - 390) / 2 : '10%';
    $("#wrapper_login").css({ "margin-left": login_margin , "margin-top": "5%"});
}
$(document).ready(function () {
    load_form();
});
$(document).resize(function () {
    load_form();
});
