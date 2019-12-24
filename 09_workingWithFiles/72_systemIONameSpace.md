## System.IO
many classes in this namespace. very common ones that we will find useful:

- File, FileInfo
- Directory, DirectoryInfo
- Path


***File, FileInfo:***
Both provide methods for creating, copying, deleting, moving and opening files. 
- FileInfo: provides instance methods
- File: provides static methods 

Why do we need different classes for static or instance methods? 

If theres only a small number of operations: more convenient to use static methods of file class. But when you call file's static methods, security checking is done by the operating system.

If a large number of operations, more efficient to use fileInfo class. Security checking is done only once (during creating of a fileInfo object).

List of methods: 
- Create()
- Copy()
- Delete()
- Exists()
- GetAttributes()
- Move()
- ReadAllText()

***Directory, DirectoryInfo***
Use either of these classes to work with directories. 
- Directory: provides static methods
- DirectoryInfo: provides instance methods 

List of methods: 
- CreateDirectory()
- Delete()
- Exists()
- GetCurrentDirectory() => where app is currently sitting 
- GetFiles() => files in your directory. can provide filters, like only files with a .jpeg extension
- Move()
- GetLogicalDrives()  => returns drives of your hard disk like C drive, D drive etc. 

***Path***
PRovides methods to work with a string that provides a file directory path 
- GetDirectoryName()
- GetFileName()
- GetExtension()
- GetTempPath()


