function returnSomeJson() {

    return [
        {
            id: 1,
            nazwa: "Henio",
            dlugosc: 151,
            events: {
                id: 1,
                nazwa: "grill u Bartka",
                tresc: "Woda , dziwki, lasery"
            }
        },
        {
            id: 2,
            nazwa: "Czesio",
            dlugosc: 151,
            events: {
                id: 1,
                nazwa: "grill u Bartka",
                tresc: "Woda , dziwki, lasery"
            }
        }
    ];
}

function renderJson(someJson) {
    var test = someJson;
    console.log(someJson);

    for (i = 0; i < someJson.length; i++) {
        var item = someJson[i];
        var html = returnHtml(item);
        document.write(html);
    }
}

function returnHtml(json) {
    var html = "<div>" +
        "<span>" + json.nazwa + 
        "</span>" +
        "<span>" + json.dlugosc +
        "</span>" +
        "</div>";
    return html;
}