/* //ЗАДАНИЕ 10:
int a = Convert.ToInt32(Console.ReadLine());

int res = ((a / 10) % 10);

Console.WriteLine(res); 

   //ЗАДАНИЕ 13

Console.Write("Веддите трехначенное число ");
int a = Convert.ToInt32(Console.ReadLine()); 

if (( a > 100) && (a < 1000))
{
    Console.WriteLine( $"Третья цифра {a} будет ровна " + a % 10);
}
else
{
    Console.WriteLine($"Число {a} не является трехзначенным!");
} */

    //ЗАДАНИЕ 15
Console.Write("Веддите число и я подскажу выходной ли это день: ");
int a = Convert.ToInt32(Console.ReadLine()); 

if (a == 1)
{
    Console.Write("Понедельник, не является выходным");
}
else if (a == 2)
{
    Console.Write("Вторник, не является выходным");
}
else if (a == 3)
{
    Console.Write("Среда, не является выходным");
}
else if (a == 4)
{
    Console.Write("Четверг, не является выходным");
}
else if (a == 5)
{
    Console.Write("Пятница, не является выходным");
}
else if (a == 6)
{
    Console.Write("Суббота, является выходным днем!");
}
else if (a == 7)
{
    Console.Write("Воскресенье, является выходным днем!");
}
else
{
    Console.Write("Нет такого дня недели");
}