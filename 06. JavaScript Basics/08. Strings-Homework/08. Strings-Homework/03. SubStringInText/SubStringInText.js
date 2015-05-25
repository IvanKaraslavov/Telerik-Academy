//Write a JavaScript function that finds how many times a substring is contained in a given text 
//(perform case insensitive search).

function findTheTextInTarget(target, text) {
    var modifier = 'gi';
    var regex = new RegExp(target, modifier);

    var result = text.match(regex).length;
    jsConsole.writeLine("The word " + target + " is found " + result + " times.")
}

var text = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';
findTheTextInTarget('in', text);