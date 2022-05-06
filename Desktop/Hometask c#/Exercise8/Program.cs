Console.WriteLine("Write a number: ");
int number=int.Parse(Console.ReadLine());
Console.WriteLine("Ok, we'll get a random number and check is that multiple for yours or no..");
int random=new Random().Next(-10000,100000);
Console.WriteLine(random);

int multiple=random%number;

if (multiple>0)
Console.WriteLine("Random number is'nt multiple for yours, the remainder is: "+multiple);
if (multiple<0)
Console.WriteLine("Random number is'nt multiple for yours, the remainder is: "+multiple);

if(multiple==0)
Console.WriteLine("Random number is multiple for yours: "+random+"/"+number+"="+random/number);
