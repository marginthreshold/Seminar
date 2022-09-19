using static System.Console;


Clear();
WriteLine("Введите число");
int number1 = Convert.ToInt32(ReadLine());
int number2=int.Parse(ReadLine()!);
int square2=Convert.ToInt32(Math.Pow(number2,2));
int square = number1 * number1;
WriteLine("Квадрат числа равен " + square);
WriteLine($"Квадрат числа {number2} равен {square2}");