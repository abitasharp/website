var WebSocketClient = function () {

    const connection_url = "wss://localhost:5000/ws"

    this.connect = function () {
        this.socket = new WebSocket(connection_url);
        this.socket.onopen = function (event) {
            // TODO: connect
        };
        this.onclose = function (event) {
            // TODO: close
        };
        this.onerror = function (event) {
            // TODO: error
        };
        this.onmessage = function (event) {
            var message = JSON.parse(event.data);
            switch (message.type) {
                case "positions":

                    break;

                case "previews":

                    break;
            }
        }
    };

    this.disconnect = function () {
        this.socket.close();
    }
}
WebSocketClient();