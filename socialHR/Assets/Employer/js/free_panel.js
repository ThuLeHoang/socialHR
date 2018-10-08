$("#side_menu li").click(function (e) {
    //e.preventDefault();
    //var child = $("div.left_panel_collsape", this);
    //if (!child.hasClass("in")) {
    //    child.removeClass("in");
    //} else {
    //    child.addClass("in");
    //}
    //var other_child = $("div.left_panel_collsape", $("#side_menu"));
    //other_child.removeClass("in");

    if ($("div.left_panel_collsape", this).hasClass("in")) {
        $("toggle_collsape", this).removeClass("fa-plus");
        $("toggle_collsape", this).addClass("fa-minus");
    } else {
        $("toggle_collsape", this).removeClass("fa-minus");
        $("toggle_collsape", this).addClass("fa-plus");
    }
});
