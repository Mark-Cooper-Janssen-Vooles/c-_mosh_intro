### C# vs .NET

C# is a programming language, .NET is a framework for building apps on windows. 

.NET consists of:
CLR (common language runtime)
Class Library (for building apps)

### CLR: 

Before C#, we had two languages in the C family. C and C++. The compiler translated this code into the native code on which the machine it was running. I.e. if it ran on windows, it wouldnt run on Linux. 

On java, it is compiled first into an intermediate code "bite code". Then into native code. C# took this idea, and has an intermediate compiler "IL Code".

It then uses JIT compilation (just in time) from the IL Code to the machines native code at runtime.

### Architecutre of .NET applications

When you build an app with C#, your app consists of classes. They collaborate with each other at runtime, and as a result the app provides some functionality. 

A class is a container with has data (attributes) and functions (also called methods).

As the number of classes in an application grows, we need a way to organise these. Thats when we use a namespace. A namespace is a container for related classes. I.e. namespaces for working with data, for working with graphics and images, for security, etc. 

As namespaces grow, we need a different way or partitioning namespaces. Thats where we use an assembly (DLL or EXE) - a container for related namespaces. Physically a file on the disk which is either an executable or a DLL (dynamically linked library). 

When you compile an application, the compiler builds one or more assemblys (depending on how you partition your code).