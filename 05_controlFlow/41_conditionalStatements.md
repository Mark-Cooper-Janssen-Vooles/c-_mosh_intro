### Conditional Statements

***if / else statements*** 
syntax:
if (condition)
  someStatement
else if (condition2)
  anotherStatement
else
  yetAnotherStatement

if more than one line of code: 
if(condition)
{
  someStatements
}
else 
{
  otherStatements
}

//mosh says multiple nested if statements: hard to understand, test, maintain... CODE SMELL
can also nest if statmenets:
if(condition)
{
  if(anther condition)
    statement
  else
    statement2
}

***switch / case statements***

switch(role)
{
  case Role.Admin;
    statement;
    break;
  case Role.Moderator;
    statement2;
    break;
  default; (if none of the above are true)
    statement3;
    break;
}


***conditional operator =>  a ? b : c***