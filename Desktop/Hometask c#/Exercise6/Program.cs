int number= new Random().Next(10,99);
Console.WriteLine(number);
int digit1=number/10;
digit1=digit1%10;
int digit2=number/1;
digit2=digit2%10;

if (digit1>digit2)
Console.WriteLine(digit1+" is the biggest one");
else
Console.WriteLine(digit2+" is the biggest one");