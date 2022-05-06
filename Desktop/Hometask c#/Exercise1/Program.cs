Console.Write("Write a number: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Write another one: ");
int y = int.Parse(Console.ReadLine());

if (x==y*y)
Console.Write("Digits checked and "+x+" is square of the number "+y);

else
Console.Write("Digits checked, there are no squares of number");