function ShowForm(){
    var radio_my = document.getElementById("my");
    var radio_fav = document.getElementById("fav");

    var my = document.getElementById("mieiAnnunci");
    var fav = document.getElementById("preferiti");

    if (radio_my.checked) {
        my.style.display = 'block';
        fav.style.display = 'none';
    }

    if (radio_fav.checked) {
        my.style.display = 'none';
        fav.style.display = 'block';
    }
}
