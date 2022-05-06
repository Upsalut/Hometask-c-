Console.WriteLine("Write a three-digit number: ");
int number = int.Parse(Console.ReadLine());

if (number<100)
Console.WriteLine("Sorry, it is inappropriate number and your answer would be incorrect, write a three-digit number!");
if (number>999)
Console.WriteLine("Sorry, it is inappropriate number and your answer would be incorrect, write a three-digit number!");

int digit= number/10;
digit=digit%10;
Console.WriteLine(digit);