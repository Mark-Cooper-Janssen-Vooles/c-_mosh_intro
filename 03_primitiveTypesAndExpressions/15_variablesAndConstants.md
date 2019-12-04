### Variables / Constants

Variable: A name given to a storage location in memory.

Constant: an immutable value. Value cannot change through life of application, and we know it at compile time. I.e. Pi = 3.14

to declare a variable, we start with the type, the name(identifier) and then the semicolon:

int number;
or
int Number = 1;

identifiers are case sensitive. 

You cannot use a variable unless you initialize it (i.e. you can't use number, but you can use Number)

const float Pi = 3.14f;

to declare a constant: start with const, then data type, identifier, and value. CANNOT start a constant without defining its value!

*** Identifiers: ***

Cannot start with a number: i.e. 1route (incorrect). 
Cannot include whitespace i.e. first name
Cannot be a reseved keyword, i.e. int. If you desperetly need to you can prefix with @ like: @int
Use meaningful names that are readable! Not fn, but firstName.

Three popular naming conventions: 
- Camel Case: firstName
- Pascal Case: FirstName
- Hungarian Notation: strFirstName (hungarian notation prefixes the identifier with the datatype it uses, i.e. str for string. not usually used in C#)

Convention:
- For local variables: Camel Case ie. int number;
- For constants: Pascal Case, i.e. const int MaxZoom = 5;

*** Primitive Types ***
"integral numbers"
- byte, 1 byte (0 to 255)
- short, 2 bytes (-32,768 to 32,767)
- int, 4 bytes (-2.1B to 2.1B)
- long, 8 bytes ...
"real numbers"
- float, 4 bytes 
- double, 8 bytes 
- decimal, 16 bytes
"Character"
- char, 2 bytes
"Boolean"
- bool, 1 byte

(less bytes is better, less storage / memory used) The more precision you need, the more bytes.


Real numbers are a bit tricky: 
double is the default data type used by compiler. If you want to declare a float or a decimal, you need to explicitly say so. 

i.e.:
float number = 1.2f;
decimal number = 1.2m;


*** Non-primitive types ***
- String
- Array
- Enum
- Class

