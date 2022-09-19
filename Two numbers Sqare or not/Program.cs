
//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
using static System.Console;
Clear();

int x = int.Parse(ReadLine()!);
int y = int.Parse(ReadLine()!);

if (x<y)
{
    int temp =x;
    x=y;
    y=temp;
}

if(x==y*y) 
{
    WriteLine($"{x} является квадратом {y}");
}
else
{
 WriteLine($"{x} не является квадрато{y}");   
}
