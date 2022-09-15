using static System.Console;

WriteLine("Введите день недели от 1 до 7:");
int DayOfWeek = Convert.ToInt32(ReadLine());
string Day ="Неправильно ввели день недели";

if(DayOfWeek==1) Day= "Понедельник";
if(DayOfWeek==2) Day= "Вторник";
if(DayOfWeek==3) Day= "Среда";
if(DayOfWeek==4) Day= "Четверг";
if(DayOfWeek==5) Day= "Пятница";
if(DayOfWeek==6) Day= "суббота";
if(DayOfWeek==7) Day= "Воскресенье";


WriteLine(Day);