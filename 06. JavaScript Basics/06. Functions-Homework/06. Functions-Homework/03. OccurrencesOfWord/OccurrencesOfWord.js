//Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.

function occurrences(text, word, sensitive) {
    var occurrences = 0;
    var caseSensitive = sensitive || false;
    var editPunctuation = text.replace(/\W+/g, ' ')
    var words = editPunctuation.split(' ');
    if (caseSensitive) {
        for (var i = 0; i < words.length - 1; i++) {
            if (word === words[i]) {
                occurrences++;
            };
        }
    }
    else {
        var lowerCase = word.toLowerCase();
        for (var i = 0; i < words.length - 1 ; i++) {
            if (word === words[i].toLowerCase()) {
                occurrences++;
            };
        }
    }
    jsConsole.writeLine("The word '" + word + "' is found " + occurrences + " times.")
}


occurrences('hello,hello,there,and, hello again', 'hello', true);