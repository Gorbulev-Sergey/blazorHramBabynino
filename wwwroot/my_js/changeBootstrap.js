let changeBootstrap = function (el) {
    if (localStorage.getItem('bootstrap') == '/bootstrap/css/bootstrap.min.css') {
        el.href = '/bootstrap/css/invert/bootstrap.min.css';
        localStorage.setItem('bootstrap', '/bootstrap/css/invert/bootstrap.min.css');
    } else {
        el.href = '/bootstrap/css/bootstrap.min.css';
        localStorage.setItem('bootstrap', '/bootstrap/css/bootstrap.min.css');
    }
}