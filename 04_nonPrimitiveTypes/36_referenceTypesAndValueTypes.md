### Reference Types and Value Types

arrays => System.Array
strings => System.String

In c# we have two main types from which we create new types: 
Structures => All primitive types, custom classes
Classes => Arrays, strings, custom classes

Treated differently at runtime in terms of memory management. 

***Value Types***
- Structures are called "value types".
- Variables created using value types, allocated by a part of memory called 'stack'
- memory allocation done automatically
- When variable goes out of scope, it will be immediately removed by stack.

***Reference Types***
- Classes are called "reference types".
- You need to allocate memory itself 
- Memory allocated on heap (this memory, unlike stack, is more sustainable). If object goes out of scope, it will remain in the heap and wont be removed immediately. 
- garbage collected by CLR once in awhile.

***Pragmatic knowledge***
When you copy an object to another object, depending on wether that object is a value type or a reference type, there will be two different outcomes. 

