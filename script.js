var map;
function loadMap() {
    var pos = {lat: 44.4949949, lng: 11.3370906};
    var mapOptions = {
        center: pos,
        zoom: 13,
        //mapTypeId: google.maps.MapTypeId.HYBRID
        disableDefaultUI: true
    };
    map = new google.maps.Map(document.getElementById("map-wrapper"), mapOptions);
    var marker = new google.maps.Marker({
        position: pos,
        map: map
    });
}
