

void EasyMethod()
{
    Console.Write("Введите нумерацию дня ");
    var day = int.Parse(Console.ReadLine());
    if (day == 6)
    {
        Console.Write("Выходной день:Суббота");
    }
    if (day == 7)
    {
        Console.Write("Выходной день:Воскресенье");
    }
    if (day == 5)
    {
        Console.Write("Рабочий день");
    }
    if (day == 4)
    {
        Console.Write("Рабочий день");
    }
    if (day == 3)
    {
        Console.Write("Рабочий день");
    }
    if (day == 2)
    {
        Console.Write("Рабочий день");
    }
    if (day == 1)
    {
        Console.Write("Рабочий день");
    }
}

EasyMethod();