$(document).ready(function () {
    initAjaxForm();
    $(".eliminar").click(function (event) {
        event.preventDefault();
        Swal.fire({
            title: '&iquest;Est&aacute; seguro?',
            html: "No se puede deshacer esta operaci&oacute;n.",
            icon: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'S&iacute;',
            cancelButtonText: 'No'
        }).then((result) => {
            if (result.value) {
                var urlDelete = $(this).attr("href");
                $.ajax({
                    type: "POST",
                    url: urlDelete,
                    beforeSend: func_beforeSend,
                    success: function (data, textStatus, xhr) {
                        func_successDelete(data, textStatus, xhr, null);
                    },
                    error: function (jqXHR, textStatus, errorThrown) {
                        func_error(jqXHR, textStatus, errorThrown, null);
                    },
                    complete: func_complete
                });
            }
        });
    });
}); 

function initAjaxForm() {
    $(".form-ajax").submit(function (event) {
        event.preventDefault();
        if ($(this).valid()) {
            Swal.fire({
                title: '&iquest;Est&aacute; seguro?',
                html: "La informaci&oacute;n se enviar&aacute;.",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'S&iacute;',
                cancelButtonText: 'No'
            }).then((result) => {
                if (result.value) {
                    var form = $(this);
                    var formData = new FormData(this);
                    $.ajax({
                        url: $(this).attr("action"),
                        headers: {
                            'Accept': "application/json; charset=utf-8"
                        },
                        beforeSend: func_beforeSend,
                        success: function (data, textStatus, xhr) {
                            func_success(data, textStatus, xhr, form);
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            func_error(jqXHR, textStatus, errorThrown, form);
                        },
                        complete: func_complete,
                        data: formData,
                        type: $(this).attr("method"),
                        contentType: false,
                        processData: false,
                        async: true,
                        cache: false
                    });
                }
            });
        }
    });
}

function func_beforeSend() {
    $('body').loadingModal({
        text: 'Espere...'
    });
}

function func_success(data, textStatus, xhr, form) {
    switch (xhr.status) {
        case 200:
            Swal.fire({
                icon: 'success',
                title: 'Ok!',
                html: 'Operaci&oacute;n realizada correctamente.',
                allowOutsideClick: false
            }).then(function (result) {
                window.location.href = $("#_redirectURL").val();
            });
            break;
        case 202:
            Swal.fire({
                icon: 'warning',
                title: 'Oops!',
                html: 'La operaci&oacute;n no se complet&oacute; correctamente.',
                allowOutsideClick: false
            }).then(function (result) {
                window.location.href = $("#_redirectURL").val();
            });
            break;
    }
}

function func_successDelete(data, textStatus, xhr, form) {
    switch (xhr.status) {
        case 200:
            Swal.fire({
                icon: 'success',
                title: 'Ok!',
                html: 'Operaci&oacute;n realizada correctamente.',
                allowOutsideClick: false
            }).then(function (result) {
                window.location.reload();
            });
            break;
        case 202:
            Swal.fire({
                icon: 'warning',
                title: 'Oops!',
                html: 'La operaci&oacute;n no se complet&oacute; correctamente.',
                allowOutsideClick: false
            }).then(function (result) {
                window.location.reload();
            });
            break;
    }
}

function func_error(jqXHR, textStatus, errorThrown, form) {
    switch (jqXHR.status) {
        case 400:
            Swal.fire({
                icon: 'error',
                title: 'Error!',
                html: 'La informaci&oacute;n enviada contiene errores.',
                allowOutsideClick: false
            });
            break;
        case 404:
            Swal.fire({
                icon: 'error',
                title: 'Error!',
                html: 'El recurso solicitado no existe.',
                allowOutsideClick: false
            });
            break;
        case 500:
            Swal.fire({
                icon: 'error',
                title: 'Error!',
                html: 'Ocurri&oacute; un error.',
                allowOutsideClick: false
            });
            break;
    }
}

function func_complete(jqXHR, textStatus) {
    $('body').loadingModal('hide');
}