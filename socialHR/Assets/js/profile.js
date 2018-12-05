//component số điện thoại
Vue.component('phone_number', {
    data: function () {
        return {
            number: '0358285691'
        }
    },
    template: '<span> {{ number }}</span> '
});

//component ngày sinh
Vue.component('birthday', {
    data: function () {
        return {
            birthday: {
                day: '1',
                month: '11' ,
                year: '1997' 
            }
        }           
    },
    template: '<div><div v-in="(day,month,year) in birthday"><p>{{birthday.day}} tháng {{birthday.month}}, {{birthday.year}} </p></div></div>'
});

Vue.component('majors', {
    data: function () {
        return {
            majors: "Công nghệ thông tin"
        }
    },
    template: '<span>{{majors}}</span>'
});

//component công việc
Vue.component('work', {
    data: function () {
        return {
            companys: [
                { com: "Infore Technology" },
                { com: "Sao Khuee"}
            ]
        }
    },
    template: '<span><span v-for="company in companys">{{company.com}}, </span></span>'
});


//component school
Vue.component('school', {
    data: function () {
        return {
            schools: [
                { school: "Đại học Quốc Gia Hà Nội - VNU" },
                { school: "Đại học Công Nghệ" }
            ]
        }
    },
    template: '<span><span v-for="school in schools">{{school.school}}, </span></span>'
})

var profile = new Vue({
    el: '#profile',
    data: function () {
        return {
            birthday: {
                day: '1',
                month: '11',
                year: '1997'
            },
            city_live: "Hà Nội",
            hometown: "Bắc Ninh",
            companys: [
                { com: "Infore Technology" },
                { com: "Sao Khuee" }
            ],
            schools: [
                { school: "Đại học Quốc Gia Hà Nội - VNU" },
                { school: "Đại học Công Nghệ" }
            ],
            majors: "Công nghệ thông tin",
        }
    }
});