//Write a JavaScript function that replaces in a HTML document given as string 
//all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

function replace() {
    function replaceTags(text) {
        var pattern = /<a href="(.*?)">(.*?)<\/a>/gi;

        return text.replace(pattern, function (tag, url, message) {
            return "[URL=" + url + ']' + message + '[\/URL]';
        });
    }

    var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';
    var escapedHtml = replaceTags(html);

    jsConsole.writeLine(html);
    jsConsole.writeLine(escapedHtml);
}

replace();

