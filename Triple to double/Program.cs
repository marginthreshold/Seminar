//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4  -> кратно
using static System.Console;
Clear();


int number= new Random().Next(100,1000);
WriteLine(number);

int x=(number/100)*10;
int y=number%10;

WriteLine(x+y);