Console.WriteLine("Write a three-digit number: ");
int number=int.Parse(Console.ReadLine());
if (number<100)
Console.WriteLine("Sorry, it is inappropriate number and your answer would be incorrect, write a three-digit number!");
if (number>999)
Console.WriteLine("Sorry, it is inappropriate number and your answer would be incorrect, write a three-digit number!");

int digit1=number/100;
digit1=digit1%10;
int digit2=number/10;
digit2=digit2%10;
int digit3=number%10;

Console.Write(digit1+""+digit3);