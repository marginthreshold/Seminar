Console.Clear();
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2=int.Parse(Console.ReadLine()!);
int square2=Convert.ToInt32(Math.Pow(number2,2));
int square = number1 * number1;
Console.WriteLine("Квадрат числа равен " + square);
Console.WriteLine($"Квадрат числа {number2} равен {square2}");