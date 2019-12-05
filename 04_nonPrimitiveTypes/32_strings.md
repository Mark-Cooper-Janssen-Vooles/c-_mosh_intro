### Strings

A string is a sequence of characters, e.g. "Hello World"

use double quotes to surround.

***Creating Strings***

string literal:
string firstName = "Mark";

string concatenation:
string name = firstName + " " + lastName;

string format: (combines multiple strings together)
string name = string.Format("{0} {1}", firstName, lastName);

string join: (create a string from array using a seperator)
var numbers = new int[3] {1, 2, 3};
string list = string.Join(",", numbers);

***string Elements***

can access all of a strings individual characters using an index. 

string name = "Mark";
char firstChar = name[0];

***Strings are immutable***

i.e. once you create them, you cannot change them.

i.e. when you have name[0] == 'M';
you can't then say name[0] == 'P';

There are methods in the string class that allow us to modify their values, but all these methods return a new string. The original string is not changed (its immutable)

***Escape Characters***
\n ; new line
\t ; tab
\\ ; backslash character itself (lol)
\' ; single quotation mark
\" ; double quotation mark


***Verbatim strings***

string path = "c:\\projects\\project1\\folder1";

can look a bit messy. theres something called verbatim string: prefix it with an @ and you can use normal stuff.

string path = @"c:\projects\project1\folder1";