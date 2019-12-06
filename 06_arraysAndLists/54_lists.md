### Lists

THESE DAYS: 
We use lists 99.9% of the time!!

Arrays have a fixed size: once you create them, the size cannot be changed. 

If you're not sure how many elements you'll work with, you need to use a list. 

Array: fixed size
List: dynamic size

***Creating lists***

var numbers = new List<int>();
can create a list of anything, primitive or non-primitive, or even a class you make.

var numbers = new List<int>() {1, 2, 3, 4};
initilizes with these elements.

Add() => adds an element to the list 
AddRange() => to add a list of objects.. could be another list or an array
Remove() => removes one object
RemoveAt() => removes object at given index
IndexOf() => returns the index of the given object.
Contains() => tells us if the list contains the given object or not
Count => returns the number of elements in the list