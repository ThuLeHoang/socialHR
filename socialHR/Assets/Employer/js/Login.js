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

var app = new Vue({
    el: '#wrapper_login',
    data: {
        email_has_val: '',
        pass_has_val:''
    },
    computed: {
        class_email_val() {
            if (this.email_has_val !== 'admin@gmail.com') {
                return 'has-val';
            } else {
                return '';
            }
        },
        class_pass_val() {
            if (this.pass_has_val !== '') {
                return 'has-val';
            } else {
                return '';
            }
        }
    }
});