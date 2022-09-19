using static System.Console;
Clear();

int number=new Random().Next(100,1000);
WriteLine(number);
int x= number/100;
int y=(number - x*100)/10;
int z=number%10;

if (z==0) WriteLine("0"y*10+x);
else
{
WriteLine(z*100+y*10+x);
}