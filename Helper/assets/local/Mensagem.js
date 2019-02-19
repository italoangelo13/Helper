//Exige como dependencia o Plugin Jquery-Confirm

function msgSucesso(mensagem) {
    $.alert({
        title: 'Sigem Alerta!',
        content: mensagem,
        type: 'green',
    });
}

function msgAtencao(mensagem) {
    $.alert({
        title: 'Sigem Alerta!',
        content: mensagem,
        type: 'yellow',
    });
}

function msgErro(mensagem) {
    $.alert({
        title: 'Sigem Alerta!',
        content: mensagem,
        type: 'red',
    });
}

function msg(mensagem) {
    $.alert({
        title: 'Sigem Alerta!',
        content: mensagem,
    });
}