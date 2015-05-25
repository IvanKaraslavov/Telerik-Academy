//Write a function that replaces non breaking white-spaces in a text with &nbsp;

function escapeWritespaces(text)
{
    var newSubstring = "&nbsp;";
    var result = text.replace(/ /g, newSubstring);
    console.log(result);
}

var text = 'This is a text      with many     whitespaces   .'
escapeWritespaces(text);