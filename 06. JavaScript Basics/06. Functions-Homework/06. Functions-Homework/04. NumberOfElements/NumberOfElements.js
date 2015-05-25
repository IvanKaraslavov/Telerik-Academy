//Write a function to count the number of div elements on the web page

function numberOfElement() {
    jsConsole.writeLine("There are "+ document.getElementsByTagName('div').length + " divs in the HTML document");
}

numberOfElement();