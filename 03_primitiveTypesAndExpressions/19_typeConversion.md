### Type Conversion

implicit type conversion
explicit type conversion (casting)
conversion between non-compatible types

*** Implicit type ***
byte b = 1; (takes 1 byte of memory)
int i = b; (types 4 bytes of memory)

thus we can easily convert a byte into an integer, since its going from smaller to bigger. 

at runtime it goes from:
byte 0000 0001
int 0000 0000  0000 0000  0000 0000  0000 0001

int i = 1;
float f = i;

*** Explicit type conversion ***
int i = 1; 
byte b = i; //won't compile!

an integer is 4 bytes, so we conver that to a byte ... 3 out of 4 bytes will be gone => chance for data loss. Only happens if data stored in the int is beyond the capacity of the byte. i.e. if int is 300. 

When compiler knows there is a chance for data loss, it doesn't allow implicit type conversion. You need to explicitly tell the compiler, you're aware of the data loss and still want to go ahead with conversion. Aka, ***casting***: 

int i = 1;
byte b = (byte)i;

or: 
float f = 1.0f;
int i = (int)f;

*** Non-compatible types ***

string s = "1";
int i = (int)s; //won't compile

because string and int are not compatible, they cannot use explicit casting. need a different mechanism. ie.: convert class, or parse method.

string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s);

convert class is part of the .NET framework, defined in the system namespace. it has a bunch of methods for converting various types to other types. I.e. int32 is a .net framework type that maps to the c# int type.

Convert class methods:
- ToByte()
- ToInt16()
- ToInt32()
- ToInt64()

All primitive types have the .Parse method!

