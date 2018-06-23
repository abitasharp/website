function ShowForm(){
    var radio_privato = document.getElementById("radio-privato");
    var radio_azienda = document.getElementById("radio-azienda");

    var privato = document.getElementById("privato");
    var azienda = document.getElementById("azienda");

    if (radio_privato.checked) {
        privato.style.display = 'block';
        azienda.style.display = 'none';
    }

    if (radio_azienda.checked) {
        privato.style.display = 'none';
        azienda.style.display = 'block';
    }
}
