var geocoder = new google.maps.Geocoder();

function AddressToLatLon() {
    var address = document.getElementById("input-addr").value;
    var lat = document.getElementById("input-lat");
    var lon = document.getElementById("input-lon");

    geocoder.geocode({ 'address': address }, function (results, status) {

        if (status == google.maps.GeocoderStatus.OK) {
            lat.value = results[0].geometry.location.lat();
            lon.value = results[0].geometry.location.lng();
        }
    }); 
}