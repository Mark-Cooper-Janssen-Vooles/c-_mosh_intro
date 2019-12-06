### Arrays

Two types: 
single dimension arrays 
i.e. 
var numbers = new int[5] { 1, 2, 3, 4, 5};

multi-dimension arrays:
"rectangular"
i.e. 3x5

0 1 2 3 4
0 1 2 3 4
0 1 2 3 4

"jagged"
array of arrays. i.e. a single dimension array with 3 elements (and each element is a row, another single dimension array)
rows have different number of columns.
0 1 2 3 
0 1 2 3 4 
0 1 2

in .NET CLR is optimised around single dimension arrays. If you want to implement a matrix, its faster to do using a jagged array than a rectangular array. 


***Syntax***
rectangular 2d array:
var matrix = new int[3, 5];
in the square brackets, we need to specify the dimensions of the array. 3 rows, 5 columns. 

if we know the values we would like to store in this array ahead of time, we can initialize it like so: 

var matrix = new int[3, 5] 
{
  {1, 2, 3, 4, 5},
  {6, 7, 8, 9, 10},
  {11, 12, 13, 14, 15}
}

if you want to access an element in this array, you can use: 
var element = matrix[0, 0];
(specifying the row then column).


rectangular 3D:
var colors = new int[3, 5, 4];


jagged:
0 1 2 3 
0 1 2 3 4 
0 1 2

array of arrays
var array = new int[3][];
the first [] represents how many elements in top-level array (i.e. rows)

now we initialize each element of this array to a different array:
array[0] = new int[4];
array[1] = new int[5];
array[2] = new int [3];

to assign a value to [0][0]: 
array[0][0] = 1;


***Methods***
Properties:
Length 

Methods:
Clear()
Copy()
IndexOf()
Reverse()
Sort()