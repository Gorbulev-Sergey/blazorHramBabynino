$(document).ready(function () {
    $(document).on('fullscreenchange', function (e) {
        if (!document.fullscreen) (dotNetHelper) => { return dotNetHelper.invokeMethodAsync('closeWindow'); }
    });
});

var enableFullScreen = function () {
    document.body.requestFullscreen();
};

var disableFullScreen = function () {
    document.exitFullscreen();
}


////////////////////////////////////////// Для андройда
var goToFullscreen = function (albumId) {
    //console.log("в полный экран " + albumId);
    window.JSInterface.goToFullscreen(albumId);    
}

var returnBack = function () {
    //console.log("Назад");
    window.JSInterface.returnBack();    
}