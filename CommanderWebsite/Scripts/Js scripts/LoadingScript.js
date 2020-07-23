$(window).on("load", function loaderP() {
    var preload = document.getElementById("preLoad");
    var loading = 0;
    var id = setInterval(frame, 50);

    function frame() {
        if (loading == 80) {
            clearInterval(id);
            preload.remove();
        }
        else {
            loading++;
        }
        
    }
});