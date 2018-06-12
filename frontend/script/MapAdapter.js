// region google-maps

var g_map;
function loadMap() {
    var pos = { lat: 44.4949949, lng: 11.3370906 };
    var mapOptions = {
        center: pos,
        zoom: 13,
        //mapTypeId: google.maps.MapTypeId.HYBRID
        disableDefaultUI: true
    };
    g_map = new google.maps.Map(document.getElementById("g-map-wrapper"), mapOptions);
    var marker = new google.maps.Marker({
        position: pos,
        map: g_map
    });
}

// endregion



// region open-layer

var iconFeatures = [
    new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.transform([11.3370906, 44.4949949], 'EPSG:4326', 'EPSG:3857')),
    }),
    new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.transform([11.3340806, 44.4947949], 'EPSG:4326', 'EPSG:3857'))
    }),
    new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.transform([11.3270706, 44.4949549], 'EPSG:4326', 'EPSG:3857')),
    }),
    new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.transform([11.3170606, 44.4949949], 'EPSG:4326', 'EPSG:3857'))
    }),
    new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.transform([11.3670506, 44.4949649], 'EPSG:4326', 'EPSG:3857')),
    }),
    new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.transform([11.3370006, 44.4949919], 'EPSG:4326', 'EPSG:3857'))
    })
];

var vectorSource = new ol.source.Vector({
    features: iconFeatures //add an array of features
});

var iconStyle = new ol.style.Style({
    image: new ol.style.Icon(/** @type {olx.style.IconOptions} */({
        anchor: [1, 1],
        anchorXUnits: 'fraction',
        anchorYUnits: 'fraction',
        opacity: 1,
        src: 'img/pin.png'
    }))
});

var layer_osm = new ol.layer.Tile({
    source: new ol.source.OSM()
});
var layer_markers = new ol.layer.Vector({
    source: vectorSource,
    style: iconStyle
});

var radius_cluster = 10;
var styleCache = {};
var layer_clusters = new ol.layer.Vector({
    source: new ol.source.Cluster({
        distance: radius_cluster,
        source: vectorSource
    }),
    style: function (feature, resolution) {
        var size = feature.get('features').length;
        if (size === 1) return null;
        var style = styleCache[size];
        if (!style) {
            style = [new ol.style.Style({
                image: new ol.style.Circle({
                    radius: radius_cluster,
                    stroke: new ol.style.Stroke({
                        color: '#fff'
                    }),
                    fill: new ol.style.Fill({
                        color: '#ff5050'
                    })
                }),
                text: new ol.style.Text({
                    text: size.toString(),
                    fill: new ol.style.Fill({
                        color: '#fff'
                    })
                })
            })];
            styleCache[size] = style;
        }
        return style;
    }
});

var o_map = new ol.Map({
    target: 'o-map-wrapper',
    layers: [layer_osm, layer_markers, layer_clusters],
    view: new ol.View({
        center: ol.proj.fromLonLat([11.3370906, 44.4949949]),
        zoom: 13
    })
});

o_map.on(
    'moveend', () => {
        var extent = o_map.getView().calculateExtent(o_map.getSize());
        var count = 0;
        vectorSource.forEachFeatureInExtent(extent, () => {
            count ++;
        });
        console.log("Annunci visibili: " + count);
    }
);

// endregion