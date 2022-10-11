//Напишите метод, который выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.

void EasyMethod()
{
    Console.Write("Введите число: ");
    var n = int.Parse(Console.ReadLine());
    Console.WriteLine(n > 99 ? n.ToString()[2] : "третьей цифры нет.");
}
EasyMethod();