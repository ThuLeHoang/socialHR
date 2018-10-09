var app = new Vue({
    el: '#social_cv_all',
    data: {
        
    },
    mounted() {
        var button = document.querySelectorAll('.rippleBtn');

        function makeRipple(e) {
            let circle = document.createElement('div');
            circle.classList.add('rippleCircle');
            let d = Math.max(this.clientWidth, this.clientHeight);
            circle.style.width = circle.style.height = `${d}px`;
            circle.style.top = e.offsetY - d / 2 + 'px';
            circle.style.left = e.offsetX - d / 2 + 'px';
            this.appendChild(circle);
        }

        for (let i = 0; i < button.length; i++) {
            button[i].style.position = 'relative';
            button[i].style.overflow = 'hidden';
            let mask = document.createElement('div');
            mask.classList.add('rippleMask');
            button[i].appendChild(mask);
            button[i].onclick = makeRipple;
            button[i].addEventListener('animationend', function () {
                let oldCircle = this.querySelector('.rippleCircle');
                this.removeChild(oldCircle);
            });
        }
    },
    methods: {
        toggle_rank_chart: function () {
            toggle_rank_chart();
        },
        show_cv_of_friend: function () {
            alert("redirect to this friend cv");
        }
    }
});

function toggle_rank_chart() {
    if ($("#candidate_rank_div").height() === 0) {
        $("#candidate_rank_div").height("100%");
    } else {
        $("#candidate_rank_div").height(0);
    }
    
}


$(".visit-post").on("click", function () {
    window.open($(this).parent().find("a").attr("href"), "_blank");
});

//function get_address() {
//    switch ($("#address input").val()) {
//        case "1":
//            $("#address strong").text("An Giang");
//            break;
//        case "2":
//            $("#address strong").text("Bắc Giang");
//            break;
//        case "3":
//            $("#address strong").text("Bắc Kạn");
//            break;
//        case "4":
//            $("#address strong").text("Bạc Liêu");
//            break;
//        case "5":
//            $("#address strong").text("Bắc Ninh");
//            break;
//        case "6":
//            $("#address strong").text("Bà Rịa–Vũng Tàu");
//            break;
//        case "7":
//            $("#address strong").text("Bến Tre");
//            break;
//        case "8":
//            $("#address strong").text("Bình Định");
//            break;
//        case "9":
//            $("#address strong").text("Bình Dương");
//            break;
//        case "10":
//            $("#address strong").text("Bình Phước");
//            break;
//        case "11":
//            $("#address strong").text("Bình Thuận");
//            break;
//        case "12":
//            $("#address strong").text("Cà Mau");
//            break;
//        case "13":
//            $("#address strong").text("Cần Thơ");
//            break;
//        case "14":
//            $("#address strong").text("Cao Bằng");
//            break;
//        case "15":
//            $("#address strong").text("Đà Nẵng");
//            break;
//        case "16":
//            $("#address strong").text("Đắk Lắk");
//            break;
//        case "17":
//            $("#address strong").text("Đắk Nông");
//            break;
//        case "18":
//            $("#address strong").text("Điện Biên");
//            break;
//        case "19":
//            $("#address strong").text("Đồng Nai");
//            break;
//        case "20":
//            $("#address strong").text("Đồng Tháp");
//            break;
//        case "21":
//            $("#address strong").text("Gia Lai");
//            break;
//        case "22":
//            $("#address strong").text("Hà Giang");
//            break;
//        case "23":
//            $("#address strong").text("Hà Nam");
//            break;
//        case "24":
//            $("#address strong").text("Hà Tĩnh");
//            break;
//        case "25":
//            $("#address strong").text("Hải Dương");
//            break;
//        case "26":
//            $("#address strong").text("Hải Phòng");
//            break;
//        case "27":
//            $("#address strong").text("Hà Nội");
//            break;
//        case "28":
//            $("#address strong").text("Hậu Giang");
//            break;
//        case "29":
//            $("#address strong").text("Hòa Bình");
//            break;
//        case "30":
//            $("#address strong").text("Hồ Chí Minh");
//            break;
//        case "31":
//            $("#address strong").text("Hưng Yên");
//            break;
//        case "32":
//            $("#address strong").text("Khánh Hòa");
//            break;
//        case "33":
//            $("#address strong").text("Kiên Giang");
//            break;
//        case "34":
//            $("#address strong").text("Kon Tum");
//            break;
//        case "35":
//            $("#address strong").text("Lai Châu");
//            break;
//        case "36":
//            $("#address strong").text("Lâm Đồng");
//            break;
//        case "37":
//            $("#address strong").text("Lạng Sơn");
//            break;
//        case "38":
//            $("#address strong").text("Lào Cai");
//            break;
//        case "39":
//            $("#address strong").text("Long An");
//            break;
//        case "40":
//            $("#address strong").text("Nam Định");
//            break;
//        case "41":
//            $("#address strong").text("Nghệ An");
//            break;
//        case "42":
//            $("#address strong").text("Ninh Bình");
//            break;
//        case "43":
//            $("#address strong").text("Ninh Thuận");
//            break;
//        case "44":
//            $("#address strong").text("Phú Thọ");
//            break;
//        case "45":
//            $("#address strong").text("Phú Yên");
//            break;
//        case "46":
//            $("#address strong").text("Quảng Bình");
//            break;
//        case "47":
//            $("#address strong").text("Quảng Nam");
//            break;
//        case "48":
//            $("#address strong").text("Quảng Ngãi");
//            break;
//        case "49":
//            $("#address strong").text("Quảng Ninh");
//            break;
//        case "50":
//            $("#address strong").text("Quảng Trị");
//            break;
//        case "51":
//            $("#address strong").text("Sóc Trăng");
//            break;
//        case "52":
//            $("#address strong").text("Sơn La");
//            break;
//        case "53":
//            $("#address strong").text("Tây Ninh");
//            break;
//        case "54":
//            $("#address strong").text("Thái Bình");
//            break;
//        case "55":
//            $("#address strong").text("Thái Nguyên");
//            break;
//        case "56":
//            $("#address strong").text("Thanh Hóa");
//            break;
//        case "57":
//            $("#address strong").text("Thừa Thiên Huế");
//            break;
//        case "58":
//            $("#address strong").text("Tiền Giang");
//            break;
//        case "59":
//            $("#address strong").text("Trà Vinh");
//            break;
//        case "60":
//            $("#address strong").text("Tuyên Quang");
//            break;
//        case "61":
//            $("#address strong").text("Vĩnh Long");
//            break;
//        case "62":
//            $("#address strong").text("Vĩnh Phúc");
//            break;
//        case "63":
//            $("#address strong").text("Yên Bái");
//            break;
//    }
//}

$(document).ready(function () {
    $('[data-toggle="tooltip"]').tooltip();
    //get_address();
    load_chart();
    
}); 

function load_chart() {
    var options = {
        title: {
            text: "Biểu đồ phân bố bạn bè theo influence score",
            fontFamily:"Arial"
        },
        data: [{
            type: "pie",
            startAngle: 45,
            showInLegend: "true",
            legendText: "{label}",
            indexLabel: "{label} ({y})",
            yValueFormatString: "#,##0.#" % "",
            dataPoints: [
                { label: "1",  y: 1 },
                { label: "2",  y: 31 },
                { label: "3",  y: 7 },
                { label: "4",  y: 7 },
                { label: "5",  y: 6 },
                { label: "6",  y: 10 },
                { label: "7",  y: 3 },
                { label: "8",  y: 3 },
                { label: "9",  y: 3 },
                { label: "10", y: 3 }
            ]
        }]
    };
    $("#chartContainer").CanvasJSChart(options);
}

$("#social-profile-network td.redirect").on("click", function () {
    window.open($(this).parent().attr("href"), "_blank");
});

$("#fanpage-group td.redirect").on("click", function () {
    window.open($(this).parent().attr("href"), "_blank");
});

$("#facebook-behavior td.redirect").on("click", function () {
    window.open($(this).parent().attr("href"), "_blank");
});

$("#facebook-behavior .card .card-body .table-tasks table tr td .visit-post-1").on("click", function () {
    window.open($(this).parent().parent().parent().attr('href'), '_blank'); 
});

//đoạn này là để toggle comment content nếu nó quá dài
$("#facebook-behavior .card .card-body .table-tasks table tr td .fb-post-toggle-text").on("click", function () {
    if ($(this).text() === "more>>") {
        $(this).parent().find("span").text($(this).parent().parent().find("input").val());
        $(this).text("less<<");
    } else {
        $(this).parent().find("span").text($(this).parent().parent().find("input").val().substr(0, 80));
        $(this).text("more>>");
    }
});
$("#facebook-behavior tbody tr .redirect").on("mouseover", function () {
    $(this).parent().css({ "background-color": "#e8e8e8"});
});
$("#facebook-behavior tbody tr .redirect").on("mouseleave", function () {
    $(this).parent().css({ "background-color": "#fff" });
});

