### Iteration Statements

used for repeatedly executing a series of statements

in C# we have four iteration statements:
- for loops
- foreach loops
- while loops
- do-while loops

***for loops:***
for(var i = 0; i < 10 ; i++ )
{

}

var i = 0 => sets the initialization (where the counter starts)
i < 10 => the condition where the loop stops
i++ => iteration clause (what happens each time the loop is run)

***foreach loops***
used to iterate through elements of a enumerable object.
an enumerable object is anything with some kind of list / array nature, same as string. 

doing it with a foreach is easier and cleaner:

foreach (var number in numbers)
{

}

number is a local or "temporary" variable.
numbers is the enumerable (i.e. array)

***while loops***
aka as long as the condition is valid, the loop will run. 
while(i < 10)
{
  i++;
}

***do-while loops***
do
{
  i++
} while (i < 10)

only difference to while is that the loop is executed AT LEAST once. probs better not to use lol.

***break and continue***
"Break" => jumps out of the loop
"continue" => jumps to the next iteration
