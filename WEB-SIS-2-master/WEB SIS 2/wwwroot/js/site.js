// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
document.getElementById('slider-next').onclick = sliderNext;
var next = 0;

function sliderNext() {
    var strip = document.getElementById('strip');
    next = next - 630;
    if (next < -4410) {
        next = 0;
    }
    strip.style.left = next + 'px';
}