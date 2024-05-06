// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const fieldList = [];

function initMap() {
    var uk = { lat: 53.290, lng: -1.368 }
    const map = new google.maps.Map(document.getElementById("map"), {
        zoom: 8,
        center: uk,
        mapTypeId: "terrain",
    });
    const field = [
        { lat: lat1, lng: long1 },
        { lat: lat2, lng: long2 },
        { lat: lat3, lng: long3 },
        { lat: lat4, lng: long4 },
    ]
    const fieldArea = new google.maps.Polygon({
        path: field,
        geodesic: true,
        strokeColor: "Blue",
        strokeOpacity: 1.0,
        strokeWeight: 2,
    });

    fieldArea.setMap(map);
}


fieldList.get
window.initMap = initMap;
