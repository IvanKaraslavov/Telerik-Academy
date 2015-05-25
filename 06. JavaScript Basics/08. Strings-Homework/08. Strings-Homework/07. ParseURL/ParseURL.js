//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] 
//and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.

function parseURL(urlAddress) {
    function extractURLElements(url) {
        var pattern = /(.*):\/\/(.*?)(\/.*)/g;

        return pattern.exec(url);
    }


    var fragments = extractURLElements(urlAddress);

    // Convert to JSON object
    var jsonObject = JSON.stringify({
        protocol: fragments[1],
        server: fragments[2],
        resource: fragments[3]
    });


    // Parse JSON object to JS object
    var jsObject = JSON.parse(jsonObject);

    jsConsole.writeLine("URL Address: " + urlAddress);
    jsConsole.writeLine("[protocol] = " + jsObject.protocol);
    jsConsole.writeLine("[server] = " + jsObject.server);
    jsConsole.writeLine("[resource] = " + jsObject.resource);
}
parseURL('http://telerikacademy.com/Courses/Courses/Details/239');