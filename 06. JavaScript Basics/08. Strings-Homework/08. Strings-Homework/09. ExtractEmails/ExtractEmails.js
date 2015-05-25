//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.

function getEmails(text) {
    return text.match(/([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9._-]+)/gi);
}

var text = '(+001 222 222 222), example@gmail.com, test.user@yahoo.co.uk, test@test, @gmail.com, a@a.b, valid@email.com, "just message" <rfernsdfson@gmal.com>, <admin@truformdftechnoproducts.com>, <manager@ysahoo.in>';

jsConsole.writeLine(getEmails(text).join('\n\r'));