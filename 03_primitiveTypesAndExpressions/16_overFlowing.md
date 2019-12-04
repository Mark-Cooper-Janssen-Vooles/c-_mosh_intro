### Overflowing

byte number = 255;
number = number + 1;(equates to 0)

since bytes max number is 255, it exceeds the boundry of the byte data type. In C# we don't have "overflow checking": if we go beyond the boundry, we get overflow.

To stop overflow you need to use checked keyword:

checked 
{
  byte number = 255;
  number = number + 1;
}

with this code, overflow will not happen at runtime. An exception will be thrown and the program will crash unless we handle the exception.