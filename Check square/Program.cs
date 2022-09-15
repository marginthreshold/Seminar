using static System.Console;


Clear();
WriteLine("Введите число");
int number1 = Convert.ToInt32(ReadLine());
WriteLine("Введите квадрат числа");
int number2=int.Parse(ReadLine()!);

int square2=Convert.ToInt32(Math.Pow(number1,2));
//int square = number1 * number1;
//WriteLine("Квадрат числа равен " + square);
if (number2==square2)
{
 WriteLine("да");   
}
else
{
 WriteLine("нет!");   
}


