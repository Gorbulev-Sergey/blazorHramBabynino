$(window).ready(() => {
    if (localStorage.getItem("tag") == null) {
        localStorage.setItem("tag", "объявления");
    }
});
