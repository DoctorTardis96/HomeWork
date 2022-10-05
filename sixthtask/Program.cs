//Задача 13: Напишите метод, который выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трехзначное число: ");
string str = (Console.ReadLine());
if(str.Contains ('3'))
{
Console.WriteLine(str[2]);
}
else
Console.WriteLine("Третей цифры в числе нет");


