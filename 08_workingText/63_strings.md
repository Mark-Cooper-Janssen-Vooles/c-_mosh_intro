## Strings

- Useful string methods 
- convert a string to a number
- convert a number to a string


.ToLower()  //converts all characters to lower case.

.ToUpper() //converts all characters to upper case.

.Trim() //gets rid of white spaces around a string

---

To ***search for a character*** or a string inside a given string, you can use:

.IndexOf('a')

.LastIndexOf("Hello") //strings are similar  to arrays in c#. I.e. an array of characters

---

Create a ***substring*** of a given string: 

.Substring(startIndex)

.Substring(startIndex, length)

---

***Replacing***
To replace a given character or given substring:

Replace('a', '!')

Replace("mosh", "moshfegh")

---

***Null checking***

String.IsNullOrEmpty(str)

String.IsNullOrWhiteSpace(str)

---

***Splitting***

str.Split(' '); //if a sentance with multiple words, each word will be split (an array of strings, each element containing a word)

---

Converting ***Strings to Numbers***
Converting a string to a numeric value: 

string s = "1234";
both do the same:
int i = int.Parse(s);
int j = Convert.ToInt32(s); //mosh prefers this method, cos if it is null or empty it will return 0. int.Parse throws an exception.

---

Converting ***Numbers to Strings***

int i = 1234;
string s = i.ToString();  // "1234"
string t = i.ToString("C"); // "$1,234.00"  => format string, C is short for currency. 
string t = i.ToString("C0");  //$1,234"  => format string without decimals. For one decima use C1.

List of format specifiers: 

c or C => Currency => 123456 to $123,456.00
d or D => Decimal => 1234 (D6) to 001234
e or E => Exponential => 1052.0329112756 (E) to 1.052033E+003
f or F => Fixed Point => 1234.567(F1) to 1234.5
x or X => Hexadecimal => 255 to FF 





