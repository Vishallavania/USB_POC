// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function myFunction() {
    var checkBox = document.getElementById("myCheck");
    var text = document.getElementById("text");
    if (checkBox.checked == true) {
        text.style.display = "block";
    } else {
        text.style.display = "none";
    }
}
$(function () {
        var b1 = $("#button1");
        var b3 = $("#button3");
        var w = $("#wrapper");
        var l = $("#list");

        b1.click(function () {

            if (w.hasClass('open')) {
        w.removeClass('open');
                w.height(0);
            } else {
        w.addClass('open');
                w.height(l.outerHeight(true));
            }

        });
        b3.click(function () {

            if (w.hasClass('open')) {
                w.removeClass('open');
                w.height(0);
            } else {
                w.addClass('open');
                w.height(l.outerHeight(true));
            }

        });
});
function Function(x) {
    x.classList.toggle("fa-minus-circle");
}

