Console.WriteLine("Write a three-digit number: ");
int number= int.Parse(Console.ReadLine());
int digit=number/1;
if (number>=100)
{
    if (number<=999) 
    digit=digit%10;
    Console.WriteLine(digit);
}
if (number<100)
Console.WriteLine("There is no third digit.");
if (number>(-100))
{
    if (number<100)
    Console.WriteLine("Let's try again.");
}
if (number>999)
Console.WriteLine("Sorry, it is inappropriate number, write a three-digit number!");
if (number<-999)
Console.WriteLine("Sorry, it is inappropriate number, write a three-digit number!");