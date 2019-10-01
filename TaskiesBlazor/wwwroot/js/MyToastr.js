const myt = (function () {

    const options = {

    };

    function _error(message) {
        toastr.error(message, options);
    }

    function _sucess(message) {
        toastr.success(message, options);
    }

    function _warning(message) {
        toastr.warning(message, options);
    }

    return {
        error: _error,
        success: _sucess,
        warning: _warning
    };
})();