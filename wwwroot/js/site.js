// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function initMap() {
    var uk = { lat: 54.1234, lng: 0.547 };
    var map = new google.maps.Map(document.getElementById("map"), {
        zoom: 8,
        center: uk,
        mapTypeId: "terrain"
    });

    var fields = [];
    fieldsData.forEach(function (obj) {
        var field = [
            new google.maps.LatLng(obj.Latitude1, obj.Longitude1),
            new google.maps.LatLng(53.22985, -0.54035),
            //new google.maps.LatLng(43.1234, -2.547),
            //new google.maps.LatLng(33.1234, -3.547),
        ];
        fields.push(field);
    });

    new google.maps.Polygon({
        paths: fields,
        geodesic: true,
        strokeColor: "Red",
        strokeOpacity: 1.0,
        strokeWeight: 2,
        map: map
    });
}

