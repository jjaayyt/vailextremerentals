var ContactPage = function () {

    return {

        //Basic Map
        initMap: function () {
            var map;
            $(document).ready(function () {
                map = new GMaps({
                    div: '#map',
                    scrollwheel: true,
                    lat: 39.640183,
                    lng: -106.374319,
                    zoom: 10
                });

                var marker = map.addMarker({
                    lat: 39.640183,
                    lng: -106.374319,
                    title: 'Vail, Colorado'
                });

                var marker = map.addMarker({
                    lat: 39.630804,
                    lng: -106.522786,
                    title: 'Avon, Colorado'
                });

                var marker = map.addMarker({
                    lat: 39.654824, 
                    lng: -106.828644,
                    title: 'Eagle, Colorado'
                });

                var marker = map.addMarker({
                    lat: 39.647340,
                    lng: -106.951203,
                    title: 'Gypsum, Colorado'
                });

                var marker = map.addMarker({
                    lat: 39.481007,
                    lng: -106.039213,
                    title: 'Breckenridge, Colorado'
                });

                var marker = map.addMarker({
                    lat: 39.630124,
                    lng: -106.060496,
                    title: 'Silverthorne, Colorado'
                });

                var marker = map.addMarker({
                    lat:39.769977,
                    lng:-105.814963,
                    title: 'Berthoud Falls, Colorado'
                });

                var marker = map.addMarker({
                    lat:39.605356,
                    lng:-105.976793,
                    title: 'Keystone, Colorado'
                });
            });
        },


        

        


        //Panorama Map
        initPanorama: function () {
            var panorama;
            $(document).ready(function () {
                panorama = GMaps.createPanorama({
                    el: '#panorama',
                    lat: 39.640183,
                    lng: -106.374319
                });
            });
        }

    };
}();