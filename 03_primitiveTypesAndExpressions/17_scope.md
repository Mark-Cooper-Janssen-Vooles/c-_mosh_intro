### Scope

Where a variable or constant has meaning / is accessible. 

A block is indicated by curly braces. Heres three blocks of code: 

{
  byte a = 1;
  {
    byte b = 2;
    {
      byte c = 3;
    }
  }
}

a is accessible in the a block, b block and c block. 
b is accessible in the b block and c block.
c is only accessible in the c block.