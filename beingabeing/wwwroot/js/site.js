// Write your JavaScript code.
// Write your Javascript code.

//Get Day and Time and default location

/* function setDefaultTemperature() {
    let month = new Date().getMonth();
    if (month <= 3 && month == 11) {
        $("#temperature").val("Cold");
        $("#temph3").text("Cold");
        $('[value="Cold"]').addClass("feelselect");
    }
    else if (month >= 4 && month <= 5) {
        $("#temperature").val("Pleasent");
        $("#temph3").text("Pleasent");
        $('[value="Pleasent"]').addClass("feelselect");
        }
    else if (month >= 6 && month <= 7) {
        $("#temperature").val("Warm");
        $("#temph3").text("Warm");
        $('[value="Warm"]').addClass("feelselect");
    }
    else {
        $("#temperature").val("Pleasent");
        $("#temph3").text("Pleasent");
        $('[value="Pleasent"]').addClass("feelselect");
}
};


function defaultLocation() {
    let isweekday = new Date().getDay();
    if (isweekday != 0 && 1) {
        let isworktime = new Date().getHours();
        if (isworktime >= 9 && isworktime <= 17) {
            $("#location").val("Work");
            $("#loch3").text("Work");
            $('[value="Work"]').css("border", "1px solid black");
        }
        else {
            $("#location").val("Home");
            $("#loch3").text("Home");
            $('[value="Home"]').css("border", "1px solid black");
        };

    };
};
*/
var elem2 = document.getElementById("findout");
var timeout = setTimeout(findout, 6000);
function findout() {
    elem2.style = "display:inline;";
}

var text = ["Great", "Sad", "Productive"];
var counter = 0;
var elem = document.getElementById("changeText");
var inst = setInterval(change, 2000);

function change() {
    elem.innerHTML = text[counter];
    counter++;
    if (counter >= text.length) {
        counter = 0;
        clearInterval(inst);
    }
}

$(".food .btn").click(function () {
    let item = $(this).text().split(":");
    let itemname = item[0];
    let itemqty = item[1];
    let newitemqty = ++itemqty;
    $(this).text(itemname + ":" + newitemqty);
    $(this).val(newitemqty);
    let inputid = "#" + this.name;
    $(inputid).val(newitemqty);
});

$(".entrysection .btn").click(function () {
    let inputtype = "#" + this.name;
    $(inputtype).val($(this).val());
    let header = $(this).val();
    $(".modal-title-h1").text(header);
    $(".type").val($(this).val());
    let cat = $(this).attr("cat");
    $(".cat").val(cat);
    $(".datestate").val(moment().format('YYYY-MM-DDTHH:mm:ss'));
    if (cat == "Medicine") {
        $(".pills").css("display", "block");
    } else {
        $(".pills").css("display", "none");
    }
    if (cat == "Exercise") {
        $(".exercise").css("display", "block");
    } else {
        $(".exercise").css("display", "none");
    }
    if (cat == "Poop") {
        $(".poop").css("display", "block");
    } else {
        $(".poop").css("display", "none");
    }
    if (cat == "Food" || "Drink") {
        $(".food").css("display", "block");
    } else {
        $(".food").css("display", "none");
    }
});

$(".location .btn").click(function () {
    $(".loc").val($(this).val());

});

$(".poopcolor .btn").click(function () {
    $(".pcolor").val($(this).val());

});

$(".poopdensity .btn").click(function () {
    $(".pdensity").val($(this).val());

});

$(".exerciseintensity .btn").click(function () {
    $(".intensity").val($(this).val());

});

$(".exerciseduration .btn").click(function () {
    let duration = $(".dur").val();
    let durationtotal = +duration + 15;
    $(".dur").val(0);
    $(".dur").val(durationtotal);

});


$(".socialwhere .btn").click(function () {
    $(".swhere").val($(this).val());

});

$(".socialwith .btn").click(function () {
    $(".swith").val($(this).val());

});


$(".locationbuttons .btn").click(function () {
    $(".locationbuttons button").css("border", "none");
    $(this).css("border", "solid 1px black");
    $(".locationbuttons").css("display", "none");
    $("#location").val($(this).val());
    $("#loch3").text($(this).val());
});

$("#close").click(function () {
    $("#stateform").css("display", "none");
});