using static System.Console;
Clear();
WriteLine("Введите X ");
int X=int.Parse(ReadLine()!);

WriteLine("Введите Y ");
int Y=int.Parse(ReadLine()!);

if (X==0 || Y==0)
{
WriteLine("Не должен быть равен нулю");
return;
}


if(X>0 && Y>0)
{
    WriteLine("Первая четверть");
}
if(X<0 && Y>0)
{
    WriteLine("Вторая четврть");
}
if(X<0 && Y<0)
{
    WriteLine("Третья четверть");
}
if(X>0 && Y<0)
{
    WriteLine("Четвертая четверть");
}
