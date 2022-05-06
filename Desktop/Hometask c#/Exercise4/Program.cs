Console.WriteLine("Write a number from 2: ");
int number= int.Parse(Console.ReadLine());
if (number<1)
Console.WriteLine("Sorry, it is inappropriate number, write a number from 2!");
while (number>=2)
{ 
 if (number%2==0)
   { 
   Console.Write(number+" ");
   number=number-1;
   }
 else
   number=number-1;
}