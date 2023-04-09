Console.Write("Введите деннь редели: ");
string text = Console.ReadLine();
int numberDayWeek = Convert.ToInt32(text);

if (numberDayWeek == 1)
{
    Console.WriteLine("Monday");
}
if (numberDayWeek == 2)
{
    Console.WriteLine("tuesday");
}
if (numberDayWeek == 3)
{
    Console.WriteLine("Wednesday");
}
if (numberDayWeek == 4)
{
    Console.WriteLine("Thursday");
}
if (numberDayWeek == 5)
{
    Console.WriteLine("Friday");
}
if (numberDayWeek == 6)
{
    Console.WriteLine("Saturday");
}
if (numberDayWeek == 7)
{
    Console.WriteLine("Sunday");
}
if (numberDayWeek < 1)
{
    Console.WriteLine("Нет такого дня недели");
}
if (numberDayWeek > 7)
{
    Console.WriteLine("Нет такого дня недели");
}