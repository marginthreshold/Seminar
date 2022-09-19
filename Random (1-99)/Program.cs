//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

using static System.Console;
Clear();


int number=new Random().Next(10,100);
WriteLine(number);

int x= number%10;
int y=(number-x)/10;

int max=Math.Max(x,y);
WriteLine(max);